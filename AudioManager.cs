using System;
using System.Collections.Generic;
using System.Media;
using System.Resources;
using System.Text;
using System.Text.Unicode;
using Newtonsoft.Json;
using Tetris.Properties;


namespace Tetris
{
    internal class AudioManager
    {
        public static AudioManager Instance => instance ??= new AudioManager();
        private static AudioManager instance;
        private const string dirPath = "Assets/AudioClip";
        private AudioPlayer musicPlayer = new AudioPlayer("music");
        private AudioPlayer soundPlayer = new AudioPlayer("sound");

        // 背景音效
        public void PlayBackground()
        {
            musicPlayer.Play(dirPath + "/main_music.wav");

        }

        // 结束音效
        public void PlayStop()
        {
            //player.SoundLocation = "Assets/AudioClip/end_game.wav";
            //player.Play();
            //player.Dispose();
        }

        //落到底部音效  
        public void Hold()
        {
            soundPlayer.Play(dirPath + "/hold.wav");
         }

        //消行音效
        public void Clear()
        {
            //player.SoundLocation = "Assets/AudioClip/clear_row.wav";
            //player.PlaySync(); //UI同步
            //player.SoundLocation = "Assets/AudioClip/main_music.wav";
            //player.Play();     //异步

        }

    }
}