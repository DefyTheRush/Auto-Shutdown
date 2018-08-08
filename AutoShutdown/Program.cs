using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace AutoShutdown
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "Automatic Shutdown";
            bool createdNew;

            Mutex mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("You cannot have more than one instance of this program running", "Already running");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool soundIsPlayed;

            void playShutdownSound()
            {
                SoundPlayer shutdownSound = new SoundPlayer(AutoShutdown.Properties.Resources.shutdown_sound);
                shutdownSound.Play();
                soundIsPlayed = true;
            }

            playShutdownSound();

            if (soundIsPlayed)
            {
                Application.Run(new frmAutoShutdown());
            }
        }
    }
}
