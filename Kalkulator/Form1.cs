using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private Calculator calculator;

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize calculator
            this.calculator = new Calculator();
            mainTextBox.Text = this.calculator.Result;

            switch (calculator.SystemV) {
                case "BIN":
                    systemBin.Checked = true;
                    break;
                case "OCT":
                    systemOct.Checked = true;
                    break;
                case "DEC":
                    systemDec.Checked = true;
                    break;
                case "HEX":
                    systemHex.Checked = true;
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string system = this.getCheckedRadioName().Replace("system", String.Empty).ToUpper();;
            char keyChar = Char.ToUpper(e.KeyChar);

            // Validation
            if(this.calculator.SystemTable[system].Contains(keyChar)) {
                mainTextBox.Text += keyChar;
            }
        }

        private string getCheckedRadioName()
        {
            foreach (RadioButton radio in this.Controls) {
                if (radio.Checked) {
                    return radio.Name;
                }
            }

            return null;
        }
    }
}
