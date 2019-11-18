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
                    public CP.CP OutEventCP;
                    public double VMinimum = 10.2;
                    public const double VMaximum = 28;
                    public double StateVolt = 0;
                    public Power(CP.CP GetCPPribor)
                    {
                        OutEventCP = GetCPPribor;
                    }
                    public void ConnctPower(double GetV)
                    {
                        StateVolt = GetV;
                        if (StateVolt < VMinimum || StateVolt > VMaximum)
                        {
                            OutEventCP.EventGetPower(Bolid.Devices.ComponentsDevice.Power.PowerStates.АварияИсточникаПитания);
                        }
                        else
                        {
                            OutEventCP.EventGetPower(Bolid.Devices.ComponentsDevice.Power.PowerStates.НормаИсточникаПитания);
                        }
                    }

                }

            }
        }
    }
}