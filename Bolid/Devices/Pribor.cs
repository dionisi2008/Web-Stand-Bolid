namespace Bolid
{
    namespace Devices
    {
        public class Pribor
        {
            public string NamePribor;
            public Bolid.Devices.ComponentsDevice.Power.Power Power;
            public Bolid.Devices.ComponentsDevice.RS485.RS485 RS485 = new ComponentsDevice.RS485.RS485();
            public Bolid.Devices.ComponentsDevice.Tamper.Tamper Tamper = new ComponentsDevice.Tamper.Tamper();
            public Bolid.Devices.ComponentsDevice.Indicator.Indicator IndicatorWork = new ComponentsDevice.Indicator.Indicator(false, "Work");
            public Pribor()
            {                
                
            }
            public void ProgressEventPower(Bolid.Devices.ComponentsDevice.Power.PowerStates GetEvent)
            {
                
            }
        }
    }
}