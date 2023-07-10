﻿using Dalamud;
using Dalamud.Game;
using Dalamud.Game.DutyState;
using Dalamud.Game.Gui.Dtr;
using Dalamud.Hooking;
using Dalamud.IoC;
using Dalamud.Utility.Signatures;
using ECommons.DalamudServices;
using FFXIVClientStructs.Attributes;
using FFXIVClientStructs.FFXIV.Client.Game;
using ImGuiScene;
using Lumina.Excel;
using RotationSolver.Basic.Configuration;
using System.Runtime.InteropServices;

namespace RotationSolver.Basic;

internal class Service
{
    public const string Command = "/rotation";

    // From https://github.com/PunishXIV/Orbwalker/blame/master/Orbwalker/Memory.cs#L85-L87
    [Signature("F3 0F 10 05 ?? ?? ?? ?? 0F 2E C6 0F 8A", ScanType = ScanType.StaticAddress, Fallibility = Fallibility.Infallible)]
    static IntPtr forceDisableMovementPtr;
    private static unsafe ref int ForceDisableMovement => ref *(int*)(forceDisableMovementPtr + 4);
    internal static unsafe bool CanMove
    {
        get => ForceDisableMovement == 0;
        set => ForceDisableMovement = value || DataCenter.NoPoslock ? 0 : 1;
    }

    public static float CountDownTime => Countdown.TimeRemaining;

    public static PluginConfiguration Config { get; set; }
    public static PluginConfiguration Default { get; } = new PluginConfiguration();


    public Service()
    {
        SignatureHelper.Initialise(this);
    }
    public static ActionID GetAdjustedActionId(ActionID id)
        => (ActionID)GetAdjustedActionId((uint)id);

    public static unsafe uint GetAdjustedActionId(uint id)
    => ActionManager.Instance()->GetAdjustedActionId(id);

    public unsafe static IEnumerable<IntPtr> GetAddons<T>() where T : struct
    {
        if(typeof(T).GetCustomAttribute<Addon>() is not Addon on) return Array.Empty<nint>();

        return on.AddonIdentifiers
            .Select(str => Svc.GameGui.GetAddonByName(str, 1))
            .Where(ptr => ptr != IntPtr.Zero);
    }

    public static ExcelSheet<T> GetSheet<T>() where T : ExcelRow => Svc.Data.GetExcelSheet<T>();
}
