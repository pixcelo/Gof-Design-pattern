namespace GofDesignPattern.WinForm.Mediator
{
    partial class LoginFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textUser = new GofDesignPattern.WinForm.Mediator.ColleagueTextField();
            this.textPass = new GofDesignPattern.WinForm.Mediator.ColleagueTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOk = new GofDesignPattern.WinForm.Mediator.ColleagueButton();
            this.buttonCancel = new GofDesignPattern.WinForm.Mediator.ColleagueButton();
            this.radioButtonGuest = new GofDesignPattern.WinForm.Mediator.ColleagueRadioButton();
            this.radioButtonLogin = new GofDesignPattern.WinForm.Mediator.ColleagueRadioButton();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(140, 55);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 19);
            this.textUser.TabIndex = 2;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(140, 81);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(100, 19);
            this.textPass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(60, 120);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(157, 120);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // radioButtonGuest
            // 
            this.radioButtonGuest.AutoSize = true;
            this.radioButtonGuest.Location = new System.Drawing.Point(72, 25);
            this.radioButtonGuest.Name = "radioButtonGuest";
            this.radioButtonGuest.Size = new System.Drawing.Size(53, 16);
            this.radioButtonGuest.TabIndex = 8;
            this.radioButtonGuest.TabStop = true;
            this.radioButtonGuest.Text = "Guest";
            this.radioButtonGuest.UseVisualStyleBackColor = true;
            // 
            // radioButtonLogin
            // 
            this.radioButtonLogin.AutoSize = true;
            this.radioButtonLogin.Location = new System.Drawing.Point(166, 25);
            this.radioButtonLogin.Name = "radioButtonLogin";
            this.radioButtonLogin.Size = new System.Drawing.Size(50, 16);
            this.radioButtonLogin.TabIndex = 9;
            this.radioButtonLogin.TabStop = true;
            this.radioButtonLogin.Text = "Login";
            this.radioButtonLogin.UseVisualStyleBackColor = true;
            // 
            // LoginFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 176);
            this.Controls.Add(this.radioButtonLogin);
            this.Controls.Add(this.radioButtonGuest);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Name = "LoginFrame";
            this.Text = "LoginFrame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ColleagueTextField textUser;
        private ColleagueTextField textPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ColleagueButton buttonOk;
        private ColleagueButton buttonCancel;
        private ColleagueRadioButton radioButtonGuest;
        private ColleagueRadioButton radioButtonLogin;
    }
}