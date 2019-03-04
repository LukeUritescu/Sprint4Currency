using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint4Currency;
namespace USCoinTests
{

    [TestClass]
    public class USCurrencyRepoTests
    {
        ICurrencyRepo repo;
        Penny penny;
        Nickel nickel;
        Dime dime;
        Quarter quarter;
        DollarCoin dollarcoin;

        public USCurrencyRepoTests()
        {
            repo = new CurrencyRepo();
            penny = new Penny();
            nickel = new Nickel();
            dime = new Dime();
            quarter = new Quarter();
            dollarcoin = new DollarCoin();
        }

        [TestMethod]
        public void AddCoinTest()
        {
            //Arrange
            int coinCountOrig, coinCountAfterPenny, coinCountAfterFiveMorerPennies;
            int numPennies = 5;

            Double valueOrig, valueAfterPenny, valueAfterFiveMorePennies;
            Double valueAfterNickel, valueAfterDime, valueAfterQuarter, valueAfterDollar;
            //Act
            coinCountOrig = repo.GetCoinCount();
            valueOrig = repo.TotalValue();

            repo.AddCoin(penny);
            coinCountAfterPenny = repo.GetCoinCount();
            valueAfterPenny = repo.TotalValue();

            for (int i = 0; i < numPennies; i++)
            {
                repo.AddCoin(penny);
            }
            coinCountAfterFiveMorerPennies = repo.GetCoinCount();
            valueAfterFiveMorePennies = repo.TotalValue();

            repo.AddCoin(nickel);
            valueAfterNickel = repo.TotalValue();
            repo.AddCoin(dime);
            valueAfterDime = repo.TotalValue();
            repo.AddCoin(quarter);
            valueAfterQuarter = repo.TotalValue();
            repo.AddCoin(dollarCoin);
            valueAfterDollar = repo.TotalValue();


            //Assert
            Assert.AreEqual(coinCountOrig + 1, coinCountAfterPenny);
            Assert.AreEqual(coinCountAfterPenny + numPennies, coinCountAfterFiveMorePennies);

            Assert.AreEqual(valueOrig + penny.MonetaryValue, valueAfterPenny);
            Assert.AreEqual(valueAfterPenny + (numPennies * penny.MonetaryValue), valueAfterFiveMorePennies);

            Assert.AreEqual(valueAfterFiveMorePennies + nickel.MonetaryValue, valueAfterNickel);
            Assert.AreEqual(valueAfterNickel + dime.MonetaryValue, valueAfterDime);
            Assert.AreEqual(valueAfterDime + quarter.MonetaryValue, valueAfterQuarter);
            Assert.AreEqual(valueAfterQuarter + dollarCoin.MonetaryValue, valueAfterDollar);

        }
    }
}
