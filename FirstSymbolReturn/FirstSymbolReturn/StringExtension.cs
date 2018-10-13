using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSymbolReturn
{
    public static class StringExtension
    {
        public static char GetFirstSymbol(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ValidationException($"Empty string {nameof(str)}");
            }

            return str[0];
        }
    }
}
