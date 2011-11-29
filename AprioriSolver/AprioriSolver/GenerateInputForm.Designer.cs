namespace AprioriSolver
{
    partial class GenerateInputForm
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
            this.generateButton = new System.Windows.Forms.Button();
            this.transactionsUpDown = new System.Windows.Forms.NumericUpDown();
            this.transactionsLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.itemsUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemsInTransUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemsInTransLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsInTransUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(206, 90);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(87, 23);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // transactionsUpDown
            // 
            this.transactionsUpDown.Location = new System.Drawing.Point(206, 12);
            this.transactionsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.transactionsUpDown.Name = "transactionsUpDown";
            this.transactionsUpDown.Size = new System.Drawing.Size(87, 20);
            this.transactionsUpDown.TabIndex = 1;
            this.transactionsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.transactionsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // transactionsLabel
            // 
            this.transactionsLabel.AutoSize = true;
            this.transactionsLabel.Location = new System.Drawing.Point(12, 14);
            this.transactionsLabel.Name = "transactionsLabel";
            this.transactionsLabel.Size = new System.Drawing.Size(116, 13);
            this.transactionsLabel.TabIndex = 2;
            this.transactionsLabel.Text = "Number of transactions";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Location = new System.Drawing.Point(12, 40);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(122, 13);
            this.itemsLabel.TabIndex = 4;
            this.itemsLabel.Text = "Maximal number of items";
            // 
            // itemsUpDown
            // 
            this.itemsUpDown.Location = new System.Drawing.Point(206, 38);
            this.itemsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemsUpDown.Name = "itemsUpDown";
            this.itemsUpDown.Size = new System.Drawing.Size(87, 20);
            this.itemsUpDown.TabIndex = 3;
            this.itemsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itemsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemsInTransUpDown
            // 
            this.itemsInTransUpDown.Location = new System.Drawing.Point(206, 64);
            this.itemsInTransUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemsInTransUpDown.Name = "itemsInTransUpDown";
            this.itemsInTransUpDown.Size = new System.Drawing.Size(87, 20);
            this.itemsInTransUpDown.TabIndex = 5;
            this.itemsInTransUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.itemsInTransUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemsInTransLabel
            // 
            this.itemsInTransLabel.AutoSize = true;
            this.itemsInTransLabel.Location = new System.Drawing.Point(12, 66);
            this.itemsInTransLabel.Name = "itemsInTransLabel";
            this.itemsInTransLabel.Size = new System.Drawing.Size(188, 13);
            this.itemsInTransLabel.TabIndex = 6;
            this.itemsInTransLabel.Text = "Maximal number of items in transaction";
            // 
            // GenerateInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 120);
            this.Controls.Add(this.itemsInTransLabel);
            this.Controls.Add(this.itemsInTransUpDown);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.itemsUpDown);
            this.Controls.Add(this.transactionsLabel);
            this.Controls.Add(this.transactionsUpDown);
            this.Controls.Add(this.generateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenerateInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate transactions";
            ((System.ComponentModel.ISupportInitialize)(this.transactionsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsInTransUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.NumericUpDown transactionsUpDown;
        private System.Windows.Forms.Label transactionsLabel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.NumericUpDown itemsUpDown;
        private System.Windows.Forms.NumericUpDown itemsInTransUpDown;
        private System.Windows.Forms.Label itemsInTransLabel;
    }
}