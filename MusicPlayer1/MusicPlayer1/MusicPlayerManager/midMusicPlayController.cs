﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer1.MusicPlayerManager
{
    class midMusicPlayController : MusicPlayController
    {
        private string musicPath = string.Empty;

        ///音楽プレイヤーインスタンス
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private static double mediaCurrentPos = 0;

        public void Pause()
        {
            MessageBox.Show("mid：一時停止します。曲名：" + this.musicPath);

            ///再生中メディアの現在位置を取得する
            mediaCurrentPos = player.controls.currentPosition;
        }

        public TimeSpan Play()
        {
            MessageBox.Show("mid：再生します。曲名：" + this.musicPath);

            player.URL = this.musicPath;
            player.controls.currentPosition = mediaCurrentPos;
            player.controls.play();

            return TimeSpan.Zero;
        }

        public void setMusicPath(string musicPath)
        {

            this.musicPath = musicPath;
        }

        public void Stop()
        {
            MessageBox.Show("mid：停止します。曲名：" + this.musicPath);

            ///音楽の停止を実施する
            mediaCurrentPos = 0;
            player.controls.stop();
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
