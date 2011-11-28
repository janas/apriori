using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AprioriSolver
{
    public partial class MainForm : Form
    {
        List<List<int>> transactions;
        List<List<int>> frequentSets;
        List<int> items;
        int support = 0;
        int transactionsNumber;
        int itemsNumber;
        int itemsInTransNumber;
        Thread thread;
        XDocument xDoc;
        string xImportFileName;
        string xExportFileName;

        public MainForm()
        {
            InitializeComponent();
        }

        private void threadStart(string info)
        {
            progressBarLabel.Invoke((MethodInvoker)(() => progressBarLabel.Text = info));
            thread.Start();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
        }

        private void threadStop()
        {
            progressBarLabel.Invoke((MethodInvoker)(() => progressBarLabel.Text = ""));
            StopProgressBar(progressBar);
            thread.Abort();
        }

        delegate void CallProgressBarStop(ProgressBar myProgressBar);
        private void StopProgressBar(ProgressBar myProgressBar)
        {
            if (myProgressBar.InvokeRequired)
            {
                CallProgressBarStop del = StopProgressBar;
                myProgressBar.Invoke(del, new object[] { myProgressBar });
                return;
            }

            myProgressBar.Style = ProgressBarStyle.Continuous;
            myProgressBar.MarqueeAnimationSpeed = 0;
        }

        /// <summary>Counts how many target sets contains searched set.</summary>
        /// <param name="searched">Searched set.</param>
        /// <param name="target">List of target sets.</param>
        /// <returns>Number of containments of searched set in target sets.</returns>
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

        /// <summary>Creates union of two sets.</summary>
        /// <param name="set1">One set to be joined.</param>
        /// <param name="set2">Another set to be joined.</param>
        /// <returns>Union of parameter sets.</returns>
        private List<int> joinSets(List<int> set1, List<int> set2)
        {
            List<int> result = new List<int>(set1);
            foreach (int element in set2)
                if (!result.Contains(element))
                    result.Add(element);
            result.Sort();
            return result;
        }
        
        /// <summary>Creates candidate sets for frequent sets.</summary>
        /// <param name="L">List of frequent set for candidate sets creating.</param>
        /// <param name="length">Size of candidate sets to be created.</param>
        /// <returns>Candidate sets.</returns>
        private List<List<int>> createCandidates(List<List<int>> L, int length)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> candidate = new List<int>();
            for (int i = 0; i < L.Count; i++)
            {
                for (int j = i + 1; j < L.Count; j++)
                {
                    candidate = joinSets(L.ElementAt(i), L.ElementAt(j));
                    if (candidate.Count == length && setInSetOfSets(candidate, result)<1)
                        result.Add(candidate);
                }
            }
            return result;
        }

        /// <summary>Initializes finding frequent sets and prints result in ListBox.</summary>
        private void findFrequent()
        {
            findFrequent(null, 1);
            frequentListBox.Invoke((MethodInvoker)(() => frequentListBox.Items.Clear()));
            //frequentSets.Sort();
            foreach (List<int> set in frequentSets)
            {
                string setString = "";
                foreach (int element in set)
                    setString += element.ToString() + " ";
                frequentListBox.Invoke((MethodInvoker)(() => frequentListBox.Items.Add(setString)));
            }
            controlTab.Invoke((MethodInvoker)(() => controlTab.SelectedIndex = 1));
            threadStop();
        }

        /// <summary>Finds frequent sets in candidate sets and moves them to frequent list.</summary>
        /// <param name="candidates">Candidate sets.</param>
        /// <param name="length">Size of frequent sets to be found.</param>
        private void findFrequent(List<List<int>> candidates, int length)
        {
            progressBarLabel.Invoke((MethodInvoker)(() => progressBarLabel.Text = 
                "Generating frequent sets of length " + length.ToString()));
            if (candidates == null)
            {
                candidates = new List<List<int>>();
                frequentSets = new List<List<int>>();
                foreach (int element in items)
                {
                    List<int> temp = new List<int>();
                    temp.Add(element);
                    candidates.Add(temp);
                }
            }
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

        /// <summary>Initializes generating transactions.</summary>
        private void generateTransactions()
        {
            generateTransactions(transactionsNumber, itemsNumber, itemsInTransNumber);
            threadStop();
        }

        /// <summary>Generate transactions.</summary>
        /// <param name="transactionsN">Number of transactions to be generated.</param>
        /// <param name="itemsN">Maximal number of items.</param>
        /// <param name="itemsInTransN">Maximal numbes of items on one transaction.</param>
        private void generateTransactions(int transactionsN, int itemsN, int itemsInTransN)
        {
            transactionsListBox.Invoke((MethodInvoker)(() => transactionsListBox.Items.Clear()));
            transactions = new List<List<int>>();
            items = new List<int>();
            Random random = new Random();
            for (int i = 0; i < transactionsN; i++)
            {
                //if (i % 1000 == 0)
                    progressBarLabel.Invoke((MethodInvoker)(() => progressBarLabel.Text =
                        "Generating transactions: " + ((i*100)/transactionsN).ToString() + "%"));
                List<int> transaction = new List<int>();
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
                transactions.Add(transaction);
                string transactionString = "";
                foreach (int element in transaction)
                    transactionString += element.ToString() + " ";
                transactionsListBox.Invoke((MethodInvoker)(() => transactionsListBox.Items.Add(transactionString)));
            }
        }

        /// <summary>Calls GenesateInputForm for retreiving user input needed to generate transactions.</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (GenerateInputForm gif = new GenerateInputForm())
            {
                DialogResult dr = gif.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    transactionsNumber = gif.getTransactionsNumber();
                    itemsNumber = gif.getItemsNumber();
                    itemsInTransNumber = gif.getItemsInTransNumber();
                    thread = new Thread(new ThreadStart(generateTransactions));
                    threadStart("Generating transactions");
                }
                else
                {
                    MessageBox.Show("You have not generated any transactions.");
                }
            }
            controlTab.SelectedIndex = 0;
        }

        /// <summary>Imports XML file with transactions.</summary>
        private void importXmlFileWithTransactions()
        {
            XDocument xmlDoc = XDocument.Load(xImportFileName);
            try
            {
                string elementString = "";
                transactionsListBox.Invoke((MethodInvoker)(() => transactionsListBox.Items.Clear()));
                transactions = new List<List<int>>();
                items = new List<int>();
                var xmlTrans = from t in xmlDoc.Descendants("transaction")
                               select new
                               {
                                   L = t.Elements("item"),
                               };
                foreach (var t in xmlTrans)
                {
                    List<int> transaction = new List<int>();
                    foreach (XElement xe in t.L)
                    {
                        int element;
                        elementString = xe.ToString().TrimStart("<item>".ToCharArray()).TrimEnd("</item>".ToCharArray());
                        element = Int32.Parse(elementString);
                        if (!transaction.Contains(element))
                            transaction.Add(element);
                        if (!items.Contains(element))
                            items.Add(element);
                    }
                    transaction.Sort();
                    transactions.Add(transaction);
                    string transactionString = "";
                    foreach (int element in transaction)
                        transactionString += element.ToString() + " ";
                    transactionsListBox.Invoke((MethodInvoker)(() => transactionsListBox.Items.Add(transactionString)));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("File invalid.\n" + exc.ToString());
            }
            threadStop();
        }

        /// <summary>Calls OpenFileDialog for importing XML file.</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            ofd.RestoreDirectory = true;
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                xImportFileName = ofd.FileName;
                thread = new Thread(new ThreadStart(importXmlFileWithTransactions));
                threadStart("Importing XML file");
            }
            controlTab.SelectedIndex = 0;
        }

        /// <summary>Generates frequent sets using findFrequent method.</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            thread = new Thread(new ThreadStart(findFrequent));
            threadStart("Generating frequent sets");
        }

        /// <summary>Creates XMl file with frequent sets.</summary>
        private void createXmlFileWithFrequentSets()
        {
            xDoc = new XDocument();
            List<XElement> xSets = new List<XElement>();
            foreach (List<int> set in frequentSets)
            {
                List<XElement> xItems = new List<XElement>();
                foreach (int item in set)
                {
                    XElement xItem = new XElement("item", item.ToString());
                    xItems.Add(xItem);
                }
                XElement xSet = new XElement("set", xItems.ToArray());
                xSets.Add(xSet);
            }
            XElement xFrequent = new XElement("frequent", xSets.ToArray());
            xDoc.Add(xFrequent);
            threadStop();
        }

        /// <summary>Saves XMl file.</summary>
        private void saveXmlFileWithFrequentSets()
        {
            xDoc.Save(xExportFileName);
            threadStop();
        }

        /// <summary>Calls SaveFileDialog for saving XML file.</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frequentSets == null || frequentSets.Count == 0)
            {
                MessageBox.Show("Sorry, there are no frequents sets.");
                return;
            }
            thread = new Thread(new ThreadStart(createXmlFileWithFrequentSets));
            threadStart("Creating XML file");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML file|*.xml";
            sfd.Title = "Save frequent sets";
            sfd.ShowDialog();
            xExportFileName = sfd.FileName;
            if (xExportFileName != null && xExportFileName.Length > 0)
            {
                thread = new Thread(new ThreadStart(saveXmlFileWithFrequentSets));
                threadStart("Saving XML file");
            }
            controlTab.SelectedIndex = 1;
        }

        /// <summary>Calls SetSupportForm for retreiving user input needed to set support.</summary>
        private void setSupport()
        {
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
            threadStop();
        }

        /// <summary>Calls setSupport method.</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transactions == null || transactions.Count == 0)
            {
                MessageBox.Show("Please, firstly generate or import transactions.");
                return;
            }
            thread = new Thread(new ThreadStart(setSupport));
            threadStart("Setting support");
        }
    }
}
