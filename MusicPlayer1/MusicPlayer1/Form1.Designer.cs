
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.previousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SelectedFileNameLabel = new System.Windows.Forms.Label();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.SortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FileNameGridView)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.previousButton);
            this.panel1.Controls.Add(this.NextButton);
            this.panel1.Controls.Add(this.PlayButton);
            this.panel1.Controls.Add(this.SelectedFileNameLabel);
            this.panel1.Location = new System.Drawing.Point(26, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 130);
            this.panel1.TabIndex = 1;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(81, 58);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(45, 24);
            this.previousButton.TabIndex = 3;
            this.previousButton.Text = "button3";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(216, 58);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(45, 24);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "button2";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(148, 47);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(45, 35);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "button1";
            this.PlayButton.UseVisualStyleBackColor = true;
            // 
            // SelectedFileNameLabel
            // 
            this.SelectedFileNameLabel.AutoSize = true;
            this.SelectedFileNameLabel.Location = new System.Drawing.Point(23, 20);
            this.SelectedFileNameLabel.Name = "SelectedFileNameLabel";
            this.SelectedFileNameLabel.Size = new System.Drawing.Size(35, 12);
            this.SelectedFileNameLabel.TabIndex = 0;
            this.SelectedFileNameLabel.Text = "label1";
            // 
            // SortComboBox
            // 
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Location = new System.Drawing.Point(167, 58);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(121, 20);
            this.SortComboBox.TabIndex = 2;
            this.SortComboBox.SelectedIndexChanged += new System.EventHandler(this.SortComboBox_SelectedIndexChanged);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(295, 58);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(68, 20);
            this.SortButton.TabIndex = 3;
            this.SortButton.Text = "ソート実施";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.SortComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileNameGridView);
            this.Name = "Form1";
            this.Text = "MusicPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.FileNameGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView FileNameGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SelectedFileNameLabel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.Button SortButton;
    }
}

