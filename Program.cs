using System;

namespace ders2
{
    class Program
    {
        static void yaz(object a, int b)
        {
            for (; b > 0; b--) 
            
            Console.WriteLine(a);
            
        }
        static void Main()
        {
            yaz("dene", 3);
            Console.ReadLine();
        }
    }
}
