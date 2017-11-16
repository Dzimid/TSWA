using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{  
    public class Calculator
    {
        private string result;
        private string systemV;
        private char[] binTable = { '0', '1' };
        private char[] octTable = { '0', '1', '2', '3', '4', '5', '6', '7' };
        private char[] decTable = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private char[] hexTable = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        public Calculator()
        {
            this.result = "0";
            this.systemV = "DEC";
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
                return this.binTable;
            }
        }

        public char[] OctTable
        {
            get {
                return this.octTable;
            }
        }

        public char[] DecTable
        {
            get {
                return this.decTable;
            }
        }

        public char[] HexTable
        {
            get {
                return this.hexTable;
            }
        }
    }
}
