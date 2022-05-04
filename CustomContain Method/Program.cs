using System;

namespace CustomContain_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cumle daxil edin: ");
            string sentence = Console.ReadLine();
            Console.Write("Axtardiginiz hisseni daxil edin: ");
            string search = Console.ReadLine();
            Console.Write("Netice: ");
            sentence.CustomContain(search);
            
        }
    }
}
