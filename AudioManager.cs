using System;
using System.Collections.Generic;

namespace Tetris
{
    internal class AudioManager
    {
        public static AudioManager Instance => instance ??= new AudioManager();
        private static AudioManager instance;
        private const string dirPath = "Assets/AudioClip";
        private AudioPlayer musicPlayer = new("music");
        private AudioPlayer soundPlayer = new("sound");

        public void PlayBackground()
        {
            musicPlayer.Play(dirPath + "/main_music.mp3", true);
        }

        public void PlayStop()
        {
            soundPlayer.Play(dirPath + "/end_game.wav");
        }

        public void PlayButtonClick()
        {
            soundPlayer.Play(dirPath + "/button.wav");
        }

        public void PlayBrickMove()
        {
            soundPlayer.Play(dirPath + "/move.wav");
        }

        public void PlayBrickRotate()
        {
            soundPlayer.Play(dirPath + "/rotate.wav");
        }

        public void PlayBrickStop()
        {
            soundPlayer.Play(dirPath + "/brick_stop.wav");
        }

        public void PlayClearRow()
        {
            soundPlayer.Play(dirPath + "/clear_row.wav");
        }
    }
}