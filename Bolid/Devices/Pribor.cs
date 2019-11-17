namespace Bolid
{
    namespace Devices
    {
        public class Pribor
        {
            public Bolid.Devices.ComponentsDevice.CP.CP CP;
            public Bolid.Devices.ComponentsDevice.Power.Power Power = new ComponentsDevice.Power.Power(0);
            public Bolid.Devices.ComponentsDevice.RS485.RS485 RS485;
            public Bolid.Devices.ComponentsDevice.Tamper.Tamper Tamper;
            public Bolid.Devices.ComponentsDevice.Indicator.Indicator IndicatorWork = new ComponentsDevice.Indicator.Indicator(false, "Work");
            public Pribor()
            {
                CP = new ComponentsDevice.CP.CP();                
                CP.GetPriborBoard(this);
                this.Power.MessageCPPower += CP.EventGetPower;
                //this.CP.EventOutIndicator += this.IndicatorWork.GetEventCPcommand;
            }
            public void ProgressEventPower(Bolid.Devices.ComponentsDevice.Power.PowerStates GetEvent)
            {
                
            }
        }
    }
}