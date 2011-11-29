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

        /// <summary>Default constructor.</summary>
        public SetSupportForm()
        {
            InitializeComponent();
        }

        /// <summary>Sets value of supportPercentage.</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setButton_Click(object sender, EventArgs e)
        {
            supportPercentage = (int)supportUpDown.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>Gets value of supportPercentage.</summary>
        /// <returns>Value of supportPercentage.</returns>
        public int getSupportPercentage()
        {
            return supportPercentage;
        }
    }
}
