
namespace MusicPlayer1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FileNameGridView = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FileNameGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FileNameGridView
            // 
            this.FileNameGridView.AllowUserToAddRows = false;
            this.FileNameGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileNameGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName});
            this.FileNameGridView.Location = new System.Drawing.Point(26, 84);
            this.FileNameGridView.Name = "FileNameGridView";
            this.FileNameGridView.RowHeadersVisible = false;
            this.FileNameGridView.RowTemplate.Height = 21;
            this.FileNameGridView.Size = new System.Drawing.Size(338, 221);
            this.FileNameGridView.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "曲名";
            this.FileName.Name = "FileName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.FileNameGridView);
            this.Name = "Form1";
            this.Text = "MusicPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.FileNameGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView FileNameGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
    }
}

