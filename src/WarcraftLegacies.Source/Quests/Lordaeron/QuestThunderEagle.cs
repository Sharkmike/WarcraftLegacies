﻿using MacroTools.ControlPointSystem;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WarcraftLegacies.Source.Setup.Legends;
using static MacroTools.Libraries.Display;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Lordaeron
{
  /// <summary>
  /// Gain control of <see cref="LegendNeutral.DraktharonKeep"/> and the Storm Peaks control point to unlock Thunder Eagles.
  /// </summary>
  public sealed class QuestThunderEagle : QuestData
  {
    private new static readonly int ResearchId = Constants.UPGRADE_R04L_QUEST_COMPLETED_TO_THE_SKIES_LORDAERON;
    private static readonly int ThunderEagleId = Constants.UNIT_NWE2_THUNDER_EAGLE_LORDAERON;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestAshbringer"/> class
    /// </summary>
    public QuestThunderEagle() : base("To the Skies!",
      "The Thunder Eagles of the Storm Peaks live in fear of the Legion. Wipe out the Legion Nexus to bring these great birds out into the open.",
      "ReplaceableTextures\\CommandButtons\\BTNWarEagle.blp")
    {
      AddObjective(new ObjectiveControlLegend(LegendNeutral.DraktharonKeep, false));
      AddObjective(new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N02S_STORM_PEAKS_15GOLD_MIN)));
    }

    //Todo: bad flavour
    /// <inheritdoc/>
    protected override string CompletionPopup => "The Thunder Eagles are now in the safe hands of Lordaeron.";

    /// <inheritdoc/>
    protected override string RewardDescription => "Learn to train " + GetObjectName(ThunderEagleId) + "s";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      SetPlayerTechResearched(completingFaction.Player, ResearchId, 1);
      DisplayUnitTypeAcquired(completingFaction.Player, ThunderEagleId,
        "You can now train Thunder Eagles from upgraded Town Halls and from your capitals.");
    }
  }
}