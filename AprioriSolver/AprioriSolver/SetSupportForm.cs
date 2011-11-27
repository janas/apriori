using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AprioriSolver
{
    public partial class SetSupportForm : Form
    {
        private int supportPercentage;

        public SetSupportForm()
        {
            InitializeComponent();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            supportPercentage = (int)supportUpDown.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public int getSupportPercentage()
        {
            return supportPercentage;
        }
    }
}
