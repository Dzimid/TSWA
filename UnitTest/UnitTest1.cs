using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kalkulator;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc;
        Form1 form;

        public UnitTest1()
        {
            this.form = new Form1();
            this.calc = new Calculator(form);
            this.form.Form1_Load(this, new EventArgs());
        }

        [TestMethod]
        public void TestStartingResult()
        {
            Assert.AreEqual("0", this.calc.result.ToString());
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
            keyPress('5');
            keyPress('5');
            keyPress('5');
            int textboxLength = this.form.mainTextBox.Text.Length;
            this.form.Backspace();

            Assert.AreEqual(textboxLength-1, this.form.mainTextBox.Text.Length);
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

        [TestMethod]
        public void TestAddition() {
            char a = '5';

            keyPress(a);
            keyPress('+');
            keyPress('=');

            Assert.AreEqual("10", form.mainTextBox.Text.ToString());
        }

        [TestMethod]
        public void TestReplacingTextAfterOperation() {
            keyPress('5');
            keyPress('0');
            keyPress('+');
            keyPress('5');
            int textboxLength = this.form.mainTextBox.Text.Length;

            Assert.AreEqual(1, this.form.mainTextBox.Text.Length);
        }

        [TestMethod]
        public void TestdeleteToZero() {
            keyPress('5');
            this.form.Backspace();

            Assert.AreEqual("0", this.form.mainTextBox.Text);
        }

        [TestMethod]
        public void TestChangeButtonColor() {
            this.form.Form1_KeyDown(new object(), new System.Windows.Forms.KeyEventArgs(form.keyArray[6]));
            bool isColorChanged = false;
            if(this.form.button5.BackColor == SystemColors.ControlLightLight) {
                isColorChanged = true;
            }
            this.form.Form1_KeyUp(new object(), new System.Windows.Forms.KeyEventArgs(form.keyArray[6]));
            Assert.IsTrue(isColorChanged);
        }


        private bool testSystem(char[] table)
        {
            bool testResult = true;

            for (int i = 33; i <= 126; ++i) {
                keyPress((char)i);
            }

            foreach (char c in this.form.mainTextBox.Text) {
                if (-1 == Array.IndexOf(table, c)) {
                    testResult = false;
                }
            }

            return testResult;
        }

        private void keyPress(char c) {
            this.form.Form1_KeyPress(new object(), new System.Windows.Forms.KeyPressEventArgs(c));
        }

    }
}
