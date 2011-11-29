namespace AprioriSolver
{
    partial class SetSupportForm
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
            this.supportLabel = new System.Windows.Forms.Label();
            this.supportUpDown = new System.Windows.Forms.NumericUpDown();
            this.setButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.supportUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // supportLabel
            // 
            this.supportLabel.AutoSize = true;
            this.supportLabel.Location = new System.Drawing.Point(12, 9);
            this.supportLabel.Name = "supportLabel";
            this.supportLabel.Size = new System.Drawing.Size(66, 13);
            this.supportLabel.TabIndex = 4;
            this.supportLabel.Text = "Support in %";
            // 
            // supportUpDown
            // 
            this.supportUpDown.Location = new System.Drawing.Point(140, 7);
            this.supportUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.supportUpDown.Name = "supportUpDown";
            this.supportUpDown.Size = new System.Drawing.Size(48, 20);
            this.supportUpDown.TabIndex = 3;
            this.supportUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.supportUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(140, 33);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(48, 23);
            this.setButton.TabIndex = 5;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // SetSupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 61);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.supportLabel);
            this.Controls.Add(this.supportUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SetSupportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Support";
            ((System.ComponentModel.ISupportInitialize)(this.supportUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label supportLabel;
        private System.Windows.Forms.NumericUpDown supportUpDown;
        private System.Windows.Forms.Button setButton;
    }
}