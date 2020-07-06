using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrmSupermarketManagement
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }
        
        private void timepass_Tick(object sender, EventArgs e)
        {
            pLoading.Width += 5;
            if (pLoading.Width>900)
            {
                this.DialogResult = DialogResult.OK;
                timepass.Stop();
                Close();
                
            }
            
        }
    }
}
