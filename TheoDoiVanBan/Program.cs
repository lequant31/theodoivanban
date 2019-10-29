using DevExpress.UserSkins;
using System;
using System.Windows.Forms;

namespace TheoDoiVanBan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            #region login
            var _login = new Login();
            _login.ShowDialog();
            if (_login.DialogResult != DialogResult.OK)
            {
                return;
            }
            #endregion
            Application.Run(new Main());
        }
    }
}
