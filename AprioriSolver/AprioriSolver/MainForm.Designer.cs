namespace AprioriSolver
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlTab = new System.Windows.Forms.TabControl();
            this.transactionsPage = new System.Windows.Forms.TabPage();
            this.frequentPage = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressBarLabel = new System.Windows.Forms.Label();
            this.transactionsListBox = new System.Windows.Forms.ListBox();
            this.frequentListBox = new System.Windows.Forms.ListBox();
            this.setSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.controlTab.SuspendLayout();
            this.transactionsPage.SuspendLayout();
            this.frequentPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.outputToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateTransactionsToolStripMenuItem,
            this.importTransactionsToolStripMenuItem,
            this.setSupportToolStripMenuItem});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.inputToolStripMenuItem.Text = "Input";
            // 
            // generateTransactionsToolStripMenuItem
            // 
            this.generateTransactionsToolStripMenuItem.Name = "generateTransactionsToolStripMenuItem";
            this.generateTransactionsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.generateTransactionsToolStripMenuItem.Text = "Generate transactions";
            this.generateTransactionsToolStripMenuItem.Click += new System.EventHandler(this.generateTransactionsToolStripMenuItem_Click);
            // 
            // importTransactionsToolStripMenuItem
            // 
            this.importTransactionsToolStripMenuItem.Name = "importTransactionsToolStripMenuItem";
            this.importTransactionsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.importTransactionsToolStripMenuItem.Text = "Import transactions";
            this.importTransactionsToolStripMenuItem.Click += new System.EventHandler(this.importTransactionsToolStripMenuItem_Click);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateOutputToolStripMenuItem,
            this.exportOutputToolStripMenuItem});
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.outputToolStripMenuItem.Text = "Output";
            // 
            // generateOutputToolStripMenuItem
            // 
            this.generateOutputToolStripMenuItem.Name = "generateOutputToolStripMenuItem";
            this.generateOutputToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.generateOutputToolStripMenuItem.Text = "Generate output";
            this.generateOutputToolStripMenuItem.Click += new System.EventHandler(this.generateOutputToolStripMenuItem_Click);
            // 
            // exportOutputToolStripMenuItem
            // 
            this.exportOutputToolStripMenuItem.Name = "exportOutputToolStripMenuItem";
            this.exportOutputToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportOutputToolStripMenuItem.Text = "Export output";
            this.exportOutputToolStripMenuItem.Click += new System.EventHandler(this.exportOutputToolStripMenuItem_Click);
            // 
            // controlTab
            // 
            this.controlTab.Controls.Add(this.transactionsPage);
            this.controlTab.Controls.Add(this.frequentPage);
            this.controlTab.Location = new System.Drawing.Point(12, 27);
            this.controlTab.Name = "controlTab";
            this.controlTab.SelectedIndex = 0;
            this.controlTab.Size = new System.Drawing.Size(370, 493);
            this.controlTab.TabIndex = 4;
            // 
            // transactionsPage
            // 
            this.transactionsPage.Controls.Add(this.transactionsListBox);
            this.transactionsPage.Location = new System.Drawing.Point(4, 22);
            this.transactionsPage.Name = "transactionsPage";
            this.transactionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.transactionsPage.Size = new System.Drawing.Size(362, 467);
            this.transactionsPage.TabIndex = 0;
            this.transactionsPage.Text = "Transactions";
            this.transactionsPage.UseVisualStyleBackColor = true;
            // 
            // frequentPage
            // 
            this.frequentPage.Controls.Add(this.frequentListBox);
            this.frequentPage.Location = new System.Drawing.Point(4, 22);
            this.frequentPage.Name = "frequentPage";
            this.frequentPage.Padding = new System.Windows.Forms.Padding(3);
            this.frequentPage.Size = new System.Drawing.Size(362, 467);
            this.frequentPage.TabIndex = 1;
            this.frequentPage.Text = "Frequent sets";
            this.frequentPage.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 550);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(370, 10);
            this.progressBar.TabIndex = 5;
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.AutoSize = true;
            this.progressBarLabel.Location = new System.Drawing.Point(13, 534);
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.Size = new System.Drawing.Size(0, 13);
            this.progressBarLabel.TabIndex = 6;
            // 
            // transactionsListBox
            // 
            this.transactionsListBox.FormattingEnabled = true;
            this.transactionsListBox.Location = new System.Drawing.Point(3, 3);
            this.transactionsListBox.Name = "transactionsListBox";
            this.transactionsListBox.Size = new System.Drawing.Size(356, 459);
            this.transactionsListBox.TabIndex = 0;
            // 
            // frequentListBox
            // 
            this.frequentListBox.FormattingEnabled = true;
            this.frequentListBox.Location = new System.Drawing.Point(3, 3);
            this.frequentListBox.Name = "frequentListBox";
            this.frequentListBox.Size = new System.Drawing.Size(356, 459);
            this.frequentListBox.TabIndex = 0;
            // 
            // setSupportToolStripMenuItem
            // 
            this.setSupportToolStripMenuItem.Name = "setSupportToolStripMenuItem";
            this.setSupportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.setSupportToolStripMenuItem.Text = "Set support";
            this.setSupportToolStripMenuItem.Click += new System.EventHandler(this.setSupportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 572);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.controlTab);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Data Mining";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlTab.ResumeLayout(false);
            this.transactionsPage.ResumeLayout(false);
            this.frequentPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportOutputToolStripMenuItem;
        private System.Windows.Forms.TabControl controlTab;
        private System.Windows.Forms.TabPage transactionsPage;
        private System.Windows.Forms.TabPage frequentPage;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressBarLabel;
        private System.Windows.Forms.ListBox transactionsListBox;
        private System.Windows.Forms.ListBox frequentListBox;
        private System.Windows.Forms.ToolStripMenuItem setSupportToolStripMenuItem;
    }
}

