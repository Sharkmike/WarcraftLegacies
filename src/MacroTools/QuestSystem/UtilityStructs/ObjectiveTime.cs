using static War3Api.Common;

namespace MacroTools.QuestSystem.UtilityStructs
{
  public class ObjectiveTime : Objective
  {
    private readonly timer _timer;

    private void OnExpire()
    {
      DestroyTimer(_timer);
      Progress = QuestProgress.Complete;
    }

    public ObjectiveTime(int duration)
    {
      Description = $"{duration} seconds have elapsed";
      _timer = CreateTimer();
      TimerStart(_timer, duration, false, OnExpire);
    }
  }
}