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
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Enabled = false;
            this.mainTextBox.Location = new System.Drawing.Point(13, 13);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(259, 20);
            this.mainTextBox.TabIndex = 0;
            // 
            // systemBin
            // 
            this.systemBin.AutoSize = true;
            this.systemBin.Location = new System.Drawing.Point(13, 40);
            this.systemBin.Name = "systemBin";
            this.systemBin.Size = new System.Drawing.Size(40, 17);
            this.systemBin.TabIndex = 1;
            this.systemBin.TabStop = true;
            this.systemBin.Text = "Bin";
            this.systemBin.UseVisualStyleBackColor = true;
            // 
            // systemOct
            // 
            this.systemOct.AutoSize = true;
            this.systemOct.Location = new System.Drawing.Point(13, 63);
            this.systemOct.Name = "systemOct";
            this.systemOct.Size = new System.Drawing.Size(42, 17);
            this.systemOct.TabIndex = 2;
            this.systemOct.TabStop = true;
            this.systemOct.Text = "Oct";
            this.systemOct.UseVisualStyleBackColor = true;
            // 
            // systemDec
            // 
            this.systemDec.AutoSize = true;
            this.systemDec.Location = new System.Drawing.Point(13, 86);
            this.systemDec.Name = "systemDec";
            this.systemDec.Size = new System.Drawing.Size(45, 17);
            this.systemDec.TabIndex = 3;
            this.systemDec.Text = "Dec";
            this.systemDec.UseVisualStyleBackColor = true;
            this.systemDec.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // systemHex
            // 
            this.systemHex.AutoSize = true;
            this.systemHex.Location = new System.Drawing.Point(13, 109);
            this.systemHex.Name = "systemHex";
            this.systemHex.Size = new System.Drawing.Size(44, 17);
            this.systemHex.TabIndex = 4;
            this.systemHex.TabStop = true;
            this.systemHex.Text = "Hex";
            this.systemHex.UseVisualStyleBackColor = true;
            this.systemHex.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.systemHex);
            this.Controls.Add(this.systemDec);
            this.Controls.Add(this.systemOct);
            this.Controls.Add(this.systemBin);
            this.Controls.Add(this.mainTextBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton systemBin;
        private System.Windows.Forms.RadioButton systemOct;
        private System.Windows.Forms.RadioButton systemHex;
        public System.Windows.Forms.RadioButton systemDec;
        public System.Windows.Forms.TextBox mainTextBox;
    }
}

