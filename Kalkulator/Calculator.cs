using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Kalkulator
{  
    public class Calculator
    {
        private string result;
        private string systemV;
        private static char[] binTable = { '0', '1' };
        private static char[] octTable = { '0', '1', '2', '3', '4', '5', '6', '7' };
        private static char[] decTable = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static char[] hexTable = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        private IDictionary<string, char[]> systemTable = new Dictionary<string, char[]>();
        Form1 form;
        public double resultant;

        public Calculator(Form1 form)
        {
            this.result = "0";
            this.systemV = "DEC";
            this.systemTable["BIN"] = Calculator.binTable;
            this.systemTable["OCT"] = Calculator.octTable;
            this.systemTable["DEC"] = Calculator.decTable;
            this.systemTable["HEX"] = Calculator.hexTable;
            this.form = form;
        }

        public string Result
        {
            set {
                this.result = value;
            }

            get {
                return this.result;
            }
        }

        public string SystemV
        {
            set {
                this.systemV = value;
            }

            get {
                return this.systemV;
            }
        }

        public char[] BinTable
        {
            get {
                return Calculator.binTable;
            }
        }

        public char[] OctTable
        {
            get {
                return Calculator.octTable;
            }
        }

        public char[] DecTable
        {
            get {
                return Calculator.decTable;
            }
        }

        public char[] HexTable
        {
            get {
                return Calculator.hexTable;
            }
        }

        public IDictionary<string, char[]> SystemTable
        {
            get {
                return this.systemTable;
            }
        }

        public void Addition() {

            form.isMinus = false;
            form.isOperation = true;
            resultant += Int64.Parse(form.mainTextBox.Text);
            form.operationsTextbox.Text += form.mainTextBox.Text + " + ";
            form.mainTextBox.Text = resultant.ToString();

            form.isFirstOperation = false;
        }

        public void Substraction() {

            form.isOperation = true;
            if (form.isFirstOperation) {
                resultant += Int64.Parse(form.mainTextBox.Text);
                form.isMinus = true;
            } else {
                resultant -= Int64.Parse(form.mainTextBox.Text);
                form.isMinus = false;
            }
            form.operationsTextbox.Text += form.mainTextBox.Text + " - ";
            form.mainTextBox.Text = resultant.ToString();

            form.isFirstOperation = false;
        }

        public void Sum() {

            form.isOperation = false;
            resultant += Int64.Parse(form.mainTextBox.Text);
            form.mainTextBox.Text = resultant.ToString();
            resultant = 0;
            form.operationsTextbox.Text = "";
        }
    }
}
