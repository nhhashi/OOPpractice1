using MusicPlayer1.MusicPlayerManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// MusicPlayerインスタンスの変数
        /// </summary>
        MusicPlayer _MusicPlayer;

        /// <summary>
        /// 音楽パス
        /// </summary>
        string[] pathes;

        /// <summary>
        /// 
        /// </summary>
        string selectedFilePath = string.Empty;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            ///インスタンスの生成をする
            _MusicPlayer = new MusicPlayer();

            ///Fromの初期化をする
            Init();
        }

        /// <summary>
        /// 初期化関数
        /// </summary>
        private void Init()
        {
            ///音楽パスを取得する
            pathes = FileController.getInstance().readMusicFile();

            ///データグリッドの初期処理をする
            adjustRowWidth();
            displayFileNameOnDataGrid();
            this.FileNameGridView.Click += new EventHandler(dataGrid_Click);

            ///ボタンの初期処理をする
            this.PlayButton.Text = "▶";
            this.previousButton.Text = "◀◀";
            this.NextButton.Text = "▶▶";
            this.PlayButton.Click += new EventHandler(playButton_Click);
            this.previousButton.Click += new EventHandler(previousButton_Click);
            this.NextButton.Click += new EventHandler(nextButton_Click);

            ///曲名表示ラベルの初期処理をする
            this.SelectedFileNameLabel.Text = "選曲してください";
        }

        /// <summary>
        /// 
        /// </summary>
        private void selectExtendState()
        {
            ///拡張子の取得をする
            ///ファイル名にドットが記述されていた場合はどうするのか？
            string[] val = this.selectedFilePath.Split('.');
            string extend = val[1];

            switch (extend)
            {
                case "aif":

                    _MusicPlayer.changeMusicPlayState(new aifMusicPlayController());
                    break;

                case "mid":

                    _MusicPlayer.changeMusicPlayState(new midMusicPlayController());
                    break;

                case "mp3":

                    _MusicPlayer.changeMusicPlayState(new mp3MusicPlayController());
                    break;

                case "wav":

                    _MusicPlayer.changeMusicPlayState(new wavMusicPlayController());
                    break;

                default:
                    break;
            }

            ///再生パスの設定をする
            _MusicPlayer.setMusicPath(this.selectedFilePath);
        }

        /// <summary>
        /// 選択曲文字関数
        /// </summary>
        private string checkIncludingString(string selectFileName)
        {
            foreach (string str in pathes)
            {
                if (str.Contains(selectFileName))
                {
                    return str;
                }
            }

            return "";
        }

        /// <summary>
        /// データグリッド追加関数
        /// </summary>
        private void displayFileNameOnDataGrid()
        {
            ///パスから曲名を抽出する
            ///データグリッドに追加する
            foreach (string str in pathes)
            {
                string[] splitStr = str.Split('\\');
                string[] fileName = splitStr[pathes.Length - 1].Split('.');
                this.FileNameGridView.Rows.Add(fileName[0]);
            }
        }

        /// <summary>
        /// データグリッドの列の幅調整関数
        /// </summary>
        private void adjustRowWidth()
        {
            this.FileNameGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// データグリッドクリックイベント関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGrid_Click(object sender, EventArgs e)
        {
            ///選択したセルの値を取得する
            int selectecRowIndex = this.FileNameGridView.CurrentRow.Index;
            string selectedFileName = this.FileNameGridView.Rows[selectecRowIndex].Cells[0].Value.ToString();
            this.SelectedFileNameLabel.Text = selectedFileName;

            ///再生用のパスを取得する
            this.selectedFilePath = checkIncludingString(selectedFileName);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            selectExtendState();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
        }
    }
}
