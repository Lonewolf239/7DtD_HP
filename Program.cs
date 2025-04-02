using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace _7DtD_HP
{
    internal static class Program
    {
        [STAThread]
        internal static void Main()
        {
            Mutex mutex = new Mutex(true, "7DtD_Unique_Mutex");
            if (!mutex.WaitOne(TimeSpan.Zero, true)) return;
            if (!File.Exists("entityclasses.xml"))
            {
                MessageBox.Show("The file \"entityclasses.xml\" is missing! Please copy this file from the game folder (7 Days To Die\\Data\\Config) to the same folder as 7DtD_HP.exe",
                    "The file \"entityclasses.xml\" is missing!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            mutex.ReleaseMutex();
        }
    }
}