using Microsoft.VisualStudio.TestTools.UnitTesting;
using OldPhoneKeyInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhoneKeyInput.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestOldPhonePad_ValidInput_ReturnsCorrectOutput()
        {
            string input = "33#";
            string expectedOutput = "E";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_ValidInput_ReturnsEmptyString()
        {
            string input = "";
            string expectedOutput = "";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_ValidInputWithStar_ReturnsCorrectOutput()
        {
            string input = "227*#";
            string expectedOutput = "B";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_ValidInputWithMultipleStar_ReturnsCorrectOutput()
        {
            string input = "227**2#";
            string expectedOutput = "A";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_ValidInputWithSpace_ReturnsCorrectOutput()
        {
            string input = "4433555 555666#";
            string expectedOutput = "HELLO";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod()]
        public void TestOldPhonePad_ValidInputWithSpaceAndStar_ReturnsCorrectOutput()
        {
            string input = "8 88777444666*664#";
            string expectedOutput = "TURING";

            string result = Program.OldPhonePad(input);
            Assert.AreEqual(expectedOutput, result);
        }
    }
}