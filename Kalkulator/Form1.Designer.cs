namespace Kalkulator
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
            if (disposing && (components != null)) {
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
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.systemBin = new System.Windows.Forms.RadioButton();
            this.systemOct = new System.Windows.Forms.RadioButton();
            this.systemDec = new System.Windows.Forms.RadioButton();
            this.systemHex = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonLP = new System.Windows.Forms.Button();
            this.buttonRP = new System.Windows.Forms.Button();
            this.buttonPM = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonDeleteCE = new System.Windows.Forms.Button();
            this.buttonDeleteC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTextBox.Enabled = false;
            this.mainTextBox.Location = new System.Drawing.Point(13, 34);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(356, 20);
            this.mainTextBox.TabIndex = 0;
            // 
            // systemBin
            // 
            this.systemBin.AutoSize = true;
            this.systemBin.Location = new System.Drawing.Point(13, 102);
            this.systemBin.Name = "systemBin";
            this.systemBin.Size = new System.Drawing.Size(40, 17);
            this.systemBin.TabIndex = 1;
            this.systemBin.TabStop = true;
            this.systemBin.Text = "Bin";
            this.systemBin.UseVisualStyleBackColor = true;
            this.systemBin.CheckedChanged += new System.EventHandler(this.systemBin_CheckedChanged);
            // 
            // systemOct
            // 
            this.systemOct.AutoSize = true;
            this.systemOct.Location = new System.Drawing.Point(13, 125);
            this.systemOct.Name = "systemOct";
            this.systemOct.Size = new System.Drawing.Size(42, 17);
            this.systemOct.TabIndex = 2;
            this.systemOct.TabStop = true;
            this.systemOct.Text = "Oct";
            this.systemOct.UseVisualStyleBackColor = true;
            this.systemOct.CheckedChanged += new System.EventHandler(this.systemOct_CheckedChanged);
            // 
            // systemDec
            // 
            this.systemDec.AutoSize = true;
            this.systemDec.Location = new System.Drawing.Point(13, 148);
            this.systemDec.Name = "systemDec";
            this.systemDec.Size = new System.Drawing.Size(45, 17);
            this.systemDec.TabIndex = 3;
            this.systemDec.Text = "Dec";
            this.systemDec.UseVisualStyleBackColor = true;
            this.systemDec.CheckedChanged += new System.EventHandler(this.systemDec_CheckedChanged);
            // 
            // systemHex
            // 
            this.systemHex.AutoSize = true;
            this.systemHex.Location = new System.Drawing.Point(13, 171);
            this.systemHex.Name = "systemHex";
            this.systemHex.Size = new System.Drawing.Size(44, 17);
            this.systemHex.TabIndex = 4;
            this.systemHex.TabStop = true;
            this.systemHex.Text = "Hex";
            this.systemHex.UseVisualStyleBackColor = true;
            this.systemHex.CheckedChanged += new System.EventHandler(this.systemHex_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(207, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(248, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(289, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(207, 143);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(248, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 12;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(289, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 35);
            this.button9.TabIndex = 13;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(248, 265);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(35, 35);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(289, 265);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(35, 35);
            this.buttonDot.TabIndex = 15;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(166, 225);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(35, 35);
            this.buttonF.TabIndex = 16;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(125, 225);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(35, 35);
            this.buttonE.TabIndex = 17;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(125, 184);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(35, 35);
            this.buttonC.TabIndex = 18;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(166, 184);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(35, 35);
            this.buttonD.TabIndex = 19;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(125, 143);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(35, 35);
            this.buttonA.TabIndex = 20;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(166, 143);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(35, 35);
            this.buttonB.TabIndex = 21;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // buttonLP
            // 
            this.buttonLP.Location = new System.Drawing.Point(125, 266);
            this.buttonLP.Name = "buttonLP";
            this.buttonLP.Size = new System.Drawing.Size(35, 35);
            this.buttonLP.TabIndex = 22;
            this.buttonLP.Text = "(";
            this.buttonLP.UseVisualStyleBackColor = true;
            // 
            // buttonRP
            // 
            this.buttonRP.Location = new System.Drawing.Point(166, 266);
            this.buttonRP.Name = "buttonRP";
            this.buttonRP.Size = new System.Drawing.Size(35, 35);
            this.buttonRP.TabIndex = 23;
            this.buttonRP.Text = ")";
            this.buttonRP.UseVisualStyleBackColor = true;
            // 
            // buttonPM
            // 
            this.buttonPM.Location = new System.Drawing.Point(207, 266);
            this.buttonPM.Name = "buttonPM";
            this.buttonPM.Size = new System.Drawing.Size(35, 35);
            this.buttonPM.TabIndex = 24;
            this.buttonPM.Text = "±";
            this.buttonPM.UseVisualStyleBackColor = true;
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(330, 143);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(35, 35);
            this.buttonMulti.TabIndex = 25;
            this.buttonMulti.Text = "×";
            this.buttonMulti.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(330, 184);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(35, 35);
            this.buttonMinus.TabIndex = 26;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(330, 225);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(35, 35);
            this.buttonPlus.TabIndex = 27;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(330, 265);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(35, 35);
            this.buttonEqual.TabIndex = 28;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(330, 102);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(35, 35);
            this.buttonDivide.TabIndex = 29;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Location = new System.Drawing.Point(289, 102);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(35, 35);
            this.buttonBackspace.TabIndex = 30;
            this.buttonBackspace.Text = "«";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonDeleteCE
            // 
            this.buttonDeleteCE.Location = new System.Drawing.Point(207, 102);
            this.buttonDeleteCE.Name = "buttonDeleteCE";
            this.buttonDeleteCE.Size = new System.Drawing.Size(35, 35);
            this.buttonDeleteCE.TabIndex = 31;
            this.buttonDeleteCE.Text = "ce";
            this.buttonDeleteCE.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteC
            // 
            this.buttonDeleteC.Location = new System.Drawing.Point(248, 102);
            this.buttonDeleteC.Name = "buttonDeleteC";
            this.buttonDeleteC.Size = new System.Drawing.Size(35, 35);
            this.buttonDeleteC.TabIndex = 32;
            this.buttonDeleteC.Text = "c";
            this.buttonDeleteC.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(13, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(356, 13);
            this.textBox1.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 312);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDeleteC);
            this.Controls.Add(this.buttonDeleteCE);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonPM);
            this.Controls.Add(this.buttonRP);
            this.Controls.Add(this.buttonLP);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.systemHex);
            this.Controls.Add(this.systemDec);
            this.Controls.Add(this.systemOct);
            this.Controls.Add(this.systemBin);
            this.Controls.Add(this.mainTextBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RadioButton systemDec;
        public System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonLP;
        private System.Windows.Forms.Button buttonRP;
        private System.Windows.Forms.Button buttonPM;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonDeleteCE;
        private System.Windows.Forms.Button buttonDeleteC;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.RadioButton systemBin;
        public System.Windows.Forms.RadioButton systemOct;
        public System.Windows.Forms.RadioButton systemHex;
    }
}

