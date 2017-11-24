namespace Kalkulator_test
{
    partial class TestForm1
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
            this.testResult = new System.Windows.Forms.Button();
            this.buttonTextBox = new System.Windows.Forms.Button();
            this.isDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testResult
            // 
            this.testResult.Location = new System.Drawing.Point(13, 13);
            this.testResult.Name = "testResult";
            this.testResult.Size = new System.Drawing.Size(118, 23);
            this.testResult.TabIndex = 0;
            this.testResult.Text = "Result = 0";
            this.testResult.UseVisualStyleBackColor = true;
            this.testResult.Click += new System.EventHandler(this.testResult_Click);
            // 
            // buttonTextBox
            // 
            this.buttonTextBox.Location = new System.Drawing.Point(13, 43);
            this.buttonTextBox.Name = "buttonTextBox";
            this.buttonTextBox.Size = new System.Drawing.Size(118, 23);
            this.buttonTextBox.TabIndex = 1;
            this.buttonTextBox.Text = "texBox.text = 0";
            this.buttonTextBox.UseVisualStyleBackColor = true;
            this.buttonTextBox.Click += new System.EventHandler(this.buttonTextBox_Click);
            // 
            // isDec
            // 
            this.isDec.Location = new System.Drawing.Point(13, 73);
            this.isDec.Name = "isDec";
            this.isDec.Size = new System.Drawing.Size(118, 23);
            this.isDec.TabIndex = 2;
            this.isDec.Text = "Dec.checked = true";
            this.isDec.UseVisualStyleBackColor = true;
            this.isDec.Click += new System.EventHandler(this.isDec_Click);
            // 
            // TestForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.isDec);
            this.Controls.Add(this.buttonTextBox);
            this.Controls.Add(this.testResult);
            this.Name = "TestForm1";
            this.Text = "Testy kalkulatora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testResult;
        private System.Windows.Forms.Button buttonTextBox;
        private System.Windows.Forms.Button isDec;
    }
}

