namespace Bolid
{
    namespace Devices
    {
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
        }
    }
}