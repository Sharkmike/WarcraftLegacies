using MacroTools;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WCSharp.Events;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Researches.Stormwind
{
  public static class TierKnowledgeOfHonorHold
  {
    private const int UnittypePortal = Constants.UNIT_N09P_PORTAL_STORMWIND;
    private const float WaygateOffset = 100;
    private static destructable? DestructableA;
    private static destructable? DestructableB;

    private static void EnablePortals()
    {
      var waygateA = CreateUnit(StormwindSetup.Stormwind.Player, UnittypePortal, DestructableA.GetPosition().X,
        DestructableA.GetPosition().Y, 0);
      
      var waygateB = CreateUnit(StormwindSetup.Stormwind.Player, UnittypePortal, DestructableB.GetPosition().X,
        DestructableB.GetPosition().Y, 130.80f);

      SetUnitPathing(waygateA, false);
      SetUnitPathing(waygateB, false);

      var polarOffsetA = WCSharp.Shared.Util.PositionWithPolarOffset(GetUnitX(waygateB), GetUnitY(waygateB),
        WaygateOffset, GetUnitFacing(waygateB));
      waygateA.SetWaygateDestination(new Point(polarOffsetA.x, polarOffsetA.y));

      var polarOffsetB = WCSharp.Shared.Util.PositionWithPolarOffset(GetUnitX(waygateA), GetUnitY(waygateA),
        WaygateOffset, GetUnitFacing(waygateA));
      waygateB.SetWaygateDestination(new Point(polarOffsetB.x, polarOffsetB.y));
      WaygateSetDestination(waygateA, polarOffsetB.x, polarOffsetB.y);

      QueueUnitAnimation(waygateA, "birth");
      QueueUnitAnimation(waygateB, "birth");
      QueueUnitAnimation(waygateA, "stand");
      QueueUnitAnimation(waygateB, "stand");
    }

    private static void Research()
    {
      StormwindSetup.Stormwind?.ModObjectLimit(Constants.UPGRADE_R03X_CONJURERS_ARATHOR_T3, Faction.UNLIMITED);
      StormwindSetup.Stormwind?.ModObjectLimit(Constants.UPGRADE_R03Y_KATRANA_PRESTOR_AID_ARATHOR_T3, Faction.UNLIMITED);
      EnablePortals();
    }

    public static void Setup(PreplacedUnitSystem preplacedUnitSystem)
    {
      DestructableA = preplacedUnitSystem.GetDestructable(FourCC("B017"), new Point(8229, -11703));
      DestructableB = preplacedUnitSystem.GetDestructable(FourCC("B017"), Regions.HonorHold.Center);
      PlayerUnitEvents.Register(PlayerUnitEvent.ResearchIsFinished, Research,
        Constants.UPGRADE_R03W_KNOWLEDGE_OF_HONOR_HOLD_ARATHOR_T2);
    }
  }
}