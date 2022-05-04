using System;
using System.Collections.Generic;
using System.Text;

namespace CustomContain_Method
{
    static class Extension
    {
      public static void CustomContain(this string sentence, string search)
        {
            bool result = false;
            string Check = string.Empty;
            for (int i = 0; i < sentence.Length; i++)
            {
                if ((i + search.Length) > sentence.Length)
                {
                    break;
                }
                Check = sentence.Substring(i, search.Length);
                if (Check.ToLower() == search.ToLower())
                {
                    result = true;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
