using System;
using System.Windows.Forms;

namespace GofDesignPattern.WinForm.Mediator
{
    public class ColleagueRadioButton : RadioButton, IColleague
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

        protected override void OnCheckedChanged(EventArgs e)
        {
            // チェック状態が変化したらMediatorに通知する
            mediator?.ColleagueChanged();
            base.OnCheckedChanged(e);
        }
    }
}
