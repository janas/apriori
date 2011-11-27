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
    public partial class GenerateInputForm : Form
    {
        private int transactionsNumber;
        private int itemsNumber;
        private int itemsInTransNumber;

        public GenerateInputForm()
        {
            InitializeComponent();
            transactionsUpDown.Maximum = Int32.MaxValue;
            itemsUpDown.Maximum = Int32.MaxValue;
            itemsInTransUpDown.Maximum = Int32.MaxValue;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            transactionsNumber = (int)transactionsUpDown.Value;
            itemsNumber = (int)itemsUpDown.Value;
            itemsInTransNumber = (int)itemsInTransUpDown.Value;
            if (itemsInTransNumber <= itemsNumber)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Maximal number of items in transaction\n"
                    + "cannot be greater than\n"
                    + "Maximal number of items!");
        }

        public int getTransactionsNumber()
        {
            return transactionsNumber;
        }

        public int getItemsNumber()
        {
            return itemsNumber;
        }

        public int getItemsInTransNumber()
        {
            return itemsInTransNumber;
        }
    }
}
