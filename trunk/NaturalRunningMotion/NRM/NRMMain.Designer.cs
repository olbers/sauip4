namespace NRM
{
    partial class NRMMain
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
            this._buttonStart = new System.Windows.Forms.Button();
            this._buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._buttonExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._textBoxWiimoteCount = new System.Windows.Forms.TextBox();
            this._textBoxNunchukCount = new System.Windows.Forms.TextBox();
            this._textBoxExportPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxNunData = new System.Windows.Forms.TextBox();
            this._textBoxWiiData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._buttonClearData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonStart
            // 
            this._buttonStart.Location = new System.Drawing.Point(267, 99);
            this._buttonStart.Name = "_buttonStart";
            this._buttonStart.Size = new System.Drawing.Size(109, 39);
            this._buttonStart.TabIndex = 0;
            this._buttonStart.Text = "Start Recording";
            this._buttonStart.UseVisualStyleBackColor = true;
            this._buttonStart.Click += new System.EventHandler(this._buttonStart_Click);
            // 
            // _buttonStop
            // 
            this._buttonStop.Location = new System.Drawing.Point(267, 138);
            this._buttonStop.Name = "_buttonStop";
            this._buttonStop.Size = new System.Drawing.Size(109, 39);
            this._buttonStop.TabIndex = 1;
            this._buttonStop.Text = "Stop Recording";
            this._buttonStop.UseVisualStyleBackColor = true;
            this._buttonStop.Click += new System.EventHandler(this._buttonStop_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wiimote Data Count:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _buttonExport
            // 
            this._buttonExport.Location = new System.Drawing.Point(267, 183);
            this._buttonExport.Name = "_buttonExport";
            this._buttonExport.Size = new System.Drawing.Size(109, 39);
            this._buttonExport.TabIndex = 2;
            this._buttonExport.Text = "Export Data";
            this._buttonExport.UseVisualStyleBackColor = true;
            this._buttonExport.Click += new System.EventHandler(this._buttonExport_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nunchuk Data Count:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textBoxWiimoteCount
            // 
            this._textBoxWiimoteCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxWiimoteCount.Cursor = System.Windows.Forms.Cursors.Default;
            this._textBoxWiimoteCount.Location = new System.Drawing.Point(137, 99);
            this._textBoxWiimoteCount.Name = "_textBoxWiimoteCount";
            this._textBoxWiimoteCount.ReadOnly = true;
            this._textBoxWiimoteCount.Size = new System.Drawing.Size(100, 20);
            this._textBoxWiimoteCount.TabIndex = 4;
            // 
            // _textBoxNunchukCount
            // 
            this._textBoxNunchukCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxNunchukCount.Cursor = System.Windows.Forms.Cursors.Default;
            this._textBoxNunchukCount.Location = new System.Drawing.Point(137, 138);
            this._textBoxNunchukCount.Name = "_textBoxNunchukCount";
            this._textBoxNunchukCount.ReadOnly = true;
            this._textBoxNunchukCount.Size = new System.Drawing.Size(100, 20);
            this._textBoxNunchukCount.TabIndex = 5;
            // 
            // _textBoxExportPath
            // 
            this._textBoxExportPath.Location = new System.Drawing.Point(137, 193);
            this._textBoxExportPath.Name = "_textBoxExportPath";
            this._textBoxExportPath.Size = new System.Drawing.Size(100, 20);
            this._textBoxExportPath.TabIndex = 6;
            this._textBoxExportPath.Text = "C:\\";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(65, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Export Path:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textBoxNunData
            // 
            this._textBoxNunData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxNunData.Cursor = System.Windows.Forms.Cursors.Default;
            this._textBoxNunData.Location = new System.Drawing.Point(137, 43);
            this._textBoxNunData.Name = "_textBoxNunData";
            this._textBoxNunData.ReadOnly = true;
            this._textBoxNunData.Size = new System.Drawing.Size(100, 20);
            this._textBoxNunData.TabIndex = 11;
            // 
            // _textBoxWiiData
            // 
            this._textBoxWiiData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxWiiData.Cursor = System.Windows.Forms.Cursors.Default;
            this._textBoxWiiData.Location = new System.Drawing.Point(137, 4);
            this._textBoxWiiData.Name = "_textBoxWiiData";
            this._textBoxWiiData.ReadOnly = true;
            this._textBoxWiiData.Size = new System.Drawing.Size(100, 20);
            this._textBoxWiiData.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(44, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nunchuk Data:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(53, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wiimote Data:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _buttonClearData
            // 
            this._buttonClearData.Location = new System.Drawing.Point(267, 4);
            this._buttonClearData.Name = "_buttonClearData";
            this._buttonClearData.Size = new System.Drawing.Size(109, 39);
            this._buttonClearData.TabIndex = 12;
            this._buttonClearData.Text = "Clear Data";
            this._buttonClearData.UseVisualStyleBackColor = true;
            this._buttonClearData.Click += new System.EventHandler(this._buttonClearData_Click);
            // 
            // NRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 234);
            this.Controls.Add(this._buttonClearData);
            this.Controls.Add(this._textBoxNunData);
            this.Controls.Add(this._textBoxWiiData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textBoxExportPath);
            this.Controls.Add(this._textBoxNunchukCount);
            this.Controls.Add(this._textBoxWiimoteCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._buttonExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonStop);
            this.Controls.Add(this._buttonStart);
            this.Name = "NRMMain";
            this.Text = "Natural Runnning Motion";
            this.Load += new System.EventHandler(this.NRMMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NRMMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonStart;
        private System.Windows.Forms.Button _buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _buttonExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBoxWiimoteCount;
        private System.Windows.Forms.TextBox _textBoxNunchukCount;
        private System.Windows.Forms.TextBox _textBoxExportPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _textBoxNunData;
        private System.Windows.Forms.TextBox _textBoxWiiData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _buttonClearData;
    }
}

