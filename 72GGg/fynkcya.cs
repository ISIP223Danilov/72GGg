using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72GGg
{
    public class fynkcya
    {
        public static string Rot13(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            StringBuilder result = new StringBuilder(text.Length);

            foreach (char c in text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    // Для заглавных букв
                    char shifted = (char)(c + 13);
                    if (shifted > 'Z')
                        shifted = (char)(shifted - 26);
                    result.Append(shifted);
                }
                else if (c >= 'a' && c <= 'z')
                {
                    // Для строчных букв
                    char shifted = (char)(c + 13);
                    if (shifted > 'z')
                        shifted = (char)(shifted - 26);
                    result.Append(shifted);
                }
                else
                {
                    // Неалфавитные символы оставляем без изменений
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}
    
