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
    }
}
