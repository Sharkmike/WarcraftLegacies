using AzerothWarsCSharp.MacroTools.Cheats;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Cinematics
{
  public class AllowCinematicSkip
  {
    public static void Setup()
    {
      TriggerSleepAction(0); //Just to make it load after GUI
      if (TestSafety.AreCheatsActive)
      {
        DisplayTextToPlayer(GetLocalPlayer(), 0, 0, "|cffD27575CHEAT:|r CinematicSkip enabled.");
      }
    }
  }
}