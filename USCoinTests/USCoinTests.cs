using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint4Currency;
namespace USCoinTests
{
    /// <summary>
    /// Summary description for USCoinTests
    /// </summary>
    [TestClass]
    public class USCoinTests
    {
        Penny p;

        public USCoinTests()
        {
            p = new Penny();
        }

        [TestMethod]
        public void USCoinPennyContructor()
        {
            //Arrange
            p = new Penny();
            //Act

            //Assert
            Assert.AreEqual(CurrencyRepo.US.USCoinMintMark.D, p.GetMintNameFromMark);
            Assert.AreEqual(System.DateTime.Now.Year, p.Year);
        }
        
    }
}
