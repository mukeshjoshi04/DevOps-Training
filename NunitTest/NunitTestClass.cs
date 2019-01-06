using NUnit.Framework;
using WebAppWithNunitTest;
namespace NunitTest
{
    [TestFixture]
    public class NunitTestClass
    {
        [TestCase]
       public void VerifyAddition()
        {
            int result = ConnectClass.addition(10, 20);
            Assert.AreEqual(30,result);
        }
    }
}
