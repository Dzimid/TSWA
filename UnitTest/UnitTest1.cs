using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kalkulator;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc;
        Form1 form;

        public UnitTest1()
        {
            this.calc = new Calculator();
            this.form = new Form1();
            this.form.Form1_Load(this, new EventArgs());
        }

        [TestMethod]
        public void TestStartingResult()
        {
            Assert.AreEqual("0", this.calc.Result);
        }

        [TestMethod]
        public void TestStartingSystemV()
        {
            Assert.AreEqual("DEC", this.calc.SystemV);
        }

        [TestMethod]
        public void TestStartingMainTextBoxText()
        {
            Assert.AreEqual("0", this.form.mainTextBox.Text);
        }

        [TestMethod]
        public void TestStartingSystemDecChecked()
        {
            Assert.IsTrue(this.form.systemDec.Checked);
        }

        [TestMethod]
        public void TestBackspaceButton()
        {
            int textboxLength = this.form.mainTextBox.Text.Length;
            this.form.Backspace();

            Assert.AreEqual(textboxLength - 1, this.form.mainTextBox.Text.Length);
        }

        [TestMethod]
        public void TestBinSys()
        {
            this.form.systemBin.Checked = true;
            Assert.IsTrue(this.testSystem(this.calc.BinTable));            
        }

        [TestMethod]
        public void TestDecSys()
        {
            this.form.systemDec.Checked = true;
            Assert.IsTrue(this.testSystem(this.calc.DecTable));
        }

        [TestMethod]
        public void TestHexSys()
        {
            this.form.systemHex.Checked = true;
            Assert.IsTrue(this.testSystem(this.calc.HexTable));
        }

        [TestMethod]
        public void TestOctSys()
        {
            this.form.systemOct.Checked = true;
            Assert.IsTrue(this.testSystem(this.calc.OctTable));
        }

        private bool testSystem(char[] table)
        {
            bool testResult = true;

            for (int i = 33; i <= 126; ++i) {
                this.form.Form1_KeyPress(new object(), new System.Windows.Forms.KeyPressEventArgs((char)i));
            }

            foreach (char c in this.form.mainTextBox.Text) {
                if (-1 == Array.IndexOf(table, c)) {
                    testResult = false;
                }
            }

            return testResult;
        }
    }
}
