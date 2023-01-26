using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTest
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            double alkusaldo = 11.99;
            double creditSumma = 4.55;
            double oletettu = 7.44;

            BankAccountNS.BankAccount pt = new BankAccount("Lasse Sievinen", alkusaldo);
        }
    }
}