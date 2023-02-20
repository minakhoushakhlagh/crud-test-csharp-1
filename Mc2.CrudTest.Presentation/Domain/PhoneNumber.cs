
using System;
using System.Linq;

namespace Mc2.CrudTest.Domain
{
    public class PhoneNumber
    {
        public PhoneNumber(string number)
        {
            if (number.Length != 11)
            {
                throw new Exception($"PhoneNumber length '{number}' is not valid!");
            }
            if (!number.All(char.IsDigit))
            {
                throw new Exception($"PhoneNumber '{number}' is not valid!");
            }
            Value = number;
        }
        public string Value { get;}

        public static bool TryParse(string number,out PhoneNumber phoneNumber)
        {
            try
            {
                phoneNumber = new PhoneNumber(number);
                return true;
            }
            catch (Exception)
            {
                phoneNumber = null;
                return false;
            }
        }
    }
}
