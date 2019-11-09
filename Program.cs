using System;

namespace Web_Stand_Bolid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Signal20 signal20 = new Signal20();
            signal20.Power.ConnctPower(9);
            Console.ReadLine();
        }
    }
}
