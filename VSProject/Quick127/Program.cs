using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Quick127
{
    static class Program
    {
        // Forces GC to keep mtx alive
        //static Mutex mtx = new Mutex(true, "Quick127");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                MessageBox.Show("Quick127: No path given, use me correctly!");
                return;
            }

            String path = args[0].ToString();
            String file = args[1].ToString();
            String url = file.Replace(path,"http:\\\\127.0.0.1");

            //String msg = "Quick127 message:\n path = " + path + "\n" + "file = " + file + "\n" + "url = " + url + "\n";
            //MessageBox.Show(msg);
            Process.Start("chrome.exe", url);


            /*
            if (!mtx.WaitOne(1,false))
            {
                MessageBox.Show("Another instance is already running.");
                return;
            }



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1(args));
            */
        }
    }
}
