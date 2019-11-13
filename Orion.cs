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
                namespace StateLoop
                {
                    public enum StatesLoop { Норма, Нарущение, Обрыв, КороткоеЗамыкание, НарушениеБлокировки };
                }
                public class Shleif
                {
                    public Shleif()
                    {

                    }
                    public delegate void EventHandlingPribor(Bolid.Deviecs.ComponentsDevice.Shleif.StateLoop.StatesLoop OutStateLoop);
                    public event EventHandlingPribor EventOutStateLoop;
                    public Bolid.Deviecs.ComponentsDevice.Shleif.StateLoop.StatesLoop StateLoop;
                    public void GetNewStateLoop(Bolid.Deviecs.ComponentsDevice.Shleif.StateLoop.StatesLoop GetState, bool MessagePriborEvent)
                    {
                        StateLoop = GetState;
                        if (MessagePriborEvent)
                        {
                            EventOutStateLoop(GetState);
                        }
                    }
                    public byte NambeLoop;
                    public double NormalResitsMin;
                    public double NormalResistMax;
                    public double ViolationResistMin;
                    public double ViolationResistMax;
                    public double CableBreakResistMin;
                    public double ShortCircuitResistMin;
                    public double Resist;
                    public int ACP;

                }

            }
            namespace Reley
            {
                namespace programs
                {
                    public class Releyprogram0
                    {

                    }
                    public class Releyprogram1
                    {

                    }

                }
                public class Reley
                {
                    public byte ProgramReleay;
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
                    public class programs
                    {
                        public class programReley
                        {

                        }

                        public class programIndicators
                        {

                        }

                        public class programSheif
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
            namespace TypesLoops
            {
                namespace Signal20
                {
                    public class TypeLoop123 : Bolid.Deviecs.ComponentsDevice.Shleif.Shleif
                    {
                        public byte NambeLoop = 1;
                        public TypeLoop123(double GetStartResitLoop)
                        {
                            this.Resist = GetStartResitLoop;
                            this.NormalResitsMin = 2.2;
                            this.NormalResistMax = 5.4;
                            this.ViolationResistMin = 6.6;
                            this.ViolationResistMax = 14.4;
                            this.CableBreakResistMin = 16;
                            this.ShortCircuitResistMin = 0.100;
                        }

                        public void GetNewResistLoop(double GetNewResist)
                        {
                            this.Resist = GetNewResist;
                            if (GetNewResist >= NormalResitsMin && GetNewResist <= NormalResistMax)
                            {
                                GetNewStateLoop(Bolid.Deviecs.ComponentsDevice.Shleif.StateLoop.StatesLoop.Норма, false);
                            }
                            else if (GetNewResist >= ViolationResistMin && GetNewResist <= ViolationResistMax)
                            {
                                GetNewStateLoop(Bolid.Deviecs.ComponentsDevice.Shleif.StateLoop.StatesLoop.Нарущение, true);
                            }
                            else if (GetNewResist >= CableBreakResistMin)
                            {
                                GetNewStateLoop(Bolid.Deviecs.ComponentsDevice.Shleif.StateLoop.StatesLoop.Обрыв, true);
                            }
                            else if (GetNewResist <= ShortCircuitResistMin)
                            {
                                GetNewStateLoop(Bolid.Deviecs.ComponentsDevice.Shleif.StateLoop.StatesLoop.КороткоеЗамыкание, true);
                            }
                        }


                    }
                }
            }
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
            public string NamePribor;
            public Bolid.Deviecs.ComponentsDevice.Power.Power Power;
            public Bolid.Deviecs.ComponentsDevice.RS485.RS485 RS485;
            public Bolid.Deviecs.ComponentsDevice.Tamper.Tamper Tamper;
            public Bolid.Deviecs.ComponentsDevice.Indicator.Indicator IndicatorWork;
            public delegate void GetEventPowerDelegate(Bolid.Deviecs.ComponentsDevice.Power.PowerStates GetEvent);
            public event GetEventPowerDelegate OutEventPower;
        }
    }
}