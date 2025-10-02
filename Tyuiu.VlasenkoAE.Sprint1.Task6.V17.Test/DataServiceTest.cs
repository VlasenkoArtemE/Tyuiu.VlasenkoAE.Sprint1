using Tyuiu.VlasenkoAE.Sprint1.Task6.V17.Lib;

namespace Tyuiu.VlasenkoAE.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string strTest = "12321";
            bool res = ds.CheckPalindrome(strTest);
            Assert.IsTrue(res);
        }
    }
}
