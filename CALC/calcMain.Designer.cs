namespace CALC
{
    partial class calcMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            equalButton = new Button();
            plusButton = new Button();
            minusButton = new Button();
            subsButton = new Button();
            divButon = new Button();
            dotButton = new Button();
            threeButton = new Button();
            sixButton = new Button();
            nineButton = new Button();
            percentButton = new Button();
            twoButton = new Button();
            fiveButton = new Button();
            eightButton = new Button();
            button10 = new Button();
            zeroButton = new Button();
            oneButton = new Button();
            fourButton = new Button();
            sevenButton = new Button();
            clearButton = new Button();
            textBoxDisplay = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(equalButton);
            groupBox2.Controls.Add(plusButton);
            groupBox2.Controls.Add(minusButton);
            groupBox2.Controls.Add(subsButton);
            groupBox2.Controls.Add(divButon);
            groupBox2.Controls.Add(dotButton);
            groupBox2.Controls.Add(threeButton);
            groupBox2.Controls.Add(sixButton);
            groupBox2.Controls.Add(nineButton);
            groupBox2.Controls.Add(percentButton);
            groupBox2.Controls.Add(twoButton);
            groupBox2.Controls.Add(fiveButton);
            groupBox2.Controls.Add(eightButton);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(zeroButton);
            groupBox2.Controls.Add(oneButton);
            groupBox2.Controls.Add(fourButton);
            groupBox2.Controls.Add(sevenButton);
            groupBox2.Controls.Add(clearButton);
            groupBox2.Location = new Point(0, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 384);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inputs";
            // 
            // equalButton
            // 
            equalButton.Location = new Point(246, 299);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(75, 64);
            equalButton.TabIndex = 19;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = true;
            equalButton.Click += EqualClick;
            // 
            // plusButton
            // 
            plusButton.Location = new Point(246, 229);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(75, 64);
            plusButton.TabIndex = 18;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += OperatorClick;
            // 
            // minusButton
            // 
            minusButton.Location = new Point(246, 159);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(75, 64);
            minusButton.TabIndex = 17;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += OperatorClick;
            // 
            // subsButton
            // 
            subsButton.Location = new Point(246, 89);
            subsButton.Name = "subsButton";
            subsButton.Size = new Size(75, 64);
            subsButton.TabIndex = 16;
            subsButton.Text = "x";
            subsButton.UseVisualStyleBackColor = true;
            subsButton.Click += OperatorClick;
            // 
            // divButon
            // 
            divButon.Location = new Point(246, 19);
            divButon.Name = "divButon";
            divButon.Size = new Size(75, 64);
            divButon.TabIndex = 15;
            divButon.Text = "/";
            divButon.UseVisualStyleBackColor = true;
            divButon.Click += OperatorClick;
            // 
            // dotButton
            // 
            dotButton.Location = new Point(165, 299);
            dotButton.Name = "dotButton";
            dotButton.Size = new Size(75, 64);
            dotButton.TabIndex = 14;
            dotButton.Text = ".";
            dotButton.UseVisualStyleBackColor = true;
            // 
            // threeButton
            // 
            threeButton.Location = new Point(165, 229);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(75, 64);
            threeButton.TabIndex = 13;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            threeButton.Click += NumberClick;
            // 
            // sixButton
            // 
            sixButton.Location = new Point(165, 159);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(75, 64);
            sixButton.TabIndex = 12;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            sixButton.Click += NumberClick;
            // 
            // nineButton
            // 
            nineButton.Location = new Point(165, 89);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(75, 64);
            nineButton.TabIndex = 11;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            nineButton.Click += NumberClick;
            // 
            // percentButton
            // 
            percentButton.Location = new Point(165, 19);
            percentButton.Name = "percentButton";
            percentButton.Size = new Size(75, 64);
            percentButton.TabIndex = 10;
            percentButton.Text = "%";
            percentButton.UseVisualStyleBackColor = true;
            // 
            // twoButton
            // 
            twoButton.Location = new Point(84, 229);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(75, 64);
            twoButton.TabIndex = 8;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            twoButton.Click += NumberClick;
            // 
            // fiveButton
            // 
            fiveButton.Location = new Point(84, 159);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(75, 64);
            fiveButton.TabIndex = 7;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            fiveButton.Click += NumberClick;
            // 
            // eightButton
            // 
            eightButton.Location = new Point(84, 89);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(75, 64);
            eightButton.TabIndex = 6;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            eightButton.Click += NumberClick;
            // 
            // button10
            // 
            button10.Location = new Point(84, 19);
            button10.Name = "button10";
            button10.Size = new Size(75, 64);
            button10.TabIndex = 5;
            button10.Text = "+/-";
            button10.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            zeroButton.Location = new Point(3, 299);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(156, 64);
            zeroButton.TabIndex = 4;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.Click += NumberClick;
            // 
            // oneButton
            // 
            oneButton.Location = new Point(3, 229);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(75, 64);
            oneButton.TabIndex = 3;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            oneButton.Click += NumberClick;
            // 
            // fourButton
            // 
            fourButton.Location = new Point(3, 159);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(75, 64);
            fourButton.TabIndex = 2;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            fourButton.Click += NumberClick;
            // 
            // sevenButton
            // 
            sevenButton.Location = new Point(3, 89);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(75, 64);
            sevenButton.TabIndex = 1;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            sevenButton.Click += NumberClick;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(3, 19);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 64);
            clearButton.TabIndex = 0;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearClick;
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.BackColor = SystemColors.MenuBar;
            textBoxDisplay.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDisplay.Location = new Point(3, 4);
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.Size = new Size(318, 93);
            textBoxDisplay.TabIndex = 0;
            textBoxDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // calcMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 448);
            Controls.Add(textBoxDisplay);
            Controls.Add(groupBox2);
            Name = "calcMain";
            Text = "CALC";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private Button equalButton;
        private Button plusButton;
        private Button minusButton;
        private Button subsButton;
        private Button divButon;
        private Button dotButton;
        private Button threeButton;
        private Button sixButton;
        private Button nineButton;
        private Button percentButton;
        private Button twoButton;
        private Button fiveButton;
        private Button eightButton;
        private Button button10;
        private Button zeroButton;
        private Button oneButton;
        private Button fourButton;
        private Button sevenButton;
        private Button clearButton;
        private TextBox textBoxDisplay;
    }
}
