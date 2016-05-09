using System;
using System.Windows.Forms;

namespace B16_Ex01_Sapir_201028867_Bar_200959286
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
           
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm facebookFeaturesForm = new MainForm();
            if (facebookFeaturesForm.LoggedIn)
            {
                Application.Run(facebookFeaturesForm);
            }
        }
    }
}
