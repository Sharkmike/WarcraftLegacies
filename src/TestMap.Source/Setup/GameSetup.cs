﻿using MacroTools;
using MacroTools.AchievementSystem;
using MacroTools.Frames.Books.AchievementSystem;
using MacroTools.Frames.Books.ArtifactSystem;
using MacroTools.Frames.Books.Powers;
using MacroTools.Mechanics;
using MacroTools.PassiveAbilitySystem;
using MacroTools.UserInterface;
using static War3Api.Common;

namespace TestMap.Source.Setup
{
  public static class GameSetup
  {
    public static void Setup()
    {
      var hars = CreateUnit(Player(0), FourCC("hars"), 0, 0, 0);
      SetPlayerState(Player(0), PLAYER_STATE_RESOURCE_FOOD_CAP, 100);

      PreplacedUnitSystem.Initialize();
      LegendSetup.Setup();
      //ShoreSetup.Setup();
      //InstanceSetup.Setup();
      TeamSetup.Setup();
      AllFactionSetup.Setup();
      PlayerSetup.Setup();
      ArtifactSetup.Setup();
      ControlPointSetup.Setup();
      AllQuestSetup.Setup();
      //ResearchSetup.Setup();
      //ObserverSetup.Setup();
      SpellSetup.Setup();
      CheatSetup.Setup();
      //CommandSetup.Setup();
      //ControlPointVictory.Setup();
      //IncompatibleTierConfig.Setup();
      FactionMultiboard.Setup();
      PowerBook.Initialize();
      ArtifactBook.Initialize();
      AchievementManager.Setup();
      AchievementBook.Initialize();
      TestSetup.Setup();
      WaygateManager.Setup(FourCC("nwgt"));
      HintSetup.Setup();
      PreplacedUnitSystem.Shutdown();
      DialogueSetup.Setup();
      AugmentSetup.Setup();
      PassiveAbilityManager.InitializePreplacedUnits();
      LegendSetup.Kael.AddProtector(hars);
    }
  }
}