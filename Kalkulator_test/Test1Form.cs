using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kalkulator;

namespace Kalkulator_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testResult_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var form = new Kalkulator.Form1();
            form.Show();

            var calculator = new Calculator();

            if (0 == calculator.result) {
                testResult.ForeColor = Color.Green;
            }
        }
    }
}
