using AzerothWarsCSharp.MacroTools.ControlPointSystem;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Setup.FactionSetup;
using AzerothWarsCSharp.Source.Setup.Legends;
using static War3Api.Common;


namespace AzerothWarsCSharp.Source.Quests.Fel_Horde
{
  public sealed class QuestKillDraenei : QuestData
  {
    public QuestKillDraenei() : base("The Shattrah Massacre",
      "The Draenei race existence insults the Fel Horde demon masters, slaughter them all ",
      "ReplaceableTextures\\CommandButtons\\BTNChaosWolfRider.blp")
    {
      AddQuestItem(new QuestItemControlPoint(ControlPointManager.GetFromUnitType(FourCC("n09X"))));
      AddQuestItem(new QuestItemLegendDead(LegendDraenei.LegendExodarship));
      AddQuestItem(new QuestItemSelfExists());
    }

    protected override string CompletionPopup =>
      "The Draenei have been eliminated from Outland and their gold mine is ours.";

    protected override string RewardDescription =>
      "The Draenei rich gold mine in Tempest Keep, the faster we destroy them, the more gold will be left";

    protected override void OnComplete()
    {
      group tempGroup = CreateGroup();

      Holder.Player.AdjustPlayerState(PLAYER_STATE_RESOURCE_GOLD, 500);
      Holder.Player.AdjustPlayerState(PLAYER_STATE_RESOURCE_LUMBER, 500);

      GroupEnumUnitsInRect(tempGroup, Regions.InstanceOutland.Rect, null);
      unit u = FirstOfGroup(tempGroup);
      while (true)
      {
        if (u == null) break;
        if (GetOwningPlayer(u) == DraeneiSetup.Draenei.Player)
          if (IsUnitType(u, UNIT_TYPE_STRUCTURE) && !IsUnitType(u, UNIT_TYPE_ANCIENT))
            KillUnit(u);
        GroupRemoveUnit(tempGroup, u);
        u = FirstOfGroup(tempGroup);
      }

      DestroyGroup(tempGroup);
    }
  }
}