namespace RotationSolver.Basic.Rotations.Basic;

public partial class ViperRotation
{
    /// <inheritdoc/>
    public override MedicineType MedicineType => MedicineType.Dexterity;
    #region JobGauge
    /// <summary>
    /// Gets how many uses of uncoiled fury the player has.
    /// </summary>
    public static byte RattlingCoilStacks => JobGauge.RattlingCoilStacks;
    
    /// <summary>
    /// Gets Max stacks of Anguine Tribute.
    /// </summary>
    public static byte MaxRattling => EnhancedVipersRattleTrait.EnoughLevel ? (byte)3 : (byte)2;

    /// <summary>
    /// Gets Serpent Offering stacks and gauge.
    /// </summary>
    public static byte SerpentOffering => JobGauge.SerpentOffering;

    /// <summary>
    ///  Gets value indicating the use of 1st, 2nd, 3rd, 4th generation and Ouroboros.
    /// </summary>
    public static byte AnguineTribute => JobGauge.AnguineTribute;

    /// <summary>
    /// Gets the last Weaponskill used in DreadWinder/Pit of Dread combo. Dreadwinder = 1, HuntersCoil, SwiftskinsCoil, PitOfDread, HuntersDen, SwiftskinsDen
    /// </summary>
    public static DreadCombo DreadCombo => JobGauge.DreadCombo;

    /// <summary>
    /// Indicates that the player is not in a Dread Combo.
    /// </summary>
    public static bool NODREAD => (byte)JobGauge.DreadCombo == 0;

    /// <summary>
    /// Gets current ability for Serpent's Tail. NONE = 0, DEATHRATTLE = 1, LASTLASH = 2, FIRSTLEGACY = 3, SECONDLEGACY = 4, THIRDLEGACY = 5, FOURTHLEGACY = 6, TWINSREADY = 7, THRESHREADY = 8, UNCOILEDREADY = 9
    /// </summary>
    public static SerpentCombo SerpentCombo => JobGauge.SerpentCombo;

    /// <summary>
    /// Indicates if base Twins combo is ready.
    /// </summary>
    public static bool TWINSREADY => (byte)JobGauge.SerpentCombo == 7;

    /// <summary>
    /// Indicates if base Thresh combo is ready.
    /// </summary>
    public static bool THRESHREADY => (byte)JobGauge.SerpentCombo == 8;

    /// <summary>
    /// Indicates if base Uncoiled combo is ready.
    /// </summary>
    public static bool UNCOILEDREADY => (byte)JobGauge.SerpentCombo == 9;

    /// <summary>
    /// Gets Max stacks of Anguine Tribute.
    /// </summary>
    public static byte MaxAnguine => EnhancedSerpentsLineageTrait.EnoughLevel ? (byte)5 : (byte)4;
    #endregion

    #region Statuses

    /// <summary>
    /// Indicates if the player has Honed Steel.
    /// </summary>
    public static bool HasSteel => Player.HasStatus(true, StatusID.HonedSteel);

    /// <summary>
    /// Indicates if the player has Honed Reavers.
    /// </summary>
    public static bool HasReavers => Player.HasStatus(true, StatusID.HonedReavers);

    /// <summary>
    /// Indicates if the player does not have Honed Reavers or Honed Steel.
    /// </summary>
    public static bool NoHone => !Player.HasStatus(true, StatusID.HonedSteel) || !Player.HasStatus(true, StatusID.HonedReavers);

    /// <summary>
    /// Indicates if the player has upcoming Hind attack.
    /// </summary>
    public static bool HasHind => Player.HasStatus(true, StatusID.HindsbaneVenom) || Player.HasStatus(true, StatusID.HindstungVenom);

    /// <summary>
    /// Indicates if the player has upcoming Flanks attack.
    /// </summary>
    public static bool HasFlank => Player.HasStatus(true, StatusID.FlanksbaneVenom) || Player.HasStatus(true, StatusID.FlankstungVenom);

    /// <summary>
    /// Indicates if the player has upcoming Bane attack.
    /// </summary>
    public static bool HasBane => Player.HasStatus(true, StatusID.HindsbaneVenom) || Player.HasStatus(true, StatusID.FlanksbaneVenom);

    /// <summary>
    /// Indicates if the player has upcoming Bane attack.
    /// </summary>
    public static bool HasSting => Player.HasStatus(true, StatusID.HindstungVenom) || Player.HasStatus(true, StatusID.FlankstungVenom);

    /// <summary>
    /// Indicates if the player has no venom prepped.
    /// </summary>
    public static bool HasNoVenom => !Player.HasStatus(true, StatusID.HindstungVenom) && !Player.HasStatus(true, StatusID.FlankstungVenom) && !Player.HasStatus(true, StatusID.HindsbaneVenom) && !Player.HasStatus(true, StatusID.FlanksbaneVenom);

    /// <summary>
    /// Indicates if the player can use Reawakened.
    /// </summary>
    public static bool HasReawakend => Player.HasStatus(true, StatusID.Reawakened) || SerpentOffering >= 50;

    /// <summary>
    /// Indicates if the player has Swiftscaled.
    /// </summary>
    public static bool IsSwift => Player.HasStatus(true, StatusID.Swiftscaled);

    /// <summary>
    /// Indicates if the player has Hunters Instinct.
    /// </summary>
    public static bool IsHunter => Player.HasStatus(true, StatusID.HuntersInstinct);

    /// <summary>
    /// Time left on Swiftscaled.
    /// </summary>
    public static float? SwiftTime => Player.StatusTime(true, StatusID.Swiftscaled);

    /// <summary>
    /// Time left on Hunters Instinct.
    /// </summary>
    public static float? HuntersTime => Player.StatusTime(true, StatusID.HuntersInstinct);

    /// <summary>
    /// Indicates if the player has Hunters Venom.
    /// </summary>
    public static bool HasHunterVenom => Player.HasStatus(true, StatusID.HuntersVenom);

    /// <summary>
    /// Indicates if the player has Hunters Venom.
    /// </summary>
    public static bool HasSwiftVenom => Player.HasStatus(true, StatusID.SwiftskinsVenom);

    /// <summary>
    /// Indicates if the player has Fellhunters Venom.
    /// </summary>
    public static bool HasFellHuntersVenom => Player.HasStatus(true, StatusID.FellhuntersVenom);

    /// <summary>
    /// Indicates if the player has Fellskins Venom.
    /// </summary>
    public static bool HasFellskinsVenom => Player.HasStatus(true, StatusID.FellskinsVenom);

    /// <summary>
    /// Indicates if the player has Grimhunters Venom.
    /// </summary>
    public static bool HasGrimHunter => Player.HasStatus(true, StatusID.GrimhuntersVenom);

    /// <summary>
    /// Indicates if the player has Grimskins Venom.
    /// </summary>
    public static bool HasGrimSkin => Player.HasStatus(true, StatusID.GrimskinsVenom);

    /// <summary>
    /// Indicates if the player has Poised For Twinfang.
    /// </summary>
    public static bool HasPoisedFang => Player.HasStatus(true, StatusID.PoisedForTwinfang);

    /// <summary>
    /// Indicates if the player has Poised For Twinblood.
    /// </summary>
    public static bool HasPoisedBlood => Player.HasStatus(true, StatusID.PoisedForTwinblood);

    /// <summary>
    /// Indicates that Hunters Instinct is ending before Swiftscaled.
    /// </summary>
    public static bool HunterLessThanSwift => Player.StatusTime(true, StatusID.HuntersInstinct) < Player.StatusTime(true, StatusID.Swiftscaled);

    // <summary>
    /// Indicates that Swiftscaled is ending before Hunters Instinct.
    /// </summary>
    public static bool SwiftLessThanHunter => Player.StatusTime(true, StatusID.Swiftscaled) < Player.StatusTime(true, StatusID.HuntersInstinct);


    #endregion

    #region Actions

    static partial void ModifyWrithingSnapPvE(ref ActionSetting setting)
    {
        setting.SpecialType = SpecialActionType.MeleeRange;
    }

    static partial void ModifySlitherPvE(ref ActionSetting setting)
    {
        setting.SpecialType = SpecialActionType.MovingForward;
    }

    static partial void ModifySteelFangsPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && (HasSteel || NoHone);
    }

    static partial void ModifyHuntersStingPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && (HasNoVenom || HasFlank);
        setting.StatusProvide = [StatusID.HuntersInstinct];
        setting.CreateConfig = () => new ActionConfig()
        {
            ShouldCheckStatus = false,
        };
    }

    static partial void ModifyFlankstingStrikePvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && (HasNoVenom || (HasFlank && HasSting));
        setting.StatusProvide = [StatusID.HindstungVenom];
    }

    static partial void ModifyFlanksbaneFangPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && (HasNoVenom || (HasFlank && HasBane));
        setting.StatusProvide = [StatusID.HindsbaneVenom];
    }

    static partial void ModifyReavingFangsPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && HasReavers;
        setting.StatusProvide = [StatusID.HonedSteel];
    }

    static partial void ModifySwiftskinsStingPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && HasHind;
        setting.StatusProvide = [StatusID.Swiftscaled];
    }

    static partial void ModifyHindstingStrikePvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && (HasHind && HasSting);
        setting.StatusProvide = [StatusID.FlanksbaneVenom];
    }

    static partial void ModifyHindsbaneFangPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && (HasHind && HasBane);
        setting.StatusProvide = [StatusID.FlankstungVenom];
    }

    static partial void ModifySteelMawPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && (HasSteel || NoHone);
        setting.StatusProvide = [StatusID.HonedReavers];
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifyHuntersBitePvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && !Player.HasStatus(true, StatusID.GrimskinsVenom);
        setting.StatusProvide = [StatusID.HuntersInstinct];
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifyJaggedMawPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && !Player.HasStatus(true, StatusID.GrimskinsVenom);
        setting.StatusProvide = [StatusID.GrimskinsVenom];
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifyReavingMawPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY;
        setting.StatusProvide = [StatusID.HonedSteel];
        setting.StatusNeed = [StatusID.HonedReavers];
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifySwiftskinsBitePvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && !Player.HasStatus(true, StatusID.GrimhuntersVenom);
        setting.StatusProvide = [StatusID.Swiftscaled];
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifyBloodiedMawPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && !Player.HasStatus(true, StatusID.GrimhuntersVenom);
        setting.StatusProvide = [StatusID.GrimhuntersVenom];
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifySerpentsTailPvE(ref ActionSetting setting)
    {

    }

    static partial void ModifyDeathRattlePvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => SerpentCombo == SerpentCombo.DEATHRATTLE;
    }

    static partial void ModifyLastLashPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => SerpentCombo == SerpentCombo.LASTLASH;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifyVicewinderPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => SerpentOffering <= 90 && RattlingCoilStacks < MaxRattling && AnguineTribute == 0 && NODREAD && !THRESHREADY && !UNCOILEDREADY && !TWINSREADY;
    }

    static partial void ModifyHuntersCoilPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => DreadCombo == DreadCombo.Dreadwinder;
    }

    static partial void ModifySwiftskinsCoilPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => DreadCombo == DreadCombo.HuntersCoil;
    }

    static partial void ModifyVicepitPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => SerpentOffering <= 90 && RattlingCoilStacks < MaxRattling && AnguineTribute == 0 && NODREAD && !THRESHREADY && !UNCOILEDREADY && !TWINSREADY;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifyHuntersDenPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => DreadCombo == DreadCombo.PitOfDread;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifySwiftskinsDenPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => DreadCombo == DreadCombo.HuntersDen;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifyTwinfangPvE(ref ActionSetting setting)
    {

    }

    static partial void ModifyTwinbloodPvE(ref ActionSetting setting)
    {

    }

    static partial void ModifyTwinfangBitePvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => HasHunterVenom && TWINSREADY;
    }

    static partial void ModifyTwinbloodBitePvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => HasSwiftVenom && TWINSREADY;
    }

    static partial void ModifyTwinfangThreshPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => THRESHREADY & HasFellHuntersVenom;

        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifyTwinbloodThreshPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => THRESHREADY && HasFellskinsVenom;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 3,
        };
    }

    static partial void ModifyUncoiledFuryPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => RattlingCoilStacks >= 1 && !UNCOILEDREADY && NODREAD && !THRESHREADY && !TWINSREADY & !HasReawakend;
        setting.StatusProvide = [StatusID.PoisedForTwinfang];
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifyUncoiledTwinfangPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => UNCOILEDREADY && HasPoisedFang;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifyUncoiledTwinbloodPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => UNCOILEDREADY && HasPoisedBlood;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifySerpentsIrePvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => RattlingCoilStacks < MaxRattling && InCombat && !HasReawakend;
        setting.StatusProvide = [StatusID.ReadyToReawaken];
    }

    static partial void ModifyReawakenPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => NODREAD && !UNCOILEDREADY && !TWINSREADY && !THRESHREADY && (SerpentOffering >= 50 || Player.HasStatus(true, StatusID.ReadyToReawaken));
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifyFirstGenerationPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => (MaxAnguine == 5 && AnguineTribute == 5) || (MaxAnguine == 4 && AnguineTribute == 4);
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifySecondGenerationPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => (MaxAnguine == 5 && AnguineTribute == 4) || (MaxAnguine == 4 && AnguineTribute == 3);
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifyThirdGenerationPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => (MaxAnguine == 5 && AnguineTribute == 3) || (MaxAnguine == 4 && AnguineTribute == 2);
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifyFourthGenerationPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => (MaxAnguine == 5 && AnguineTribute == 2) || (MaxAnguine == 4 && AnguineTribute == 1);
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifyOuroborosPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => EnhancedSerpentsLineageTrait.EnoughLevel && AnguineTribute == 1;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifyFirstLegacyPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => SerpentCombo == SerpentCombo.FIRSTLEGACY;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifySecondLegacyPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => SerpentCombo == SerpentCombo.SECONDLEGACY;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifyThirdLegacyPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => SerpentCombo == SerpentCombo.THIRDLEGACY;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }

    static partial void ModifyFourthLegacyPvE(ref ActionSetting setting)
    {
        setting.ActionCheck = () => SerpentCombo == SerpentCombo.FOURTHLEGACY;
        setting.CreateConfig = () => new ActionConfig()
        {
            AoeCount = 1,
        };
    }
    #endregion
}