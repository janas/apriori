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
    public partial class MainForm : Form
    {
        List<List<int>> transactions;
        List<List<int>> frequentSets;
        List<int> items;
        int support = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private int setInSetOfSets(List<int> searched, List<List<int>> target)
        {
            int result = 0;
            bool indicator;
            foreach (List<int> tar in target)
            {
                indicator = true;
                foreach (int element in searched)
                    if (!tar.Contains(element))
                    {
                        indicator = false;
                        break;
                    }
                if (indicator)
                    result++;
            }
            return result;
        }

        private List<int> joinSets(List<int> set1, List<int> set2)
        {
            List<int> result = new List<int>(set1);
            foreach (int element in set2)
                if (!result.Contains(element))
                    result.Add(element);
            result.Sort();
            return result;
        }

        private List<List<int>> createCandidates(List<List<int>> L, int length)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> candidate = new List<int>();
            for (int i = 0; i < L.Count; i++)
            {
                for (int j = i + 1; j < L.Count; j++)
                {
                    candidate = joinSets(L.ElementAt(i), L.ElementAt(j));
                    if (candidate.Count == length)
                        result.Add(candidate);
                }
            }
            return result;
        }

        private void findFrequent(List<List<int>> candidates, int length)
        {
            List<List<int>> L = new List<List<int>>();
            foreach (List<int> C in candidates)
                if (setInSetOfSets(C, transactions) >= support)
                    L.Add(C);
            foreach (List<int> set in L)
                frequentSets.Add(set);
            length++;
            List<List<int>> nextCandidates = createCandidates(L, length);
            if (nextCandidates.Count == 0)
                return;
            else
                findFrequent(nextCandidates, length);
        }

        private void generateTransactions(int transactionsN, int itemsN, int itemsInTransN)
        {
            transactionsListBox.Items.Clear();
            transactions = new List<List<int>>();
            items = new List<int>();
            Random random = new Random();
            for (int i = 0; i < transactionsN; i++)
            {
                List<int> transaction = new List<int>();
                string transactionString = "";
                int maxJ = random.Next(1, itemsInTransN + 1);
                for (int j = 0; j < maxJ; j++)
                {
                    int item;
                    do
                    {
                        item = random.Next(1, itemsN + 1);
                    } while (transaction.Contains(item));
                    transaction.Add(item);
                    if (!items.Contains(item))
                        items.Add(item);
                }
                transaction.Sort();
                foreach (int element in transaction)
                    transactionString += element.ToString() + " ";
                transactions.Add(transaction);
                transactionsListBox.Items.Add(transactionString);
            }
        }

        private void generateTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int transactionsNumber;
            int itemsNumber;
            int itemsInTransNumber;
            using (GenerateInputForm gif = new GenerateInputForm())
            {
                DialogResult dr = gif.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    transactionsNumber = gif.getTransactionsNumber();
                    itemsNumber = gif.getItemsNumber();
                    itemsInTransNumber = gif.getItemsInTransNumber();
                    generateTransactions(transactionsNumber, itemsNumber, itemsInTransNumber);
                }
                else
                {
                    MessageBox.Show("You have not generated any transactions.");
                }
            }
            controlTab.SelectedIndex = 0;
        }

        private void importTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlTab.SelectedIndex = 0;
        }

        private void generateOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (support == 0)
            {
                MessageBox.Show("Sorry, the support is equal to 0.");
                return;
            }
            if (items == null || items.Count == 0)
            {
                MessageBox.Show("Sorry, there are no items in transactions.");
                return;
            }
            int length = 1;
            List<List<int>> candidates = new List<List<int>>();
            frequentSets = new List<List<int>>();
            foreach (int element in items)
            {
                List<int> temp = new List<int>();
                temp.Add(element);
                candidates.Add(temp);
            }
            findFrequent(candidates, length);
            frequentListBox.Items.Clear();
            foreach (List<int> set in frequentSets)
            {
                string setString = "";
                foreach (int element in set)
                    setString += element.ToString() + " ";
                frequentListBox.Items.Add(setString);
            }
            controlTab.SelectedIndex = 1;
        }

        private void exportOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlTab.SelectedIndex = 1;
        }

        private void setSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transactions == null || transactions.Count == 0)
            {
                MessageBox.Show("Please, firstly generate or import transactions.");
                return;
            }
            using (SetSupportForm ssf = new SetSupportForm())
            {
                DialogResult dr = ssf.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    int percentage = ssf.getSupportPercentage();
                    support = (transactions.Count * percentage) / 100;
                    MessageBox.Show("Support set to " + percentage.ToString() + "%,\n"
                        + "which is " + support.ToString() + " transaction(s).");
                }
                else
                {
                    MessageBox.Show("You have not set support.");
                }
            }
        }
    }
}
