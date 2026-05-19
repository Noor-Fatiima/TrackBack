using System;
using System.Windows.Forms;
using TrackBack.Database;
using TrackBack.Forms;

namespace TrackBack
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBConnection.SeedAdminIfNotExists();

            Application.Run(new frmLogin());
        }
    }
}