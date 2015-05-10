using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Kappa
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            ProcessStartInfo start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            // Enter the executable to run, including the complete path
            start.FileName = "lol.launcher.admin.exe";
            // Do you want to show a console window?
            int exitCode;

            Console.WriteLine("hallo1");
            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
            }
            Console.WriteLine("hallo2");
            string Pfad = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Executables (*.exe)|*.exe|All files (*.*)|*.*"
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                Pfad = openFileDialog1.FileName;

            if (string.IsNullOrEmpty(Pfad)) return;
            Process.Start(@Pfad);

        }
    }
}
