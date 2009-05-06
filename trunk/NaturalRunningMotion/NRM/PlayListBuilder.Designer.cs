namespace NRM
{
    partial class PlayListBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

 
            if (disposing && (components != null))
            {
                components.Dispose();
                if(!disposedSound)
                    DisposeSound();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._buttonCalculate = new System.Windows.Forms.Button();
            this._textBoxBPM = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this._dgPlaylist = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._bindingSourcePlaylist = new System.Windows.Forms.BindingSource(this.components);
            this._textboxSongPlaying = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._buttonExportPlaylist = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._textBoxDistance = new System.Windows.Forms.TextBox();
            this._textBoxDuration = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dgPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourcePlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonCalculate
            // 
            this._buttonCalculate.Location = new System.Drawing.Point(51, 10);
            this._buttonCalculate.Name = "_buttonCalculate";
            this._buttonCalculate.Size = new System.Drawing.Size(109, 39);
            this._buttonCalculate.TabIndex = 8;
            this._buttonCalculate.Text = "Open Music File";
            this._buttonCalculate.UseVisualStyleBackColor = true;
            this._buttonCalculate.Click += new System.EventHandler(this._buttonCalculate_Click);
            // 
            // _textBoxBPM
            // 
            this._textBoxBPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxBPM.Location = new System.Drawing.Point(160, 81);
            this._textBoxBPM.Name = "_textBoxBPM";
            this._textBoxBPM.ReadOnly = true;
            this._textBoxBPM.Size = new System.Drawing.Size(233, 20);
            this._textBoxBPM.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.mp3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Music List:";
            // 
            // _dgPlaylist
            // 
            this._dgPlaylist.AllowUserToAddRows = false;
            this._dgPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._dgPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cBPM});
            this._dgPlaylist.Location = new System.Drawing.Point(51, 120);
            this._dgPlaylist.Name = "_dgPlaylist";
            this._dgPlaylist.Size = new System.Drawing.Size(499, 247);
            this._dgPlaylist.TabIndex = 14;
            // 
            // cName
            // 
            this.cName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cName.DataPropertyName = "Name";
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cBPM
            // 
            this.cBPM.DataPropertyName = "BPM";
            this.cBPM.HeaderText = "cBPM";
            this.cBPM.Name = "cBPM";
            this.cBPM.ReadOnly = true;
            // 
            // _textboxSongPlaying
            // 
            this._textboxSongPlaying.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textboxSongPlaying.Location = new System.Drawing.Point(160, 55);
            this._textboxSongPlaying.Name = "_textboxSongPlaying";
            this._textboxSongPlaying.ReadOnly = true;
            this._textboxSongPlaying.Size = new System.Drawing.Size(390, 20);
            this._textboxSongPlaying.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Playing song:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "BPM Detector:";
            // 
            // _buttonExportPlaylist
            // 
            this._buttonExportPlaylist.Location = new System.Drawing.Point(272, 388);
            this._buttonExportPlaylist.Name = "_buttonExportPlaylist";
            this._buttonExportPlaylist.Size = new System.Drawing.Size(96, 39);
            this._buttonExportPlaylist.TabIndex = 18;
            this._buttonExportPlaylist.Text = "Calculate and Export Playlist";
            this._buttonExportPlaylist.UseVisualStyleBackColor = true;
            this._buttonExportPlaylist.Click += new System.EventHandler(this._buttonExportPlaylist_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Duration of the run (minutes):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Distance to run (meters):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textBoxDistance
            // 
            this._textBoxDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxDistance.Location = new System.Drawing.Point(160, 388);
            this._textBoxDistance.Name = "_textBoxDistance";
            this._textBoxDistance.Size = new System.Drawing.Size(96, 20);
            this._textBoxDistance.TabIndex = 20;
            // 
            // _textBoxDuration
            // 
            this._textBoxDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxDuration.Location = new System.Drawing.Point(160, 409);
            this._textBoxDuration.Name = "_textBoxDuration";
            this._textBoxDuration.Size = new System.Drawing.Size(96, 20);
            this._textBoxDuration.TabIndex = 19;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyMusic;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(389, 407);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "c:\\";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Export Folder:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PlayListBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 463);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._textBoxDistance);
            this.Controls.Add(this._textBoxDuration);
            this.Controls.Add(this._buttonExportPlaylist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textboxSongPlaying);
            this.Controls.Add(this._dgPlaylist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBoxBPM);
            this.Controls.Add(this._buttonCalculate);
            this.Name = "PlayListBuilder";
            this.Text = "PlayListBuilder";
            ((System.ComponentModel.ISupportInitialize)(this._dgPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourcePlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonCalculate;
        private System.Windows.Forms.TextBox _textBoxBPM;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _dgPlaylist;
        private System.Windows.Forms.BindingSource _bindingSourcePlaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBPM;
        private System.Windows.Forms.TextBox _textboxSongPlaying;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _buttonExportPlaylist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _textBoxDistance;
        private System.Windows.Forms.TextBox _textBoxDuration;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}