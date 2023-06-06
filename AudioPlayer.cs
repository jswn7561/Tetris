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
            //Log2();
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

        public void Log()
        {
            string durLength = "";
            durLength = durLength.PadLeft(128, Convert.ToChar(" "));
            int RefInt = mciSendString("status " + alias + " volume", null, durLength.Length, 0);
            durLength = durLength.Trim();
            Console.WriteLine($"len: {durLength.Length}, content: {durLength}");
        }

        public void Log2()
        {
            int iVolume = 50;
            int left = iVolume;
            int right = left;
            int volume = (left << 8) | right;
            waveOutSetVolume(0, 0x0000);
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendString", CharSet = CharSet.Auto)]
        private static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        [DllImport("winmm.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        public static extern int waveOutSetVolume(int uDeviceID, int dwVolume);

    }
}
