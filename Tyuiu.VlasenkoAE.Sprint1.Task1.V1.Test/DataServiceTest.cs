using Tyuiu.VlasenkoAE.Sprint1.Task1.V1.Lib;

namespace Tyuiu.VlasenkoAE.Sprint1.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double x = 3.0;
            double y = 2.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(6.5, res);
        }
    }
}
