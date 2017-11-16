using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{  
    public class Calculator
    {
        private string result_;

        public Calculator()
        {
            this.result_ = "0";
        }

        public string Result
        {
            set {
                this.result_ = value;
            }

            get {
                return this.result_;
            }
        }
    }
}
