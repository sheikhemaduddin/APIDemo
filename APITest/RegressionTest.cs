using Microsoft.VisualStudio.TestTools.UnitTesting;
using APIDemo;

namespace APITest
{
    [TestClass]
    public class RegressionTest
    {
        [TestMethod]
        public void VerifyListOfUsers()
        {
            var demo = new Demo();
            var response =  demo.GetUsers();
            Assert.AreEqual(2, response.Page);
            Assert.AreEqual("Lindsay", response.Data[1].first_name);
        }

        [TestMethod]
        public void TestMethod2()
        {

        }
    }
}
