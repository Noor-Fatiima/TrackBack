using System;
using System.Windows.Forms;
using TrackBack.Database;
using TrackBack.Forms;  //forms folder import

namespace TrackBack
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // for modern look of buttons,textboxes
            Application.SetCompatibleTextRenderingDefault(false); //false=modern , true=old GDI

            DBConnection.SeedAdminIfNotExists();

            Application.Run(new frmLogin());
        }
    }
}