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
            if (disposing)
            {
                FMOD.RESULT result;

                if (sound != null)
                {
                    result = sound.release();
                    ERRCHECK(result);
                }

                if (system != null)
                {
                    result = system.close();
                    ERRCHECK(result);

                    result = system.release();
                    ERRCHECK(result);
                }

                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
            //if (disposing && (components != null))
            //{
            //    components.Dispose();
            //}
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxPath = new System.Windows.Forms.TextBox();
            this._buttonCalculate = new System.Windows.Forms.Button();
            this._listBoxPlaylist = new System.Windows.Forms.ListBox();
            this._textBoxBPM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Path:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textBoxPath
            // 
            this._textBoxPath.Location = new System.Drawing.Point(51, 22);
            this._textBoxPath.Name = "_textBoxPath";
            this._textBoxPath.Size = new System.Drawing.Size(326, 20);
            this._textBoxPath.TabIndex = 9;
            this._textBoxPath.Text = "C:\\music.mp3";
            // 
            // _buttonCalculate
            // 
            this._buttonCalculate.Location = new System.Drawing.Point(268, 48);
            this._buttonCalculate.Name = "_buttonCalculate";
            this._buttonCalculate.Size = new System.Drawing.Size(109, 39);
            this._buttonCalculate.TabIndex = 8;
            this._buttonCalculate.Text = "Calculate BPM";
            this._buttonCalculate.UseVisualStyleBackColor = true;
            this._buttonCalculate.Click += new System.EventHandler(this._buttonCalculate_Click);
            // 
            // _listBoxPlaylist
            // 
            this._listBoxPlaylist.FormattingEnabled = true;
            this._listBoxPlaylist.Location = new System.Drawing.Point(41, 149);
            this._listBoxPlaylist.Name = "_listBoxPlaylist";
            this._listBoxPlaylist.Size = new System.Drawing.Size(326, 121);
            this._listBoxPlaylist.TabIndex = 11;
            // 
            // _textBoxBPM
            // 
            this._textBoxBPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxBPM.Location = new System.Drawing.Point(51, 96);
            this._textBoxBPM.Name = "_textBoxBPM";
            this._textBoxBPM.ReadOnly = true;
            this._textBoxBPM.Size = new System.Drawing.Size(326, 20);
            this._textBoxBPM.TabIndex = 12;
            // 
            // PlayListBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 282);
            this.Controls.Add(this._textBoxBPM);
            this.Controls.Add(this._listBoxPlaylist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textBoxPath);
            this.Controls.Add(this._buttonCalculate);
            this.Name = "PlayListBuilder";
            this.Text = "PlayListBuilder";
            this.Load += new System.EventHandler(this.PlayListBuilder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxPath;
        private System.Windows.Forms.Button _buttonCalculate;
        private System.Windows.Forms.ListBox _listBoxPlaylist;
        private System.Windows.Forms.TextBox _textBoxBPM;
    }
}