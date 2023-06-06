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
    internal class Music
    {

        // 创建SoundPlayer对象
        public SoundPlayer player = new SoundPlayer();

        // 背景音效
        public void Background()
        { 
            player.SoundLocation = "Assets/AudioClip/main_music.wav";
            player.Play();

        }
        // 结束音效
        public void Stop()
        {
            player.SoundLocation = "Assets/AudioClip/end_game.wav";
            player.Play();
            player.Dispose();
        }

        //落到底部音效  
        public void Hold()
        {
            player.SoundLocation = "Assets/AudioClip/hold.wav";
            player.PlaySync(); //UI同步
            player.SoundLocation = "Assets/AudioClip/main_music.wav";
            player.Play();     //异步
 
         }
        //消行音效
        public void Clear()
        {
            player.SoundLocation = "Assets/AudioClip/clear_row.wav";
            player.PlaySync(); //UI同步
            player.SoundLocation = "Assets/AudioClip/main_music.wav";
            player.Play();     //异步

        }

    }
}