using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator
{
    [TestClass]
    public class CalculatorTests
    {

        Calculator calculator = new Calculator();

        [TestMethod]
        public void DataUnaStringaVuotaRitornaZero()
        {
            AssertSum("", 0);
        }

        [TestMethod]
        public void DataUnaStringaConUnNumeroRitornaQuelNumero()
        {
            AssertSum("5", 5);
        }

        [TestMethod]
        public void DataUnaStringaConDueNumeriRitornaLaSomma()
        {
            AssertSum("2,3", 5);
        }

        [TestMethod]
        public void DataUnaStringaConTantiNumeriRitornaLaSomma()
        {
            AssertSum("1,2,3", 6);
            AssertSum("1,2,3,4", 10);
            AssertSum("1,2,3,4,3,2,1", 16);
        }

        [TestMethod]
        public void DataUnaStringaConTantiNumeriSeparatiDaVirgolaONewlineRitornaLaSomma()
        {
            AssertSum("1\n2,3", 6);
            AssertSum("1,5\n\n4,2,3", 15);
        }

        [TestMethod]
        public void DataUnaStringaCheSpecificaNellaPrimaRigaUnDelimitatoreRitornaLaSommaDeiNumeriSeparatiDalDelimitatore()
        {
            AssertSum("//;\n2;3;4", 9);
            AssertSum("//+\n1+2+3+4", 10);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DataUnaStringaConNumeriNegativiSollevaUnEccezioneConElencoNumNegativi()
        {
            try
            {
                calculator.Add("//;\n2;-3;-4;5;-3");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Negatives not allowed: -3,-4,-3", e.Message);
                throw;
            }
        }

        [TestMethod]
        public void NumeriSopraMilleIgnorati()
        {
            AssertSum("2,1001", 2);
            AssertSum("//+\n1+2000+3+4", 8);
        }

        private void AssertSum(string inputString, int expected)
        {
            int actual = calculator.Add(inputString);
            Assert.AreEqual(expected, actual);
        }




    }
}
