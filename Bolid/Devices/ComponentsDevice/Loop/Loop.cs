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
        }
    }
}