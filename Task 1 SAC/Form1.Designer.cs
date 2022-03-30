namespace Task_1_SAC
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.purchasePriceNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.endQuoteButton = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasePriceNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "How old is the textbook?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "How much did you pay for it?";
            // 
            // ageNumUpDown
            // 
            this.ageNumUpDown.Location = new System.Drawing.Point(46, 95);
            this.ageNumUpDown.Name = "ageNumUpDown";
            this.ageNumUpDown.Size = new System.Drawing.Size(250, 29);
            this.ageNumUpDown.TabIndex = 2;
            // 
            // purchasePriceNumUpDown
            // 
            this.purchasePriceNumUpDown.Location = new System.Drawing.Point(46, 216);
            this.purchasePriceNumUpDown.Name = "purchasePriceNumUpDown";
            this.purchasePriceNumUpDown.Size = new System.Drawing.Size(250, 29);
            this.purchasePriceNumUpDown.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(46, 271);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 50);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // endQuoteButton
            // 
            this.endQuoteButton.Location = new System.Drawing.Point(359, 271);
            this.endQuoteButton.Name = "endQuoteButton";
            this.endQuoteButton.Size = new System.Drawing.Size(150, 50);
            this.endQuoteButton.TabIndex = 6;
            this.endQuoteButton.Text = "End quote";
            this.endQuoteButton.UseVisualStyleBackColor = true;
            this.endQuoteButton.Click += new System.EventHandler(this.endQuoteButton_Click);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(41, 535);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(288, 25);
            this.valueLabel.TabIndex = 7;
            this.valueLabel.Text = "";
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(46, 346);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(64, 25);
            this.hintLabel.TabIndex = 8;
            this.hintLabel.Text = "Enter book(s) details for a quote";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 732);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.endQuoteButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.purchasePriceNumUpDown);
            this.Controls.Add(this.ageNumUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasePriceNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ageNumUpDown;
        private System.Windows.Forms.NumericUpDown purchasePriceNumUpDown;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button endQuoteButton;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label hintLabel;
    }
}

