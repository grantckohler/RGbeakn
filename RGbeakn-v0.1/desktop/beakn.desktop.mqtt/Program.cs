using System;
using System.Windows.Forms;

namespace beakn.desktop.mqtt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                var c = new Controller();
                c.Setup();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            #region Windows Forms Init
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BeaknForm());
            #endregion
        }
    }
}
