﻿namespace RotationSolver.Basic.Actions;

public interface IAction : ITexture
{
    bool Use();
    uint ID { get; }
    uint AdjustedID { get; }
    float RecastTimeOneCharge { get; }
    float AnimationLockTime { get; }
    uint SortKey { get; }

    /// <summary>
    /// Please don't use it.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    float RecastTimeElapsed { get; }

    /// <summary>
    /// Is action cooling down.
    /// </summary>
    bool IsCoolingDown { get; }

    /// <summary>
    /// Player's level is enough for this action's usage.
    /// </summary>
    bool EnoughLevel { get; }

    internal byte Level { get; }

    bool IsInCooldown { get; set; }
}
