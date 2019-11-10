using System.Timers;

namespace Bolid
{
    namespace Deviecs
    {
        namespace ComponentsDevice
        {
            namespace Indicator
            {
                public class Indicator
                {
                    public Timer AllForTime;
                    public Timer OnTime;
                    public bool StateIndicator = false;
                    public Indicator(bool GetState)
                    {
                        this.StateIndicator = GetState;
                        System.Console.WriteLine("Work Indicator Start");

                    }

                    public Indicator(double GetAllForTime, double GetOnTime, bool StartStete)
                    {
                        AllForTime = new Timer(GetAllForTime);
                        OnTime = new Timer(GetOnTime);
                        AllForTime.Elapsed += FunctionAllTimerPick;
                        OnTime.Elapsed += FunctionOnTimerPick;
                        this.StateIndicator = StartStete;
                        AllForTime.Start();
                    }

                    public void FunctionAllTimerPick(object sender, ElapsedEventArgs e)
                    {
                        System.Console.ForegroundColor = System.ConsoleColor.Green;
                        System.Console.WriteLine("Work Indicator Start");
                        OnTime.Start();
                    }

                    public void FunctionOnTimerPick(object sender, ElapsedEventArgs e)
                    {
                        System.Console.ForegroundColor = System.ConsoleColor.Black;
                        System.Console.WriteLine("Work Indicator Stop");
                        this.StateIndicator = true;
                        this.OnTime.Stop();
                    }

                }

            }
            namespace RS485
            {
                public class RS485
                {

                }

            }
            namespace RS232
            {
                public class RS232
                {

                }

            }
            namespace Shleif
            {
                public class Shleif
                {
                    public double KResits;
                    public int ACP;
                }

            }
            namespace Reley
            {
                public class Reley
                {

                }

            }
            namespace Power
            {
                public enum PowerStates { АварияИсточникаПитания, НормаИсточникаПитания };
                public class Power
                {
                    public delegate void OutStatePower(Bolid.Deviecs.ComponentsDevice.Power.PowerStates State);
                    public event OutStatePower MessageCPPower;
                    public double StateVolt = 0;
                    public Power(double GetV)
                    {
                        StateVolt = GetV;
                    }

                    public Power()
                    {

                    }

                    public void ConnctPower(double GetV)
                    {
                        StateVolt = GetV;
                        if (StateVolt < VMinimum)
                        {
                            MessageCPPower(Bolid.Deviecs.ComponentsDevice.Power.PowerStates.АварияИсточникаПитания);
                        }
                        else if (StateVolt > VMinimum)
                        {
                            MessageCPPower(Bolid.Deviecs.ComponentsDevice.Power.PowerStates.АварияИсточникаПитания);
                        }
                        else
                        {
                            MessageCPPower(Bolid.Deviecs.ComponentsDevice.Power.PowerStates.НормаИсточникаПитания);
                        }
                    }
                    public double VMinimum;
                    public double VMaximum;
                }

            }
            namespace WorkTemperture
            {
                public class WorkTemperture
                {

                }

            }
            namespace Tamper
            {
                public class Tamper
                {

                }

            }
            namespace PPZY
            {
                public class PPZY
                {
                    

                }

            }
            namespace CP
            {
                public class CP
                {
                    public class Programms
                    {
                        public class ProgrammReley
                        {

                        }

                        public class ProgrammIndicators
                        {

                        }

                        public class ProgrammSheif
                        {

                        }
                    }
                }

            }
            namespace Key
            {
                public class Key
                {

                }

            }
        }
        namespace RadialLoops
        {
            public class PriborsRadialLoops : Bolid.Deviecs.Priobor
            {
                public Bolid.Deviecs.ComponentsDevice.Indicator.Indicator[] IndicatorsReleay;
                public Bolid.Deviecs.ComponentsDevice.Shleif.Shleif[] Shleif;
                public Bolid.Deviecs.ComponentsDevice.Indicator.Indicator[] IndicatorShleif;
                public Bolid.Deviecs.ComponentsDevice.Key.Key[] KeysShleif;
            }
        }
        public class Priobor
        {
            public Bolid.Deviecs.ComponentsDevice.Power.Power Power;
            public Bolid.Deviecs.ComponentsDevice.RS485.RS485 RS485;            
            public Bolid.Deviecs.ComponentsDevice.Tamper.Tamper Tamper;
            public Bolid.Deviecs.ComponentsDevice.Indicator.Indicator IndicatorWork;
        }
    }
}