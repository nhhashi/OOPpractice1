﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace MusicPlayer1.MusicPlayerManager
{
    class aifMusicPlayController : MusicPlayController
    {
        private string musicPath = string.Empty;

        private SoundPlayer player;

        public void Pause()
        {
            MessageBox.Show("aif：一時停止します。曲名：" + this.musicPath);
        }

        public TimeSpan Play()
        {
            MessageBox.Show("aif：再生します。曲名：" + this.musicPath);

            ///再生する
            player = new SoundPlayer(this.musicPath);
            player.Play();

            return TimeSpan.Zero;
        }

        public void setMusicPath(string musicPath)
        {
            this.musicPath = musicPath;
        }

        public void Stop()
        {
            MessageBox.Show("aif：停止します。曲名：" + this.musicPath);

            player.Stop();
        }

        [STAThread]
        public TimeSpan GetMoviePlaybackTime(string filename)
        {
            Type shellAppType = Type.GetTypeFromProgID("Shell.Application");
            dynamic shell = Activator.CreateInstance(shellAppType);
            Shell32.Folder objFolder = shell.NameSpace(Path.GetDirectoryName(filename));
            Shell32.FolderItem folderItem = objFolder.ParseName(Path.GetFileName(filename));
            string strDuration = objFolder.GetDetailsOf(folderItem, 27);

            // TimeSpanに変換
            TimeSpan ts = TimeSpan.Parse(strDuration);
            return ts;
        }
    }
}
