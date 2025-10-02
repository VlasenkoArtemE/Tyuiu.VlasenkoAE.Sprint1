using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VlasenkoAE.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            string rev = new string(value.Reverse().ToArray());
            if (rev == value)
                return true;
            else
                return false;
        }
    }
}
