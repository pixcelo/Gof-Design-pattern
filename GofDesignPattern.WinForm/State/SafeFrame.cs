﻿using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GofDesignPattern.WinForm.State
{
    public partial class SafeFrame : Form, IContext
    {
        /// <summary>
        /// 現在の状態
        /// </summary>
        private IState state = DayState.GetInstance();

        public SafeFrame()
        {
            InitializeComponent();

            this.Initialize();
            this.Load += SafeFrame_Load;
        }

        private void Initialize()
        {
            this.buttonUse.Click += ((sender, e) => this.state.DoUse(this));
            this.buttonAlarm.Click += ((sender, e) => this.state.DoAlarm(this));
            this.buttonPhone.Click += ((sender, e) => this.state.DoPhone(this));
            this.buttonExit.Click += ((sender, e) => Application.Exit());
        }

        private void SafeFrame_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(async () =>
            {
                // 時間の経過をシミュレーション
                while (true)
                {
                    for (var hour = 0; hour < 24; hour++)
                    {
                        this.SetClock(hour);
                        await Task.Delay(1000); // 1秒待つ
                    }
                }
            }));
        }

        /// <summary>
        /// 時刻の設定
        /// </summary>
        /// <param name="hour"></param>
        public void SetClock(int hour)
        {
            var clockString = string.Format("現在時刻: {0:D2}:00", hour);
            Console.WriteLine(clockString);
            this.textClock.Text = clockString;
            this.state.DoClock(this, hour);
        }

        /// <summary>
        /// 状態変化
        /// </summary>
        /// <param name="state"></param>
        public void ChangeState(IState state)
        {
            Console.WriteLine($"{this.state}から{state}へ状態が変化しました。");
            this.state = state;
        }

        /// <summary>
        /// 警備センター警備員呼び出し
        /// </summary>
        /// <param name="msg"></param>
        public void CallSecurityCenter(string msg)
        {
            this.textScreen.Text += "call! " + msg + Environment.NewLine;
        }

        /// <summary>
        /// 警備センター記録
        /// </summary>
        /// <param name="msg"></param>
        public void RecordLog(string msg)
        {
            this.textScreen.Text += "record ... " + msg + Environment.NewLine;
        }
    }
}
