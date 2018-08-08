using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Media;
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
