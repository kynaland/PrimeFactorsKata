using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeFactorsKata.Tests
{
    [TestClass]
    public class PrimeFactorsTests
    {
        [TestMethod]
        public void Generate_NumberIsSmallerThan1_ReturnsEmptyList()
        {
            //Arrange
            int n = 0;

            //Act
            var actualPrimeFactorsList = PrimeFactors.Generate(n);

            //Assert
            Assert.IsTrue(actualPrimeFactorsList.Count == 0);
        }

        [TestMethod]
        public void Generate_NumberIsPrime_ReturnsNumber()
        {
            //Arrange
            int n = 11;

            //Act
            var actualPrimeFactorsList = PrimeFactors.Generate(n);

            //Assert
            Assert.IsTrue(actualPrimeFactorsList.Count == 1);
            CollectionAssert.AreEquivalent(new List<int> { 11 }, actualPrimeFactorsList);
        }

        [TestMethod]
        public void Generate_NumberHasMorePrimeFactors_ReturnsPrimeFactors()
        {
            //Arrange
            int n = 10;

            //Act
            var actualPrimeFactorsList = PrimeFactors.Generate(n);

            //Assert
            Assert.IsTrue(actualPrimeFactorsList.Count == 2);
            CollectionAssert.AreEquivalent(new List<int> { 2, 5 }, actualPrimeFactorsList);
        }
    }
}
