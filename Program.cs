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
           DevelopSignal20.Loop[3] = new Bolid.Devices.RadialLoops.TypesLoops.Signal20.TypeLoop4(4.7);
           DevelopSignal20.KeysLoop[3].Click();
           DevelopSignal20.Loop[3].NewLoopResistance(13);
           Console.ReadLine();
        }
    }
}
