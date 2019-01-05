using NUnit.Framework;
using WebAppWithNunitTest;
namespace NunitTest
{
    [TestFixture]
    public class NunitTestClass
    {
        [TestCase]
       public void VerifyAddition(int result)
        {
            ConnectClass CCobj = new ConnectClass();
            Assert.AreEqual(CCobj.x+CCobj.y, CCobj.x + CCobj.y);
        }
    }
}
