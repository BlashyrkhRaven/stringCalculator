﻿using System;
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

        //public void DataUnaStringaConTantiNumeriSeparatiDaVirgolaONewlineRitornaLaSomma()
        //{
        //    AssertSum("1\n2,3", 6);
        //}

        private void AssertSum(string inputString, int expected)
        {
            int actual = calculator.Add(inputString);
            Assert.AreEqual(expected, actual);
        }

        


    }
}
