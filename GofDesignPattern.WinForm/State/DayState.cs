namespace GofDesignPattern.WinForm.State
{
    public class DayState : IState
    {
        private static readonly DayState Singleton = new DayState();

        private DayState()
        {
        }

        public static DayState GetInstance()
        {
            return Singleton;
        }

        public void DoClock(IContext context, int hour)
        {
            if (hour < 9 || 17 <= hour)
            {
                context.ChangeState(NightState.GetInstance());
            }
        }

        public void DoUse(IContext context)
        {
            context.RecordLog("Safe use during the day");
        }

        public void DoAlarm(IContext context)
        {
            context.CallSecurityCenter("Emergency bell (day)");
        }

        public void DoPhone(IContext context)
        {
            context.CallSecurityCenter("Normal call during the day");
        }

        public override string ToString()
        {
            return "[Day]";
        }
    }
}
