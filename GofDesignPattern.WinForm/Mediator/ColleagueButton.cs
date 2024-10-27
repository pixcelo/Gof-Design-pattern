using System.Windows.Forms;

namespace GofDesignPattern.WinForm.Mediator
{
    public class ColleagueButton : Button, IColleague
    {
        private IMediator mediator;

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
        }
    }
}
