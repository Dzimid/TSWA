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
        private static char[] binTable = { '0', '1' };
        private static char[] octTable = { '0', '1', '2', '3', '4', '5', '6', '7' };
        private static char[] decTable = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static char[] hexTable = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        private IDictionary<string, char[]> systemTable = new Dictionary<string, char[]>();

        public Calculator()
        {
            this.result = "0";
            this.systemV = "DEC";
            this.systemTable["BIN"] = Calculator.binTable;
            this.systemTable["OCT"] = Calculator.octTable;
            this.systemTable["DEC"] = Calculator.decTable;
            this.systemTable["HEX"] = Calculator.hexTable;
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
    }
}
