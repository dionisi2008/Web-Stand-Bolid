namespace Bolid
{
    namespace Devices
    {
        public class Pribor
        {
            public string NamePribor;
            public Bolid.Devices.ComponentsDevice.CP.CP CpSignal20;
            public Bolid.Devices.ComponentsDevice.Power.Power Power;
            public Bolid.Devices.ComponentsDevice.RS485.RS485 RS485;
            public Bolid.Devices.ComponentsDevice.Tamper.Tamper Tamper;
            public Bolid.Devices.ComponentsDevice.Indicator.Indicator IndicatorWork;
            public Pribor()
            {
                CpSignal20 = new ComponentsDevice.CP.CP();
                this.Power = new ComponentsDevice.Power.Power();
                Power.MessageCPPower += CpSignal20.EventGetPower;
            }
        }
    }
}