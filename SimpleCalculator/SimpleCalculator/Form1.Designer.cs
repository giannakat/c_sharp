namespace SimpleCalculator
{
    partial class Calculator
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            buttonDot = new Button();
            buttonEquals = new Button();
            buttonAC = new Button();
            buttonPlsMns = new Button();
            buttonModulo = new Button();
            buttonDivide = new Button();
            buttonMultiply = new Button();
            buttonMinus = new Button();
            buttonPlus = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 25F);
            textBox1.Location = new Point(12, 21);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(298, 52);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(12, 158);
            button1.Name = "button1";
            button1.Size = new Size(70, 60);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(88, 158);
            button2.Name = "button2";
            button2.Size = new Size(70, 60);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HighlightText;
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(164, 158);
            button3.Name = "button3";
            button3.Size = new Size(70, 60);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HighlightText;
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(12, 224);
            button4.Name = "button4";
            button4.Size = new Size(70, 60);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HighlightText;
            button5.Font = new Font("Segoe UI", 20F);
            button5.Location = new Point(88, 224);
            button5.Name = "button5";
            button5.Size = new Size(70, 60);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.HighlightText;
            button6.Font = new Font("Segoe UI", 20F);
            button6.Location = new Point(164, 224);
            button6.Name = "button6";
            button6.Size = new Size(70, 60);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.HighlightText;
            button7.Font = new Font("Segoe UI", 20F);
            button7.Location = new Point(12, 290);
            button7.Name = "button7";
            button7.Size = new Size(70, 60);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.HighlightText;
            button8.Font = new Font("Segoe UI", 20F);
            button8.Location = new Point(88, 290);
            button8.Name = "button8";
            button8.Size = new Size(70, 60);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.HighlightText;
            button9.Font = new Font("Segoe UI", 20F);
            button9.Location = new Point(164, 290);
            button9.Name = "button9";
            button9.Size = new Size(70, 60);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += NumberButton_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.HighlightText;
            button10.Font = new Font("Segoe UI", 20F);
            button10.Location = new Point(12, 356);
            button10.Name = "button10";
            button10.Size = new Size(70, 60);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            button10.Click += NumberButton_Click;
            // 
            // buttonDot
            // 
            buttonDot.BackColor = SystemColors.HighlightText;
            buttonDot.Font = new Font("Segoe UI", 20F);
            buttonDot.Location = new Point(88, 356);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(70, 60);
            buttonDot.TabIndex = 11;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = SystemColors.HighlightText;
            buttonEquals.Font = new Font("Segoe UI", 20F);
            buttonEquals.Location = new Point(164, 356);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(146, 60);
            buttonEquals.TabIndex = 12;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonAC
            // 
            buttonAC.BackColor = SystemColors.HighlightText;
            buttonAC.Font = new Font("Segoe UI", 20F);
            buttonAC.Location = new Point(12, 92);
            buttonAC.Name = "buttonAC";
            buttonAC.Size = new Size(70, 60);
            buttonAC.TabIndex = 13;
            buttonAC.Text = "AC";
            buttonAC.UseVisualStyleBackColor = false;
            buttonAC.Click += buttonAC_Click;
            // 
            // buttonPlsMns
            // 
            buttonPlsMns.BackColor = SystemColors.HighlightText;
            buttonPlsMns.Font = new Font("Segoe UI", 20F);
            buttonPlsMns.Location = new Point(88, 92);
            buttonPlsMns.Name = "buttonPlsMns";
            buttonPlsMns.Size = new Size(70, 60);
            buttonPlsMns.TabIndex = 14;
            buttonPlsMns.Text = "Del";
            buttonPlsMns.UseVisualStyleBackColor = false;
            buttonPlsMns.Click += buttonDel;
            // 
            // buttonModulo
            // 
            buttonModulo.BackColor = SystemColors.HighlightText;
            buttonModulo.Font = new Font("Segoe UI", 20F);
            buttonModulo.Location = new Point(164, 92);
            buttonModulo.Name = "buttonModulo";
            buttonModulo.Size = new Size(70, 60);
            buttonModulo.TabIndex = 15;
            buttonModulo.Text = "%";
            buttonModulo.UseVisualStyleBackColor = false;
            buttonModulo.Click += buttonModulo_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.HighlightText;
            buttonDivide.Font = new Font("Segoe UI", 20F);
            buttonDivide.Location = new Point(240, 92);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(70, 60);
            buttonDivide.TabIndex = 16;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = SystemColors.HighlightText;
            buttonMultiply.Font = new Font("Segoe UI", 20F);
            buttonMultiply.Location = new Point(240, 158);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(70, 60);
            buttonMultiply.TabIndex = 17;
            buttonMultiply.Text = "×";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = SystemColors.HighlightText;
            buttonMinus.Font = new Font("Segoe UI", 20F);
            buttonMinus.Location = new Point(240, 224);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(70, 60);
            buttonMinus.TabIndex = 18;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = SystemColors.HighlightText;
            buttonPlus.Font = new Font("Segoe UI", 20F);
            buttonPlus.Location = new Point(240, 290);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(70, 60);
            buttonPlus.TabIndex = 19;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(324, 434);
            Controls.Add(buttonPlus);
            Controls.Add(buttonMinus);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonDivide);
            Controls.Add(buttonModulo);
            Controls.Add(buttonPlsMns);
            Controls.Add(buttonAC);
            Controls.Add(buttonEquals);
            Controls.Add(buttonDot);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Calculator";
            Text = "Gianna's Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button buttonDot;
        private Button buttonEquals;
        private Button buttonAC;
        private Button buttonPlsMns;
        private Button buttonModulo;
        private Button buttonDivide;
        private Button buttonMultiply;
        private Button buttonMinus;
        private Button buttonPlus;
    }
}
