namespace Bolid
{
    namespace Devices
    {
        namespace ComponentsDevice
        {
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
        }
    }
}