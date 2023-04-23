using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Utilities
{
    public class IntegerUtility
    {
        public bool TryParse(string text, out int number)
        {
            try
            {
                number = int.Parse(text);
                return true;
            }
            catch
            {
                number = -1;
                return false;
            }
        }
        public bool IsLengthBetween(decimal number, decimal min, decimal max)
        {
            return number > min && number < max;
        }
        //Method overloading ( polymorphism)
        public bool IsLengthBetween(int number, int min, int max)
        {
            return number > min && number < max;
        }
    }
}
