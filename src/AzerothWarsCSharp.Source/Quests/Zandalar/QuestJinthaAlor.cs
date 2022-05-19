using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Setup.Legends;
using static War3Api.Common; 

namespace AzerothWarsCSharp.Source.Quests.Zandalar
{
  public sealed class QuestJinthaAlor : QuestData
  {
    private static readonly int JinthaalorResearch = FourCC("R02N");
    private static readonly int BearRiderId = FourCC("o02K");
    private static readonly int TrollShrineId = FourCC("o04X");
    
    protected override string CompletionPopup =>
      "Jintha'Alor has fallen. The Vilebranch trolls lend their might to the " + Holder.Team.Name + ".";

    protected override string RewardDescription =>
      "Control of Jintha'Alor, 300 gold tribute and the ability to train " + GetObjectName(BearRiderId) +
      "s from the " + GetObjectName(TrollShrineId);

    protected override void OnComplete()
    {
      SetPlayerTechResearched(Holder.Player, JinthaalorResearch, 1);
      this.Holder.Player.AdjustPlayerState(PLAYER_STATE_RESOURCE_GOLD, 300);
    }

    protected override void OnAdd()
    {
      Holder.ModObjectLimit(JinthaalorResearch, Faction.UNLIMITED);
    }


    public QuestJinthaAlor() : base("The Ancient Egg",
      "The Vilebranch trolls of Jintha'Alor are controlled by their fear of the Soulflayer's egg, hidden within their shrine. Smash it to gain their loyalty.",
      "ReplaceableTextures\\CommandButtons\\BTNForestTrollShadowPriest.blp")
    {
      AddQuestItem(new QuestItemControlLegend(LegendNeutral.LegendJinthaalor, false));
    }
  }
}