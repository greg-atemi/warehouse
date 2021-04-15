using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        // defines for commandline output
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        private const int ATTACH_PARENT_PROCESS = -1;

        [STAThread]
        static void Main(string[] args)
        {
            AttachConsole(ATTACH_PARENT_PROCESS);

            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Good_record_form());


            // var nw = new Cube("Cube1", false);
            // nw.Save();

            // var nw = new Good("TV", "Electronic", DateTime.Now.Date, DateTime.Now.Date, "mchemweno27@gmail.com", 2);
            // nw.Save();

            // Console.WriteLine(DateTime.Now.Ticks);
        }
    }
}