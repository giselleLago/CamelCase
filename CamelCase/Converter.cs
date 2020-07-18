using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CamelCase
{
    public class Converter
    {
        public string CamelCase(string str)
        {

            var res = "";
            var nextIsUpper = false;
            for (int i = 0; i < str.Length; i++)
            {
                var current = str[i];
                if (char.IsLetter(current))
                { 
                    res += nextIsUpper 
                        ? current.ToString().ToUpperInvariant()
                        : current.ToString().ToLowerInvariant();
                    nextIsUpper = false;
                } 
                else
                {
                    nextIsUpper = true;
                }
            } 
            return res;

        }
    }
}
