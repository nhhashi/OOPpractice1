using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer1
{
    class FileController
    {
        private static FileController fileController = new FileController();

        private List<string> list = new List<string>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private FileController()
        {
        }

        public static FileController getInstance()
        {
            return fileController;
        }

        /// <summary>
        /// 音楽ファイルパスの取得関数
        /// </summary>
        /// <returns>パス</returns>
        public string[] readMusicFile()
        {
            string relativePathName = System.IO.Path.GetFullPath("..\\..\\music");

            ///musicフォルダ内の音楽ファイルを全て取得する
            string[] filePathes = Directory.GetFiles(relativePathName);

            return filePathes;
        }
    }
}
