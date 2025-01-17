﻿using MacroTools.ArtifactSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WarcraftLegacies.Source.Setup;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Lordaeron
{
  /// <summary>
  /// Acquire the <see cref="ArtifactSetup.ArtifactLivingshadow"/> and bring it to The Great Forge in Ironforge to gain The Ashbringer and Alexandros Mograine.
  /// </summary>
  public sealed class QuestAshbringer : QuestData
  {
    private const float DummyX = 22700;
    private const float DummyY = 23734;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestAshbringer"/> class.
    /// </summary>
    public QuestAshbringer() : base("The Ashbringer",
      "The Living Shadow must be purged, with enough Holy Magic and the craftiness of the Dwarves, it could be reforged into the strongest weapon of the Light",
      "ReplaceableTextures\\CommandButtons\\BTNAshbringer2blp")
    {
      AddObjective(new ObjectiveAcquireArtifact(ArtifactSetup.ArtifactLivingshadow));
      AddObjective(new ObjectiveLegendNotPermanentlyDead(LegendIronforge.LegendGreatforge));
      AddObjective(new ObjectiveArtifactInRect(ArtifactSetup.ArtifactLivingshadow, Regions.AshbringerForge,
        "The Great Forge"));
      AddObjective(new ObjectiveChannelRect(Regions.AshbringerForge, "The Great Forge", LegendLordaeron.Uther, 60,
        340));
      Global = true;
    }

    /// <inheritdoc/>
    protected override string CompletionPopup =>
      "The Ashbringer has been forged and Mograine has returned from exile to wield it";

    /// <inheritdoc/>
    protected override string RewardDescription => "Gain the hero Mograine and the artifact Ashbringer";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      LegendLordaeron.Mograine.ForceCreate(completingFaction.Player, Regions.AshbringerForge.Center, 270);
      SetHeroLevel(LegendLordaeron.Mograine.Unit, 10, false);
      LegendLordaeron.Mograine.Unit.AddItemSafe(ArtifactSetup.ArtifactAshbringer.Item);
      SetItemPosition(ArtifactSetup.ArtifactLivingshadow.Item, DummyX, DummyY);
      ArtifactSetup.ArtifactLivingshadow.LocationType = ArtifactLocationType.Ground;
      ArtifactSetup.ArtifactLivingshadow.LocationDescription = "Used to create the Ashbringer";
    }
  }
}