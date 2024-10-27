namespace GofDesignPattern.WinForm.State
{
    partial class SafeFrame
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
            this.buttonUse = new System.Windows.Forms.Button();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.buttonPhone = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textClock = new System.Windows.Forms.Label();
            this.textScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonUse
            // 
            this.buttonUse.Location = new System.Drawing.Point(25, 185);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(75, 23);
            this.buttonUse.TabIndex = 0;
            this.buttonUse.Text = "金庫使用";
            this.buttonUse.UseVisualStyleBackColor = true;
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.Location = new System.Drawing.Point(114, 185);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(75, 23);
            this.buttonAlarm.TabIndex = 1;
            this.buttonAlarm.Text = "非常ベル";
            this.buttonAlarm.UseVisualStyleBackColor = true;
            // 
            // buttonPhone
            // 
            this.buttonPhone.Location = new System.Drawing.Point(205, 185);
            this.buttonPhone.Name = "buttonPhone";
            this.buttonPhone.Size = new System.Drawing.Size(75, 23);
            this.buttonPhone.TabIndex = 2;
            this.buttonPhone.Text = "通常通話";
            this.buttonPhone.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(294, 185);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "終了";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // textClock
            // 
            this.textClock.AutoSize = true;
            this.textClock.Location = new System.Drawing.Point(13, 13);
            this.textClock.Name = "textClock";
            this.textClock.Size = new System.Drawing.Size(55, 12);
            this.textClock.TabIndex = 4;
            this.textClock.Text = "現在時刻:";
            // 
            // textScreen
            // 
            this.textScreen.Location = new System.Drawing.Point(25, 37);
            this.textScreen.Multiline = true;
            this.textScreen.Name = "textScreen";
            this.textScreen.Size = new System.Drawing.Size(344, 131);
            this.textScreen.TabIndex = 5;
            // 
            // SafeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.textScreen);
            this.Controls.Add(this.textClock);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPhone);
            this.Controls.Add(this.buttonAlarm);
            this.Controls.Add(this.buttonUse);
            this.Name = "SafeFrame";
            this.Text = "SafeFrame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Button buttonPhone;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label textClock;
        private System.Windows.Forms.TextBox textScreen;
    }
}