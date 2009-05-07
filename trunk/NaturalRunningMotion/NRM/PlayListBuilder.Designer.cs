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
            this._dgPlaylist = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._buttonPlay = new System.Windows.Forms.Button();
            this._buttonStop = new System.Windows.Forms.Button();
            this._buttonNext = new System.Windows.Forms.Button();
            this._buttonPrevious = new System.Windows.Forms.Button();
            this._buttonPause = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lBPM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dgPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourcePlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonCalculate
            // 
            this._buttonCalculate.Location = new System.Drawing.Point(277, 79);
            this._buttonCalculate.Name = "_buttonCalculate";
            this._buttonCalculate.Size = new System.Drawing.Size(109, 27);
            this._buttonCalculate.TabIndex = 8;
            this._buttonCalculate.Text = "Add Music Files";
            this._buttonCalculate.UseVisualStyleBackColor = true;
            this._buttonCalculate.Click += new System.EventHandler(this._buttonCalculate_Click);
            // 
            // _textBoxBPM
            // 
            this._textBoxBPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxBPM.Location = new System.Drawing.Point(117, 53);
            this._textBoxBPM.Name = "_textBoxBPM";
            this._textBoxBPM.ReadOnly = true;
            this._textBoxBPM.Size = new System.Drawing.Size(269, 20);
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
            // _dgPlaylist
            // 
            this._dgPlaylist.AllowUserToAddRows = false;
            this._dgPlaylist.AllowUserToDeleteRows = false;
            this._dgPlaylist.AllowUserToResizeRows = false;
            this._dgPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this._dgPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.Length,
            this.cBPM});
            this._dgPlaylist.Location = new System.Drawing.Point(12, 12);
            this._dgPlaylist.Name = "_dgPlaylist";
            this._dgPlaylist.RowHeadersVisible = false;
            this._dgPlaylist.Size = new System.Drawing.Size(406, 339);
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
            // Length
            // 
            this.Length.DataPropertyName = "Length";
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // cBPM
            // 
            this.cBPM.DataPropertyName = "BPM";
            this.cBPM.HeaderText = "BPM";
            this.cBPM.Name = "cBPM";
            this.cBPM.ReadOnly = true;
            // 
            // _textboxSongPlaying
            // 
            this._textboxSongPlaying.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textboxSongPlaying.Location = new System.Drawing.Point(117, 9);
            this._textboxSongPlaying.Multiline = true;
            this._textboxSongPlaying.Name = "_textboxSongPlaying";
            this._textboxSongPlaying.ReadOnly = true;
            this._textboxSongPlaying.Size = new System.Drawing.Size(269, 38);
            this._textboxSongPlaying.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Playing song:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "BPM Detector:";
            // 
            // _buttonExportPlaylist
            // 
            this._buttonExportPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._buttonExportPlaylist.Location = new System.Drawing.Point(432, 106);
            this._buttonExportPlaylist.Name = "_buttonExportPlaylist";
            this._buttonExportPlaylist.Size = new System.Drawing.Size(127, 39);
            this._buttonExportPlaylist.TabIndex = 18;
            this._buttonExportPlaylist.Text = "Create Playlist >>";
            this._buttonExportPlaylist.UseVisualStyleBackColor = true;
            this._buttonExportPlaylist.Click += new System.EventHandler(this._buttonExportPlaylist_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Duration of the run (minutes):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Distance to run (meters):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textBoxDistance
            // 
            this._textBoxDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._textBoxDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxDistance.Location = new System.Drawing.Point(432, 44);
            this._textBoxDistance.Name = "_textBoxDistance";
            this._textBoxDistance.Size = new System.Drawing.Size(127, 20);
            this._textBoxDistance.TabIndex = 20;
            this._textBoxDistance.Text = "1000";
            // 
            // _textBoxDuration
            // 
            this._textBoxDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._textBoxDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxDuration.Location = new System.Drawing.Point(432, 83);
            this._textBoxDuration.Name = "_textBoxDuration";
            this._textBoxDuration.Size = new System.Drawing.Size(127, 20);
            this._textBoxDuration.TabIndex = 19;
            this._textBoxDuration.Text = "30";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyMusic;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(437, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "c:\\";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Export Folder:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Location = new System.Drawing.Point(568, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(322, 339);
            this.dataGridView1.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Length";
            this.dataGridViewTextBoxColumn2.HeaderText = "Length";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BPM";
            this.dataGridViewTextBoxColumn3.HeaderText = "BPM";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._textBoxBPM);
            this.groupBox1.Controls.Add(this._buttonCalculate);
            this.groupBox1.Controls.Add(this._textboxSongPlaying);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 112);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Musics";
            // 
            // _buttonPlay
            // 
            this._buttonPlay.Location = new System.Drawing.Point(568, 358);
            this._buttonPlay.Name = "_buttonPlay";
            this._buttonPlay.Size = new System.Drawing.Size(57, 23);
            this._buttonPlay.TabIndex = 27;
            this._buttonPlay.Text = "Play";
            this._buttonPlay.UseVisualStyleBackColor = true;
            // 
            // _buttonStop
            // 
            this._buttonStop.Location = new System.Drawing.Point(700, 358);
            this._buttonStop.Name = "_buttonStop";
            this._buttonStop.Size = new System.Drawing.Size(57, 23);
            this._buttonStop.TabIndex = 28;
            this._buttonStop.Text = "Stop";
            this._buttonStop.UseVisualStyleBackColor = true;
            // 
            // _buttonNext
            // 
            this._buttonNext.Location = new System.Drawing.Point(832, 358);
            this._buttonNext.Name = "_buttonNext";
            this._buttonNext.Size = new System.Drawing.Size(57, 23);
            this._buttonNext.TabIndex = 30;
            this._buttonNext.Text = "Next";
            this._buttonNext.UseVisualStyleBackColor = true;
            // 
            // _buttonPrevious
            // 
            this._buttonPrevious.Location = new System.Drawing.Point(766, 358);
            this._buttonPrevious.Name = "_buttonPrevious";
            this._buttonPrevious.Size = new System.Drawing.Size(57, 23);
            this._buttonPrevious.TabIndex = 29;
            this._buttonPrevious.Text = "Previous";
            this._buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // _buttonPause
            // 
            this._buttonPause.Location = new System.Drawing.Point(634, 358);
            this._buttonPause.Name = "_buttonPause";
            this._buttonPause.Size = new System.Drawing.Size(57, 23);
            this._buttonPause.TabIndex = 31;
            this._buttonPause.Text = "Pause";
            this._buttonPause.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lBPM);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(427, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 116);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "BPM:";
            // 
            // lBPM
            // 
            this.lBPM.AutoSize = true;
            this.lBPM.Location = new System.Drawing.Point(46, 29);
            this.lBPM.Name = "lBPM";
            this.lBPM.Size = new System.Drawing.Size(0, 13);
            this.lBPM.TabIndex = 2;
            // 
            // PlayListBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._buttonPause);
            this.Controls.Add(this._buttonNext);
            this.Controls.Add(this._buttonPrevious);
            this.Controls.Add(this._buttonStop);
            this.Controls.Add(this._buttonPlay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._buttonExportPlaylist);
            this.Controls.Add(this._textBoxDuration);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._textBoxDistance);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this._dgPlaylist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "PlayListBuilder";
            this.Text = "PlayListBuilder";
            ((System.ComponentModel.ISupportInitialize)(this._dgPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindingSourcePlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonCalculate;
        private System.Windows.Forms.TextBox _textBoxBPM;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView _dgPlaylist;
        private System.Windows.Forms.BindingSource _bindingSourcePlaylist;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _buttonPlay;
        private System.Windows.Forms.Button _buttonStop;
        private System.Windows.Forms.Button _buttonNext;
        private System.Windows.Forms.Button _buttonPrevious;
        private System.Windows.Forms.Button _buttonPause;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lBPM;
        private System.Windows.Forms.Label label7;
    }
}