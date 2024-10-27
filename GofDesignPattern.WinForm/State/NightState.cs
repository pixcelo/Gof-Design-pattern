namespace GofDesignPattern.WinForm.State
{
    public class NightState : IState
    {
        private static readonly NightState Singleton = new NightState();

        private NightState()
        {
        }

        public static NightState GetInstance()
        {
            return Singleton;
        }

        public void DoClock(IContext context, int hour)
        {
            if (9 <= hour && hour < 17)
            {
                context.ChangeState(DayState.GetInstance());
            }
        }

        public void DoUse(IContext context)
        {
            context.CallSecurityCenter("Emergency: Safe use at night!");
        }

        public void DoAlarm(IContext context)
        {
            context.CallSecurityCenter("Emergency bell (night)");
        }

        public void DoPhone(IContext context)
        {
            context.RecordLog("Recording call at night");
        }

        public override string ToString()
        {
            return "[Night]";
        }
    }
}
