namespace MaximumAndMinimum
{
    partial class MaxMinForm
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
            this.numberAreaGroupBox = new System.Windows.Forms.GroupBox();
            this.fifthNumberTextBox = new System.Windows.Forms.TextBox();
            this.fourthNumberTextBox = new System.Windows.Forms.TextBox();
            this.thiredNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.fifthNumberLabel = new System.Windows.Forms.Label();
            this.fourthNumberLabel = new System.Windows.Forms.Label();
            this.thiredNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.firstNumberlabel = new System.Windows.Forms.Label();
            this.maximumButton = new System.Windows.Forms.Button();
            this.minimumButton = new System.Windows.Forms.Button();
            this.meximumLabel = new System.Windows.Forms.Label();
            this.minimumLabel = new System.Windows.Forms.Label();
            this.numberAreaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberAreaGroupBox
            // 
            this.numberAreaGroupBox.Controls.Add(this.fifthNumberTextBox);
            this.numberAreaGroupBox.Controls.Add(this.fourthNumberTextBox);
            this.numberAreaGroupBox.Controls.Add(this.thiredNumberTextBox);
            this.numberAreaGroupBox.Controls.Add(this.secondNumberTextBox);
            this.numberAreaGroupBox.Controls.Add(this.firstNumberTextBox);
            this.numberAreaGroupBox.Controls.Add(this.fifthNumberLabel);
            this.numberAreaGroupBox.Controls.Add(this.fourthNumberLabel);
            this.numberAreaGroupBox.Controls.Add(this.thiredNumberLabel);
            this.numberAreaGroupBox.Controls.Add(this.secondNumberLabel);
            this.numberAreaGroupBox.Controls.Add(this.firstNumberlabel);
            this.numberAreaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.numberAreaGroupBox.Name = "numberAreaGroupBox";
            this.numberAreaGroupBox.Size = new System.Drawing.Size(429, 236);
            this.numberAreaGroupBox.TabIndex = 0;
            this.numberAreaGroupBox.TabStop = false;
            this.numberAreaGroupBox.Text = "Input Number Area";
            // 
            // fifthNumberTextBox
            // 
            this.fifthNumberTextBox.Location = new System.Drawing.Point(150, 189);
            this.fifthNumberTextBox.Name = "fifthNumberTextBox";
            this.fifthNumberTextBox.Size = new System.Drawing.Size(208, 20);
            this.fifthNumberTextBox.TabIndex = 6;
            // 
            // fourthNumberTextBox
            // 
            this.fourthNumberTextBox.Location = new System.Drawing.Point(150, 149);
            this.fourthNumberTextBox.Name = "fourthNumberTextBox";
            this.fourthNumberTextBox.Size = new System.Drawing.Size(208, 20);
            this.fourthNumberTextBox.TabIndex = 6;
            // 
            // thiredNumberTextBox
            // 
            this.thiredNumberTextBox.Location = new System.Drawing.Point(150, 108);
            this.thiredNumberTextBox.Name = "thiredNumberTextBox";
            this.thiredNumberTextBox.Size = new System.Drawing.Size(208, 20);
            this.thiredNumberTextBox.TabIndex = 6;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(150, 71);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(208, 20);
            this.secondNumberTextBox.TabIndex = 6;
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(150, 35);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(208, 20);
            this.firstNumberTextBox.TabIndex = 6;
            // 
            // fifthNumberLabel
            // 
            this.fifthNumberLabel.AutoSize = true;
            this.fifthNumberLabel.Location = new System.Drawing.Point(58, 193);
            this.fifthNumberLabel.Name = "fifthNumberLabel";
            this.fifthNumberLabel.Size = new System.Drawing.Size(62, 13);
            this.fifthNumberLabel.TabIndex = 5;
            this.fifthNumberLabel.Text = "5th Number";
            // 
            // fourthNumberLabel
            // 
            this.fourthNumberLabel.AutoSize = true;
            this.fourthNumberLabel.Location = new System.Drawing.Point(58, 153);
            this.fourthNumberLabel.Name = "fourthNumberLabel";
            this.fourthNumberLabel.Size = new System.Drawing.Size(62, 13);
            this.fourthNumberLabel.TabIndex = 5;
            this.fourthNumberLabel.Text = "4th Number";
            // 
            // thiredNumberLabel
            // 
            this.thiredNumberLabel.AutoSize = true;
            this.thiredNumberLabel.Location = new System.Drawing.Point(58, 112);
            this.thiredNumberLabel.Name = "thiredNumberLabel";
            this.thiredNumberLabel.Size = new System.Drawing.Size(62, 13);
            this.thiredNumberLabel.TabIndex = 4;
            this.thiredNumberLabel.Text = "3rd Number";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Location = new System.Drawing.Point(55, 75);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(65, 13);
            this.secondNumberLabel.TabIndex = 3;
            this.secondNumberLabel.Text = "2nd Number";
            // 
            // firstNumberlabel
            // 
            this.firstNumberlabel.AutoSize = true;
            this.firstNumberlabel.Location = new System.Drawing.Point(59, 39);
            this.firstNumberlabel.Name = "firstNumberlabel";
            this.firstNumberlabel.Size = new System.Drawing.Size(61, 13);
            this.firstNumberlabel.TabIndex = 2;
            this.firstNumberlabel.Text = "1st Number";
            // 
            // maximumButton
            // 
            this.maximumButton.Location = new System.Drawing.Point(127, 307);
            this.maximumButton.Name = "maximumButton";
            this.maximumButton.Size = new System.Drawing.Size(75, 41);
            this.maximumButton.TabIndex = 1;
            this.maximumButton.Text = "Maximum";
            this.maximumButton.UseVisualStyleBackColor = true;
            this.maximumButton.Click += new System.EventHandler(this.maximumButton_Click);
            // 
            // minimumButton
            // 
            this.minimumButton.Location = new System.Drawing.Point(266, 307);
            this.minimumButton.Name = "minimumButton";
            this.minimumButton.Size = new System.Drawing.Size(75, 41);
            this.minimumButton.TabIndex = 1;
            this.minimumButton.Text = "Minimum";
            this.minimumButton.UseVisualStyleBackColor = true;
            this.minimumButton.Click += new System.EventHandler(this.minimumButton_Click);
            // 
            // meximumLabel
            // 
            this.meximumLabel.AutoSize = true;
            this.meximumLabel.Location = new System.Drawing.Point(42, 272);
            this.meximumLabel.Name = "meximumLabel";
            this.meximumLabel.Size = new System.Drawing.Size(0, 13);
            this.meximumLabel.TabIndex = 2;
            // 
            // minimumLabel
            // 
            this.minimumLabel.AutoSize = true;
            this.minimumLabel.Location = new System.Drawing.Point(240, 272);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(0, 13);
            this.minimumLabel.TabIndex = 2;
            // 
            // MaxMinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 369);
            this.Controls.Add(this.minimumLabel);
            this.Controls.Add(this.meximumLabel);
            this.Controls.Add(this.minimumButton);
            this.Controls.Add(this.maximumButton);
            this.Controls.Add(this.numberAreaGroupBox);
            this.Name = "MaxMinForm";
            this.Text = "Maximum Minimum Application";
            this.numberAreaGroupBox.ResumeLayout(false);
            this.numberAreaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox numberAreaGroupBox;
        private System.Windows.Forms.Label fifthNumberLabel;
        private System.Windows.Forms.Label fourthNumberLabel;
        private System.Windows.Forms.Label thiredNumberLabel;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.Label firstNumberlabel;
        private System.Windows.Forms.TextBox fifthNumberTextBox;
        private System.Windows.Forms.TextBox fourthNumberTextBox;
        private System.Windows.Forms.TextBox thiredNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.Button maximumButton;
        private System.Windows.Forms.Button minimumButton;
        private System.Windows.Forms.Label meximumLabel;
        private System.Windows.Forms.Label minimumLabel;

    }
}

