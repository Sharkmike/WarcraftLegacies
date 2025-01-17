﻿using System.Collections.Generic;
using MacroTools.ControlPointSystem;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.QuestSystem;
using MacroTools.QuestSystem.UtilityStructs;
using WarcraftLegacies.Source.Setup.Legends;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Dragonmaw
{
  public sealed class QuestDragonmawPort : QuestData
  {
    private readonly List<unit> _rescueUnits = new();

    public QuestDragonmawPort(Rectangle rescueRect, unit waygateDragonmawPort) : base("Dragonmaw Port",
      "The Dragonmaw Port will be the site of the portal summoning to escape to kalimdor! The Tyrant Mor'ghor and his followers have taken control of the Port, kill him to reunite the clan. ",
      "ReplaceableTextures\\CommandButtons\\BTNIronHordeSummoningCircle.blp")
    {
      AddObjective(
        new ObjectiveControlPoint(ControlPointManager.GetFromUnitType(Constants.UNIT_N08T_DRAGONMAW_PORT_10GOLD_MIN)));
      AddObjective(new ObjectiveLegendDead(LegendNeutral.Morghor));
      AddObjective(new ObjectiveControlLegend(LegendDragonmaw.Zaela, false));
      AddObjective(new ObjectiveExpire(480));
      AddObjective(new ObjectiveSelfExists());

      _rescueUnits = rescueRect.PrepareUnitsForRescue(RescuePreparationMode.Invulnerable);
      _rescueUnits.Remove(waygateDragonmawPort);
      Required = true;
    }

    //Todo: bad flavour
    /// <inheritdoc />
    protected override string CompletionPopup =>
      "Dragonmaw Port has fallen under our control.";

    /// <inheritdoc />
    protected override string RewardDescription => "Control of all buildings in Dragonmaw Port";

    /// <inheritdoc />
    protected override void OnFail(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    /// <inheritdoc />
    protected override void OnComplete(Faction completingFaction)
    {
      PlayThematicMusic("war3mapImported\\DragonmawTheme.mp3");
      completingFaction.Player?.RescueGroup(_rescueUnits);
    }
  }
}