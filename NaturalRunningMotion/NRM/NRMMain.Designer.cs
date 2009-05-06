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
            this._buttonStop = new System.Windows.Forms.Button();
            this._buttonWiiConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonStop
            // 
            this._buttonStop.Location = new System.Drawing.Point(92, 136);
            this._buttonStop.Name = "_buttonStop";
            this._buttonStop.Size = new System.Drawing.Size(109, 39);
            this._buttonStop.TabIndex = 3;
            this._buttonStop.Text = "Build Playlist";
            this._buttonStop.UseVisualStyleBackColor = true;
            this._buttonStop.Click += new System.EventHandler(this._buttonStop_Click);
            // 
            // _buttonWiiConnect
            // 
            this._buttonWiiConnect.Location = new System.Drawing.Point(92, 42);
            this._buttonWiiConnect.Name = "_buttonWiiConnect";
            this._buttonWiiConnect.Size = new System.Drawing.Size(109, 39);
            this._buttonWiiConnect.TabIndex = 2;
            this._buttonWiiConnect.Text = "Wii Connect";
            this._buttonWiiConnect.UseVisualStyleBackColor = true;
            this._buttonWiiConnect.Click += new System.EventHandler(this._buttonWiiConnect_Click);
            // 
            // NRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this._buttonStop);
            this.Controls.Add(this._buttonWiiConnect);
            this.Name = "NRMMain";
            this.Text = "NRMMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonStop;
        private System.Windows.Forms.Button _buttonWiiConnect;

    }
}