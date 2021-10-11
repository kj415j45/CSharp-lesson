using System;
using System.Windows.Forms;

namespace CSharp
{
    static class Program
    {
        //实验3-1
        //public static Form1 form = new Form1();

        //实验3-2
        //public static Form2 form = new Form2();

        //实验3-3
        public static Form3 form = new Form3();

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
