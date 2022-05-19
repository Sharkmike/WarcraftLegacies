using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.MacroTools.Wrappers;
using AzerothWarsCSharp.Source.Quests.Scourge;
using AzerothWarsCSharp.Source.Setup.FactionSetup;

namespace AzerothWarsCSharp.Source.Setup.QuestSetup
{
  public static class ScourgeQuestSetup
  {
    public static void Setup()
    {
      QuestSpiderWar questSpiderWar = new(Regions.Ice_Crown,
        PreplacedUnitSystem.GetUnit(Constants.UNIT_N074_QUEEN_NEZAR_AZRET));
      QuestKelthuzad questKelthuzad = new();
      QuestDrakUnlock questDrakUnlock = new(Regions.DrakUnlock);
      QuestPlague questPlague = new(ForsakenSetup.FACTION_FORSAKEN,
        PreplacedUnitSystem.GetUnit(Constants.UNIT_N0AG_LORD_BAROV),
        new GroupWrapper().EnumUnitsOfType(Constants.UNIT_U01U_CULTIST_OF_THE_DAMNED_FORSAKEN).EmptyToList()
      )
      {
        ScholomanceInner = PreplacedUnitSystem.GetUnit(Constants.UNIT_N04B_SCHOLOMANCE_INNER),
        ScholomanceOuter = PreplacedUnitSystem.GetUnit(Constants.UNIT_N035_SCHOLOMANCE),
      };

      QuestSapphiron questSapphiron = new(PreplacedUnitSystem.GetUnit(Constants.UNIT_UBDR_SAPPHIRON_CREEP));
      QuestCorruptArthas questCorruptArthas = new();
      QuestNaxxramas questNaxxramas = new(Regions.NaxxramasInside,
        PreplacedUnitSystem.GetUnit(Constants.UNIT_E013_NAXXRAMAS_SCOURGE));
      QuestCivilWar questCivilWar = new();
      QuestLichKingArthas questLichKingArthas =
        new(PreplacedUnitSystem.GetUnit(Constants.UNIT_H00O_UTGARDE_KEEP_SCOURGE));

      questNaxxramas.AddQuestItem(new QuestItemCompleteQuest(questKelthuzad));

      //Setup
      ScourgeSetup.FactionScourge.AddQuest(questSpiderWar);
      ScourgeSetup.FactionScourge.StartingQuest = questSpiderWar;
      ScourgeSetup.FactionScourge.AddQuest(questDrakUnlock);
      ScourgeSetup.FactionScourge.AddQuest(questPlague);
      ScourgeSetup.FactionScourge.AddQuest(questSapphiron);
      //Early duel
      ScourgeSetup.FactionScourge.AddQuest(questCorruptArthas);
      ScourgeSetup.FactionScourge.AddQuest(questKelthuzad);
      ScourgeSetup.FactionScourge.AddQuest(questNaxxramas);
      ScourgeSetup.FactionScourge.AddQuest(questCivilWar);
      //Misc
      ScourgeSetup.FactionScourge.AddQuest(questLichKingArthas);
    }
  }
}