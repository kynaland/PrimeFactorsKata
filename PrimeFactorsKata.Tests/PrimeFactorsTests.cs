using System.Collections.Generic;
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
            const int n = 0;

            //Act
            var actualPrimeFactorsList = PrimeFactors.Generate(n);

            //Assert
            Assert.IsTrue(actualPrimeFactorsList.Count == 0);
        }

        [TestMethod]
        public void Generate_NumberIsPrime_ReturnsNumber()
        {
            //Arrange
            const int n = 11;

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
            const int n = 10;

            //Act
            var actualPrimeFactorsList = PrimeFactors.Generate(n);

            //Assert
            Assert.IsTrue(actualPrimeFactorsList.Count == 2);
            CollectionAssert.AreEquivalent(new List<int> { 2, 5 }, actualPrimeFactorsList);
        }

        [TestMethod]
        public void Generate_NumberWithDuplicateFactors_DuplicateFactorsCollectedAll()
        {
            //Arrange
            const int n = 4;

            //Act
            var factors = PrimeFactors.Generate(n);

            //Assert
            CollectionAssert.AreEqual(new List<int> { 2, 2 }, factors);
        }
    }
}
