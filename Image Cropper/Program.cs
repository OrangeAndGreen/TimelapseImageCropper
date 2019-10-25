using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Image_Cropper
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
            try
            {
                Application.Run(new Form1_V2());
            }
            catch(Exception e)
            {
                int catcher = 0;
            }
        }
    }
}
