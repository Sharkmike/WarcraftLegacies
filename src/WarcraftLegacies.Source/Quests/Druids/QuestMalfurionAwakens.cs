using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WarcraftLegacies.Source.Setup;
using WarcraftLegacies.Source.Setup.Legends;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Druids
{
  /// <summary>
  /// The Druids acquire Malfurion, Moonglade and the World Tree.
  /// </summary>
  public sealed class QuestMalfurionAwakens : QuestData
  {
    private readonly unit _worldTree;
    private readonly List<unit> _moongladeUnits;

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestMalfurionAwakens"/> class.
    /// </summary>
    /// <param name="moonglade">All units here start invulnerable and are rescued when the quest is completed.</param>
    /// <param name="worldTree">Starts invulnerable and is recued when the quest is completed.</param>
    public QuestMalfurionAwakens(Rectangle moonglade, unit worldTree) : base("Awakening of Stormrage",
      "Ever since the War of the Ancients ten thousand years ago, Malfurion Stormrage and his druids have slumbered within the Barrow Den. Now, their help is required once again.",
      "ReplaceableTextures\\CommandButtons\\BTNFurion.blp")
    {
      _worldTree = worldTree;
      AddObjective(new ObjectiveAcquireArtifact(ArtifactSetup.ArtifactHornofcenarius));
      AddObjective(new ObjectiveArtifactInRect(ArtifactSetup.ArtifactHornofcenarius, Regions.Moonglade,
        "The Barrow Den"));
      AddObjective(new ObjectiveExpire(1440));
      AddObjective(new ObjectiveSelfExists());
      _moongladeUnits = moonglade.PrepareUnitsForRescue(RescuePreparationMode.HideNonStructures);
      worldTree.SetInvulnerable(true);
      Required = true;
    }

    /// <inheritdoc />
    protected override string CompletionPopup => "Malfurion has emerged from his deep slumber in the Barrow Den.";

    /// <inheritdoc />
    protected override string RewardDescription => "Gain Nordrassil, the hero Malfurion, and the artifact G'hanir";

    /// <inheritdoc />
    protected override void OnFail(Faction completingFaction)
    {
      Player(PLAYER_NEUTRAL_AGGRESSIVE).RescueGroup(_moongladeUnits);
      _worldTree.Rescue(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    /// <inheritdoc />
    protected override void OnComplete(Faction completingFaction)
    {
      completingFaction.Player?.RescueGroup(_moongladeUnits);
      _worldTree.Rescue(completingFaction.Player);
      if (LegendDruids.LegendMalfurion.Unit == null)
      {
        LegendDruids.LegendMalfurion.ForceCreate(completingFaction.Player, Regions.Moonglade.Center,
          270);
        SetHeroLevel(LegendDruids.LegendMalfurion.Unit, 3, false);
        LegendDruids.LegendMalfurion.Unit?.AddItemSafe(ArtifactSetup.ArtifactGhanir.Item);
      }
      else
      {
        ArtifactSetup.ArtifactGhanir?.Item.SetPositionSafe(GetTriggerUnit().GetPosition());
      }
    }
  }
}