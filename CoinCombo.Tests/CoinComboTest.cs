using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo;

namespace CoinCombo.Tests
{
  [TestClass]
  public class CoinComboTest
  {
    [TestMethod]
    public void TotalCannotRemoveQuarter_True()
    {
      double total = 0.03;
      CoinCombo testCoinCombo = new CoinCombo();
      Assert.AreEqual(true, testCoinCombo.CannotRemoveQuarter(total));
    }
    [TestMethod]
    public void TotalCanRemoveQuarter_True()
    {
      double total = 0.99;
      CoinCombo testCoinCombo = new CoinCombo();
      Assert.AreEqual(true, testCoinCombo.RemoveQuarter(total));
    }
    [TestMethod]
    public void TotalCanRemoveDime_True()
    {
      double total = 0.99;
      CoinCombo testCoinCombo = new CoinCombo();
      Assert.AreEqual(true, testCoinCombo.RemoveDime(total));
    }
    [TestMethod]
    public void TotalCanRemoveNickel_True()
    {
      double total = 0.99;
      CoinCombo testCoinCombo = new CoinCombo();
      Assert.AreEqual(true, testCoinCombo.RemoveNickel(total));
    }
    [TestMethod]
    public void TotalCanRemovePenny_True()
    {
      double total = 0.99;
      CoinCombo testCoinCombo = new CoinCombo();
      Assert.AreEqual(true, testCoinCombo.RemovePenny(total));
    }

    [TestMethod]
    public void DoesChangeFunctionStopAtZero_True()
    {
      double total = 0.99;
      CoinCombo testCoinCombo = new CoinCombo();
      Assert.AreEqual(true, testCoinCombo.GetChange(total));
    }
  }
}
