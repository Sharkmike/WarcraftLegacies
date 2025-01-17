using MacroTools.FactionSystem;
using WCSharp.Events;
using static War3Api.Common;

namespace WarcraftLegacies.Source.GameLogic
{
  /// <summary>
  /// Responsible for managing hero glow colours.
  /// </summary>
  public static class HeroGlowFix
  {
    /// <summary>
    /// Causes heroes trained to have their colours manually set to the colour indicated by their <see cref="Legend"/>
    /// class. This avoids a Warcraft 3 issue wherein revived heroes do not have their attachment colours updated to match their colour.
    /// </summary>
    public static void Setup()
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.HeroTypeFinishesRevive, () =>
      {
        var triggerUnit = GetTriggerUnit();
        var revivedLegend = Legend.GetFromUnit(triggerUnit);
        if (revivedLegend?.HasCustomColor == true)
        {
          SetUnitColor(triggerUnit, revivedLegend.PlayerColor);
        }
        else
        {
          SetUnitColor(triggerUnit, GetTriggerPlayer()?.GetFaction()?.PlayerColor ?? PLAYER_COLOR_COAL);
        }
      });
    }
  }
}