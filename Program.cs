using System;
using System.Windows.Forms;

namespace CSharp
{
    using Experiemnt = Experiemnt4;
    static class Program
    {
        //public static Experiemnt.Form1 form = new Experiemnt.Form1();
        //public static Experiemnt.Form2 form = new Experiemnt.Form2();
        public static Experiemnt.Form3 form = new Experiemnt.Form3();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form);
        }
    }
}
