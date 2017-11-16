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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (calculator.BinTable.Contains(e.KeyChar)) {
                mainTextBox.Text += e.KeyChar;
            }
        }
    }
}
