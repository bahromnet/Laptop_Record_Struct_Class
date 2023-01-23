using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace LaptopRCS
{
    internal static class Music
    {
        public static void playMusic(string filePath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filePath;
            musicPlayer.Play();
        }
    }
}
