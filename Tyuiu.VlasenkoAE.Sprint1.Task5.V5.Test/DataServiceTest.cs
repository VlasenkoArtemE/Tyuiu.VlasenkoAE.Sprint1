using Tyuiu.VlasenkoAE.Sprint1.Task5.V5.Lib;

namespace Tyuiu.VlasenkoAE.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 15.556;
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}
