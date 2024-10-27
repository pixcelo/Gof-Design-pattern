using System.Windows.Forms;

namespace GofDesignPattern.WinForm.Mediator
{
    public partial class LoginFrame : Form, IMediator
    {
        public LoginFrame()
        {
            InitializeComponent();

            this.CreateColleagues();
        }

        public void CreateColleagues()
        {
            // Mediatorのセット
            this.radioButtonGuest.SetMediator(this);
            this.radioButtonLogin.SetMediator(this);
            this.textUser.SetMediator(this);
            this.textPass.SetMediator(this);
            this.buttonOk.SetMediator(this);
            this.buttonCancel.SetMediator(this);
        }

        public void ColleagueChanged()
        {
            if (this.textUser.Text.Length > 0)
            {
                this.textPass.SetColleagueEnabled(true);
                if (this.textPass.Text.Length > 0)
                {
                    this.buttonOk.SetColleagueEnabled(true);
                }
                else
                {
                    this.buttonOk.SetColleagueEnabled(false);
                }
            }
            else
            {
                this.textPass.SetColleagueEnabled(false);
                this.buttonOk.SetColleagueEnabled(false);
            }
        }
    }
}
