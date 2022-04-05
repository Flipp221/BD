using BD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class AuthTest
    {
        [TestMethod]
        public void TestMethodFalse()
        {
            var authpage = new MainWindow();
            Assert.IsTrue(authpage.Auth("", ""));
        }
        [TestMethod]
        public void TestMethodTrue()
        {
            var authpage = new MainWindow();
            Assert.IsFalse(authpage.Auth("211907", "7777"));
        }
    }
}
