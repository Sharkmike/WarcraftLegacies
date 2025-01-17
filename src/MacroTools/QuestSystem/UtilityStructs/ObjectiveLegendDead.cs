using MacroTools.FactionSystem;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace MacroTools.QuestSystem.UtilityStructs
{
  public class ObjectiveLegendDead : Objective
  {
    private readonly Legend _target;

    public ObjectiveLegendDead(Legend target)
    {
      _target = target;
      TargetWidget = target.Unit;
      if (IsUnitType(target.Unit, UNIT_TYPE_STRUCTURE))
        Description = target.Name + " is destroyed";
      else
        Description = target.Name + " is dead";

      DisplaysPosition = IsUnitType(_target.Unit, UNIT_TYPE_STRUCTURE) ||
                         GetOwningPlayer(_target.Unit) == Player(PLAYER_NEUTRAL_AGGRESSIVE);

      target.PermanentlyDied += OnDeath;
    }

    public override Point Position => new(GetUnitX(_target.Unit), GetUnitY(_target.Unit));

    private void OnDeath(object? sender, Legend legend)
    {
      Progress = QuestProgress.Complete;
    }
  }
}