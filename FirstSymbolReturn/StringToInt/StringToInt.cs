using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace StringToInt
{
    public static class StringToInt
    {
        public static int ToInt(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ValidationException($"Empty string {nameof(str)}");
            }

            if (str.ContainsOnlyDigits() || (str.Length > 1 && str.StartsWith("-") && str.Substring(1).ContainsOnlyDigits()))
            {
                bool isNegative = (str[0] == '-');
                if (isNegative)
                {
                    str = str.Substring(1);
                }

                int result = 0;
                try
                {
                    result = str
                        .Select((c, j) => (c - '0') * (int)Math.Pow(10, (str.Length - j - 1)))
                        .Sum();                              
                }
                catch (OverflowException e)
                {
                    throw new ArgumentException("The input value was too long", e);                  
                }
                return (isNegative) ? -result : result;
            }
            else
            {
                throw new ArgumentException("Input string with digits only");
            }
        }

        public static bool ContainsOnlyDigits(this string str)
        {
            return str.All(s => char.IsDigit(s));
        }
    }
}
