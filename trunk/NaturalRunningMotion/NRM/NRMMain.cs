using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NRM
{
    public partial class NRMMain : Form
    {
        public NRMMain()
        {
            InitializeComponent();
        }

        private void _buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                PlayListBuilder pl = new PlayListBuilder();
                pl.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "There was an error when trying to opening the aplication.\nPlease try again. If the persists contact the application developers." + 
                    "\n\nInner Error: " + ex.ToString(),
                    "Error opening playlist builder's form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void _buttonWiiConnect_Click(object sender, EventArgs e)
        {
            NRMWiiConnect form = new NRMWiiConnect();
            form.Show();
        }
    }
}
