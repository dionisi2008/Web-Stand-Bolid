using System.Timers;


namespace Bolid
{
    namespace Devices
    {
        namespace ComponentsDevice
        {
            namespace Loop
            {
                namespace TypeLoop
                {
                    public enum TypesLoop { Пожарный, Охранный, ОхранныйСКонтролемВскрытияКорпусаИвещателя };
                }
                namespace StateLoop
                {
                    public enum StatesLoop { Норма, Нарущение, Обрыв, КороткоеЗамыкание, НарушениеБлокировки };
                }
                public class Loop
                {
                    public Bolid.Devices.ComponentsDevice.Loop.TypeLoop.TypesLoop TypeLoop;
                    public Loop()
                    {

                    }
                    public delegate void EventHandlingPribor(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop OutStateLoop);
                    public event EventHandlingPribor EventOutStateLoop;
                    public Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop StateLoop;
                    public void GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop GetState, bool MessagePriborEvent)
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
                    public double blockingViolationMin;
                    public double blockingViolationMax;
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
                    public double VMinimum = 10.2;
                    public const double VMaximum = 28;
                    public double StateVolt = 0;
                    public delegate void OutStatePower(Bolid.Devices.ComponentsDevice.Power.PowerStates State);
                    public event OutStatePower MessageCPPower;
                    public Power()
                    {

                    }

                    public Power(double GetV)
                    {
                        StateVolt = GetV;
                    }



                    public void ConnctPower(double GetV)
                    {
                        StateVolt = GetV;
                        if (StateVolt < VMinimum)
                        {
                            MessageCPPower(Bolid.Devices.ComponentsDevice.Power.PowerStates.АварияИсточникаПитания);
                        }
                        else if (StateVolt > VMinimum)
                        {
                            MessageCPPower(Bolid.Devices.ComponentsDevice.Power.PowerStates.АварияИсточникаПитания);
                        }
                        else
                        {
                            MessageCPPower(Bolid.Devices.ComponentsDevice.Power.PowerStates.НормаИсточникаПитания);
                        }
                    }

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
                    public CP()
                    {

                    }
                    public void EventGetPower(Bolid.Devices.ComponentsDevice.Power.PowerStates GetStatePower)
                    {
                        System.Console.WriteLine("s");
                    }

                }
                namespace RadialLoopsCP
                {
                    public class Signal20CP
                    {

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
                    public class TypeLoop123 : Bolid.Devices.ComponentsDevice.Loop.Loop
                    {

                        public TypeLoop123(double GetStartResitLoop)
                        {
                            this.TypeLoop = Bolid.Devices.ComponentsDevice.Loop.TypeLoop.TypesLoop.Пожарный;
                            this.NambeLoop = 1;
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
                            if (GetNewResist >= NormalResitsMin || GetNewResist <= NormalResistMax)
                            {
                                GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop.Норма, false);
                            }
                            else if (GetNewResist >= ViolationResistMin || GetNewResist <= ViolationResistMax)
                            {
                                GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop.Нарущение, true);
                            }
                            else if (GetNewResist >= CableBreakResistMin)
                            {
                                GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop.Обрыв, true);
                            }
                            else if (GetNewResist <= ShortCircuitResistMin)
                            {
                                GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop.КороткоеЗамыкание, true);
                            }
                        }


                    }
                    public class TypeLoop4 : Bolid.Devices.ComponentsDevice.Loop.Loop
                    {
                        public TypeLoop4(double GetStartResitLoop)
                        {
                            this.TypeLoop = Bolid.Devices.ComponentsDevice.Loop.TypeLoop.TypesLoop.Охранный;
                            this.NambeLoop = 4;
                            this.Resist = GetStartResitLoop;
                            this.NormalResitsMin = 2.2;
                            this.NormalResistMax = 9.9;
                            this.ViolationResistMin = 12.1;
                            this.ViolationResistMax = 1.8;
                        }
                        public void GetNewResistLoop(double GetNewResist)
                        {
                            this.Resist = GetNewResist;
                            if (GetNewResist >= NormalResitsMin || GetNewResist <= NormalResistMax)
                            {
                                GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop.Норма, false);
                            }
                            else if (GetNewResist >= ViolationResistMin || GetNewResist <= ViolationResistMax)
                            {
                                GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop.Нарущение, true);
                            }
                        }

                    }
                    public class TypeLoop5 : Bolid.Devices.ComponentsDevice.Loop.Loop
                    {
                        public TypeLoop5(double GetStartResitLoop)
                        {
                            this.TypeLoop = Bolid.Devices.ComponentsDevice.Loop.TypeLoop.TypesLoop.Охранный;
                            this.NambeLoop = 5;
                            this.Resist = GetStartResitLoop;
                            this.NormalResitsMin = 2.5;
                            this.NormalResistMax = 5.4;
                            this.ViolationResistMin = 1.8;
                            this.ViolationResistMax = 6.6;
                            this.ShortCircuitResistMin = 1.8;
                            blockingViolationMin = 6.6;
                            blockingViolationMax = 9.0;
                        }
                        public void GetNewResistLoop(double GetNewResist)
                        {
                            this.Resist = GetNewResist;
                            if (GetNewResist >= NormalResitsMin || GetNewResist <= NormalResistMax)
                            {
                                GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop.Норма, false);
                            }
                            else if (GetNewResist <= ViolationResistMin || GetNewResist >= ViolationResistMax)
                            {
                                GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop.Нарущение, true);
                            }
                            else if (GetNewResist <= ShortCircuitResistMin)
                            {
                                GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop.КороткоеЗамыкание, true);
                            }
                            else if (GetNewResist >= blockingViolationMin || GetNewResist <= ViolationResistMax)
                            {
                                GetNewStateLoop(Bolid.Devices.ComponentsDevice.Loop.StateLoop.StatesLoop.НарушениеБлокировки, true);
                            }
                        }

                    }

                }
            }
            public class PriborsRadialLoops : Bolid.Devices.Pribor
            {
                public Bolid.Devices.ComponentsDevice.Indicator.Indicator[] IndicatorsReleay;
                public Bolid.Devices.ComponentsDevice.Loop.Loop[] Loop;
                public Bolid.Devices.ComponentsDevice.Indicator.Indicator[] IndicatorLoop;
                public Bolid.Devices.ComponentsDevice.Key.Key[] KeysLoop;
            }
        }
    }
}