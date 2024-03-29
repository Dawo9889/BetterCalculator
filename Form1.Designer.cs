namespace BetterCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.clearAllDataButton = new System.Windows.Forms.Button();
            this.clearTextBox = new System.Windows.Forms.Button();
            this.removeSingleDigit = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.numericButton7 = new System.Windows.Forms.Button();
            this.numericButton8 = new System.Windows.Forms.Button();
            this.numericButton9 = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.numericButton4 = new System.Windows.Forms.Button();
            this.numericButton5 = new System.Windows.Forms.Button();
            this.numericButton6 = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.numericButton1 = new System.Windows.Forms.Button();
            this.numericButton2 = new System.Windows.Forms.Button();
            this.numericButton3 = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.equalsButon = new System.Windows.Forms.Button();
            this.commaButton = new System.Windows.Forms.Button();
            this.numericButton0 = new System.Windows.Forms.Button();
            this.inverseButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultTextBox.Location = new System.Drawing.Point(1, 33);
            this.resultTextBox.MaxLength = 5;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ShortcutsEnabled = false;
            this.resultTextBox.Size = new System.Drawing.Size(298, 47);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "0";
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearAllDataButton
            // 
            this.clearAllDataButton.Location = new System.Drawing.Point(0, 0);
            this.clearAllDataButton.Name = "clearAllDataButton";
            this.clearAllDataButton.Size = new System.Drawing.Size(70, 50);
            this.clearAllDataButton.TabIndex = 2;
            this.clearAllDataButton.Text = "C";
            this.clearAllDataButton.UseVisualStyleBackColor = true;
            this.clearAllDataButton.Click += new System.EventHandler(this.clearAllDataButton_Click);
            // 
            // clearTextBox
            // 
            this.clearTextBox.Location = new System.Drawing.Point(76, 0);
            this.clearTextBox.Name = "clearTextBox";
            this.clearTextBox.Size = new System.Drawing.Size(70, 50);
            this.clearTextBox.TabIndex = 3;
            this.clearTextBox.Text = "CE";
            this.clearTextBox.UseVisualStyleBackColor = true;
            this.clearTextBox.Click += new System.EventHandler(this.clearTextBox_Click);
            // 
            // removeSingleDigit
            // 
            this.removeSingleDigit.Location = new System.Drawing.Point(152, 0);
            this.removeSingleDigit.Name = "removeSingleDigit";
            this.removeSingleDigit.Size = new System.Drawing.Size(70, 50);
            this.removeSingleDigit.TabIndex = 4;
            this.removeSingleDigit.Text = "<--";
            this.removeSingleDigit.UseVisualStyleBackColor = true;
            this.removeSingleDigit.Click += new System.EventHandler(this.removeSingleDigit_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(1, 6);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 24);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericButton7
            // 
            this.numericButton7.Location = new System.Drawing.Point(0, 56);
            this.numericButton7.Name = "numericButton7";
            this.numericButton7.Size = new System.Drawing.Size(70, 50);
            this.numericButton7.TabIndex = 6;
            this.numericButton7.Text = "7";
            this.numericButton7.UseVisualStyleBackColor = true;
            this.numericButton7.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // numericButton8
            // 
            this.numericButton8.Location = new System.Drawing.Point(76, 56);
            this.numericButton8.Name = "numericButton8";
            this.numericButton8.Size = new System.Drawing.Size(70, 50);
            this.numericButton8.TabIndex = 7;
            this.numericButton8.Text = "8";
            this.numericButton8.UseVisualStyleBackColor = true;
            this.numericButton8.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // numericButton9
            // 
            this.numericButton9.Location = new System.Drawing.Point(152, 56);
            this.numericButton9.Name = "numericButton9";
            this.numericButton9.Size = new System.Drawing.Size(70, 50);
            this.numericButton9.TabIndex = 8;
            this.numericButton9.Text = "9";
            this.numericButton9.UseVisualStyleBackColor = true;
            this.numericButton9.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(228, 0);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(70, 50);
            this.divideButton.TabIndex = 9;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // numericButton4
            // 
            this.numericButton4.Location = new System.Drawing.Point(0, 112);
            this.numericButton4.Name = "numericButton4";
            this.numericButton4.Size = new System.Drawing.Size(70, 50);
            this.numericButton4.TabIndex = 10;
            this.numericButton4.Text = "4";
            this.numericButton4.UseVisualStyleBackColor = true;
            this.numericButton4.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // numericButton5
            // 
            this.numericButton5.Location = new System.Drawing.Point(76, 112);
            this.numericButton5.Name = "numericButton5";
            this.numericButton5.Size = new System.Drawing.Size(70, 50);
            this.numericButton5.TabIndex = 11;
            this.numericButton5.Text = "5";
            this.numericButton5.UseVisualStyleBackColor = true;
            this.numericButton5.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // numericButton6
            // 
            this.numericButton6.Location = new System.Drawing.Point(152, 112);
            this.numericButton6.Name = "numericButton6";
            this.numericButton6.Size = new System.Drawing.Size(70, 50);
            this.numericButton6.TabIndex = 12;
            this.numericButton6.Text = "6";
            this.numericButton6.UseVisualStyleBackColor = true;
            this.numericButton6.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(228, 112);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(70, 50);
            this.minusButton.TabIndex = 13;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // numericButton1
            // 
            this.numericButton1.Location = new System.Drawing.Point(0, 168);
            this.numericButton1.Name = "numericButton1";
            this.numericButton1.Size = new System.Drawing.Size(70, 50);
            this.numericButton1.TabIndex = 14;
            this.numericButton1.Text = "1";
            this.numericButton1.UseVisualStyleBackColor = true;
            this.numericButton1.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // numericButton2
            // 
            this.numericButton2.Location = new System.Drawing.Point(76, 168);
            this.numericButton2.Name = "numericButton2";
            this.numericButton2.Size = new System.Drawing.Size(70, 50);
            this.numericButton2.TabIndex = 15;
            this.numericButton2.Text = "2";
            this.numericButton2.UseVisualStyleBackColor = true;
            this.numericButton2.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // numericButton3
            // 
            this.numericButton3.Location = new System.Drawing.Point(152, 168);
            this.numericButton3.Name = "numericButton3";
            this.numericButton3.Size = new System.Drawing.Size(70, 50);
            this.numericButton3.TabIndex = 16;
            this.numericButton3.Text = "3";
            this.numericButton3.UseVisualStyleBackColor = true;
            this.numericButton3.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(228, 168);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(70, 50);
            this.plusButton.TabIndex = 17;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // equalsButon
            // 
            this.equalsButon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.equalsButon.Location = new System.Drawing.Point(228, 224);
            this.equalsButon.Name = "equalsButon";
            this.equalsButon.Size = new System.Drawing.Size(70, 50);
            this.equalsButon.TabIndex = 18;
            this.equalsButon.Text = "=";
            this.equalsButon.UseVisualStyleBackColor = false;
            this.equalsButon.Click += new System.EventHandler(this.equalsButon_Click);
            // 
            // commaButton
            // 
            this.commaButton.Location = new System.Drawing.Point(152, 224);
            this.commaButton.Name = "commaButton";
            this.commaButton.Size = new System.Drawing.Size(70, 50);
            this.commaButton.TabIndex = 19;
            this.commaButton.Text = ",";
            this.commaButton.UseVisualStyleBackColor = true;
            this.commaButton.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // numericButton0
            // 
            this.numericButton0.Location = new System.Drawing.Point(76, 224);
            this.numericButton0.Name = "numericButton0";
            this.numericButton0.Size = new System.Drawing.Size(70, 50);
            this.numericButton0.TabIndex = 20;
            this.numericButton0.Text = "0";
            this.numericButton0.UseVisualStyleBackColor = true;
            this.numericButton0.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // inverseButton
            // 
            this.inverseButton.Location = new System.Drawing.Point(0, 224);
            this.inverseButton.Name = "inverseButton";
            this.inverseButton.Size = new System.Drawing.Size(70, 50);
            this.inverseButton.TabIndex = 21;
            this.inverseButton.Text = "+/-";
            this.inverseButton.UseVisualStyleBackColor = true;
            this.inverseButton.Click += new System.EventHandler(this.inverseButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(228, 56);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(70, 50);
            this.multiplyButton.TabIndex = 22;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.multiplyButton);
            this.groupBox1.Controls.Add(this.inverseButton);
            this.groupBox1.Controls.Add(this.numericButton0);
            this.groupBox1.Controls.Add(this.commaButton);
            this.groupBox1.Controls.Add(this.equalsButon);
            this.groupBox1.Controls.Add(this.plusButton);
            this.groupBox1.Controls.Add(this.numericButton3);
            this.groupBox1.Controls.Add(this.numericButton2);
            this.groupBox1.Controls.Add(this.numericButton1);
            this.groupBox1.Controls.Add(this.minusButton);
            this.groupBox1.Controls.Add(this.numericButton6);
            this.groupBox1.Controls.Add(this.numericButton5);
            this.groupBox1.Controls.Add(this.numericButton4);
            this.groupBox1.Controls.Add(this.divideButton);
            this.groupBox1.Controls.Add(this.numericButton9);
            this.groupBox1.Controls.Add(this.numericButton8);
            this.groupBox1.Controls.Add(this.numericButton7);
            this.groupBox1.Controls.Add(this.removeSingleDigit);
            this.groupBox1.Controls.Add(this.clearTextBox);
            this.groupBox1.Controls.Add(this.clearAllDataButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(1, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 276);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button clearAllDataButton;
        private System.Windows.Forms.Button clearTextBox;
        private System.Windows.Forms.Button removeSingleDigit;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button numericButton7;
        private System.Windows.Forms.Button numericButton8;
        private System.Windows.Forms.Button numericButton9;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button numericButton4;
        private System.Windows.Forms.Button numericButton5;
        private System.Windows.Forms.Button numericButton6;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button numericButton1;
        private System.Windows.Forms.Button numericButton2;
        private System.Windows.Forms.Button numericButton3;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button equalsButon;
        private System.Windows.Forms.Button commaButton;
        private System.Windows.Forms.Button numericButton0;
        private System.Windows.Forms.Button inverseButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

