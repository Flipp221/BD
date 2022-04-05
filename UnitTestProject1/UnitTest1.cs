using BD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class AuthTest
    {
        [TestMethod]
        public void Auth_TestMethodFalse()
        {
            var authpage = new MainWindow();
            Assert.IsTrue(authpage.Auth(" ", " "));
        }
    }
}
