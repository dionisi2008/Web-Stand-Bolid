public class Bolid
{
    public class PrioborOrion
    {
        public Bolid.PriborСomponents.Power Power;
        public Bolid.PriborСomponents.RS485 RS485;
        public Bolid.PriborСomponents.PPZY PPZY;
        public Bolid.PriborСomponents.Tamper Tamper;
        public Bolid.PriborСomponents.Indicator IndicatorWork;
    }
    public class EvetsPribors
    {
        public enum PowerEvents {АварияИсточникаПитания, НормаИсточникаПитания};
    }
    public class PriborsRadialLoops : PrioborOrion
    {
        public Bolid.PriborСomponents.Indicator[] IndicatorsReleay;
        public Bolid.PriborСomponents.Shleif[] Shleif;
        public Bolid.PriborСomponents.Indicator[] IndicatorShleif;
        public Bolid.PriborСomponents.Key[] KeysShleif;
        }
    public class PriborСomponents
    {

        
        public class Indicator
        {

        }
        public class RS485
        {

        }
        public class RS232
        {

        }
        public class Shleif
        {
            public double KResits;
            public int ACP;
        }
        public class Reley
        {

        }
        public class Power
        {
            public delegate void OutStatePower(Bolid.EvetsPribors.PowerEvents State);
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
                    MessageCPPower(Bolid.EvetsPribors.PowerEvents.АварияИсточникаПитания);
                }
                else if (StateVolt > VMinimum)
                {
                    MessageCPPower(Bolid.EvetsPribors.PowerEvents.АварияИсточникаПитания);
                }
                else
                {
                    MessageCPPower(Bolid.EvetsPribors.PowerEvents.НормаИсточникаПитания);
                }
            }
            public double VMinimum;
            public double VMaximum;
        }
        public class WorkTemperture
        {

        }
        public class Tamper
        {

        }
        public class PPZY
        {

        }
        public class CP
        {
            public class Programms
            {
                public class ProgrammReley
                {

                }

                public class ProgrammIndicators
                {
                    
                }

                public class ProgrammSheif
                {
                    
                }
            }
        }
        public class Key
        {

        }
    }
    public class Chips
    {
        public class Signal20CP : Bolid.PriborСomponents.CP
        {
            public delegate void GetEventsPower(Bolid.EvetsPribors.PowerEvents GetEvetsPower);
            public event GetEventsPower EventPower;
            public Signal20CP()
            {
                
            }
        }
    }
}