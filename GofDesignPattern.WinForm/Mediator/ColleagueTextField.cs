using System;
using System.Drawing;
using System.Windows.Forms;

namespace GofDesignPattern.WinForm.Mediator
{
    public class ColleagueTextField : TextBox, IColleague
    {
        private IMediator mediator;

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetColleagueEnabled(bool enabled)
        {
            this.Enabled = enabled;
            // 有効無効に応じて背景色を変更する
            this.BackColor = enabled ? Color.White : Color.LightGray;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            // 文字列が変化したらMediatorに通知する
            mediator?.ColleagueChanged();
            base.OnTextChanged(e);
        }
    }
}
