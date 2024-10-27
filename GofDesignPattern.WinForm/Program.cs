using GofDesignPattern.WinForm.Mediator;
using System;
using System.Windows.Forms;

namespace GofDesignPattern.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginFrame());
        }
    }
}
