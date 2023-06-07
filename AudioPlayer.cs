using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class AudioPlayer
    {
        private string alias;

        public AudioPlayer(string alias)
        {
            this.alias = alias;
        }

        public void Play(string filePath, bool loop = false)
        {
            Close();
            mciSendString("open " + filePath + " alias " + alias, null, 0, 0);
            mciSendString("play " + alias + (loop ? " repeat" : string.Empty), null, 0, 0);
        }

        public void Pause()
        {
            mciSendString("pause " + alias, null, 0, 0);
        }

        public void Resume()
        {
            mciSendString("resume " + alias, null, 0, 0);
        }

        public void Close()
        {
            mciSendString("close " + alias, null, 0, 0);
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendString", CharSet = CharSet.Auto)]
        private static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);
    }
}
