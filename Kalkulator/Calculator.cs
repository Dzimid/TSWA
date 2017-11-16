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

        public Calculator()
        {
            this.result = "0";
            this.systemV = "HEX";
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
    }
}
