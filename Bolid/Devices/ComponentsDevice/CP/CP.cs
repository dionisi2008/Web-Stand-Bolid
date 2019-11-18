namespace Bolid
{
    namespace Devices
    {
        namespace ComponentsDevice
        {
            namespace CP
            {
                public class CP
                {
                    public Bolid.Devices.Pribor BasePribor;
                    public CP()
                    {


                    }
                    public void GetPriborBoard(Bolid.Devices.Pribor GetBasePribor)
                    {
                        BasePribor = GetBasePribor;
                    }
                    public virtual void LoadPPZY()
                    {

                    }
                    public void EventGetPower(Bolid.Devices.ComponentsDevice.Power.PowerStates GetEvent)
                    {
                        switch (GetEvent)
                        {
                            case Bolid.Devices.ComponentsDevice.Power.PowerStates.АварияИсточникаПитания:
                                BasePribor.IndicatorWork = new Bolid.Devices.ComponentsDevice.Indicator.Indicator(1000, 125, true);
                                //EventOutIndicator("Work", new Bolid.Devices.ComponentsDevice.Indicator.Indicator(1000, 125, true));
                                break;
                            case Bolid.Devices.ComponentsDevice.Power.PowerStates.НормаИсточникаПитания:
                                BasePribor.IndicatorWork = new Bolid.Devices.ComponentsDevice.Indicator.Indicator(true, "Work");
                                //Переход к фунции чтения из памяти
                                break;
                        }
                    }


                }
            }
        }
    }
}