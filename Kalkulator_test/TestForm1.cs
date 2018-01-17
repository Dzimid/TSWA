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
    public partial class TestForm1 : Form
    {
        private Form1 form;
        private Calculator calculator;

        public TestForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load calculator form
            this.form = new Form1();
            this.calculator = new Calculator(this.form);
            form.Show();

            // Running tests
            this.testResultValue();
            this.testTextBox();
            this.testDecChecked();
        }

        private void testResultValue()
        {
            if ("0" == calculator.result.ToString()) {
                testResult.ForeColor = Color.Green;
            } else {
                testResult.ForeColor = Color.Red;
            }
        }

        private void testTextBox()
        {
            if ("0" == form.mainTextBox.Text) {
                buttonTextBox.ForeColor = Color.Green;
            } else {
                buttonTextBox.ForeColor = Color.Red;
            }
        }

        private void testDecChecked()
        {
            if (true == form.systemDec.Checked) {
                isDec.ForeColor = Color.Green;
            } else {
                isDec.ForeColor = Color.Red;
            }
        }

        private void buttonTextBox_Click(object sender, EventArgs e)
        {
            this.testTextBox();
        }

        private void isDec_Click(object sender, EventArgs e)
        {
            this.testDecChecked();
        }

        private void testResult_Click(object sender, EventArgs e)
        {
            this.testResultValue();
        }
    }
}
