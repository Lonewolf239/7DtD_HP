using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace _7DtD_HP
{
    internal static class Program
    {
        internal const string ECFile = @"Data\Config\entityclasses.xml";
        internal const string BECFile = "backup-entityclasses.xml";

        [STAThread]
        internal static void Main()
        {
            Mutex mutex = new Mutex(true, "7DtD_Unique_Mutex");
            if (!mutex.WaitOne(TimeSpan.Zero, true)) return;
            if (!Directory.GetCurrentDirectory().EndsWith("7 Days To Die") || !Directory.Exists("Data\\Config"))
            {
                MessageBox.Show("Invalid launch location. The application must be located in the \"7 Days To Die\" game folder. Please move 7DtD_HP.exe to the correct folder and try again.",
                                "Invalid Launch Location",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(ECFile))
            {
                MessageBox.Show("The required configuration file is missing! Please verify your game files through Steam to resolve the issue.",
                                "Configuration File Missing",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(BECFile)) File.Copy(ECFile, BECFile);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            mutex.ReleaseMutex();
        }
    }
}