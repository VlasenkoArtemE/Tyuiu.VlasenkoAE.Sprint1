using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VlasenkoAE.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double res = (((x % 1) * 10) - (((x % 1) * 10) % 1));
            return (int)res;
        }
    }
}
