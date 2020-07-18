using System;
using System.Collections.Generic;
using System.Text;

namespace CamelCase
{
    public class Converter
    {
        public string CamelCase(string str)
        {
            var res = new List<char>();
            var isLetter = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]) && isLetter == false)
                {
                    res.Add(char.ToUpper(str[i]));
                    isLetter = true;
                    
                }
                else if (char.IsLetter(str[i]) && isLetter != false)
                {
                    res.Add(char.ToLower(str[i]));
                }
                else
                {
                    isLetter = false;
                }
                
            } 
            return string.Join("", res);

        }
    }
}
