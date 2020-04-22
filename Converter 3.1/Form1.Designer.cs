namespace Converter_3._1
{
    partial class converterForm
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
            this.convertPanel = new System.Windows.Forms.Panel();
            this.rupeesRadioButton = new System.Windows.Forms.RadioButton();
            this.eurosRadioButton = new System.Windows.Forms.RadioButton();
            this.dollarsRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.poundsTextBox = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.convertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertPanel
            // 
            this.convertPanel.Controls.Add(this.rupeesRadioButton);
            this.convertPanel.Controls.Add(this.eurosRadioButton);
            this.convertPanel.Controls.Add(this.dollarsRadioButton);
            this.convertPanel.Location = new System.Drawing.Point(553, 33);
            this.convertPanel.Name = "convertPanel";
            this.convertPanel.Size = new System.Drawing.Size(200, 296);
            this.convertPanel.TabIndex = 0;
            // 
            // rupeesRadioButton
            // 
            this.rupeesRadioButton.AutoSize = true;
            this.rupeesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rupeesRadioButton.Location = new System.Drawing.Point(46, 220);
            this.rupeesRadioButton.Name = "rupeesRadioButton";
            this.rupeesRadioButton.Size = new System.Drawing.Size(100, 29);
            this.rupeesRadioButton.TabIndex = 2;
            this.rupeesRadioButton.TabStop = true;
            this.rupeesRadioButton.Text = "Rupees";
            this.rupeesRadioButton.UseVisualStyleBackColor = true;
            this.rupeesRadioButton.CheckedChanged += new System.EventHandler(this.rupeesConversion);
            // 
            // eurosRadioButton
            // 
            this.eurosRadioButton.AutoSize = true;
            this.eurosRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eurosRadioButton.Location = new System.Drawing.Point(46, 136);
            this.eurosRadioButton.Name = "eurosRadioButton";
            this.eurosRadioButton.Size = new System.Drawing.Size(84, 29);
            this.eurosRadioButton.TabIndex = 1;
            this.eurosRadioButton.TabStop = true;
            this.eurosRadioButton.Text = "Euros";
            this.eurosRadioButton.UseVisualStyleBackColor = true;
            this.eurosRadioButton.CheckedChanged += new System.EventHandler(this.eurosConversion);
            // 
            // dollarsRadioButton
            // 
            this.dollarsRadioButton.AutoSize = true;
            this.dollarsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarsRadioButton.Location = new System.Drawing.Point(46, 51);
            this.dollarsRadioButton.Name = "dollarsRadioButton";
            this.dollarsRadioButton.Size = new System.Drawing.Size(93, 29);
            this.dollarsRadioButton.TabIndex = 0;
            this.dollarsRadioButton.TabStop = true;
            this.dollarsRadioButton.Text = "Dollars";
            this.dollarsRadioButton.UseVisualStyleBackColor = true;
            this.dollarsRadioButton.CheckedChanged += new System.EventHandler(this.dollarsConversion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "UK Pounds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Converted Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Currency Converter";
            // 
            // convertedLabel
            // 
            this.convertedLabel.AutoSize = true;
            this.convertedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedLabel.Location = new System.Drawing.Point(236, 248);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(176, 25);
            this.convertedLabel.TabIndex = 4;
            this.convertedLabel.Text = "Output Conversion";
            // 
            // poundsTextBox
            // 
            this.poundsTextBox.Location = new System.Drawing.Point(241, 160);
            this.poundsTextBox.Name = "poundsTextBox";
            this.poundsTextBox.Size = new System.Drawing.Size(221, 22);
            this.poundsTextBox.TabIndex = 5;
            this.poundsTextBox.Text = "0";
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(590, 359);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(135, 53);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.closeConverter);
            // 
            // converterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.poundsTextBox);
            this.Controls.Add(this.convertedLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertPanel);
            this.Name = "converterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert Pounds to Foreign Currency";
            this.convertPanel.ResumeLayout(false);
            this.convertPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel convertPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.TextBox poundsTextBox;
        private System.Windows.Forms.RadioButton rupeesRadioButton;
        private System.Windows.Forms.RadioButton eurosRadioButton;
        private System.Windows.Forms.RadioButton dollarsRadioButton;
        private System.Windows.Forms.Button quitButton;
    }
}

