using System;

namespace Web_Stand_Bolid
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello World!");
           Signal20 DevelopSignal20 = new Signal20();
           DevelopSignal20.Power.ConnctPower(20);
           Console.ReadLine();
        }
 
        
    }
}
