public class Bolid
{
    public class EvetsPribors
    {
        public enum PowerEvents {АварияИсточникаПитания, НормаИсточникаПитания};
    }
    public class PriborsRadialLoops
    {
        public Bolid.PriborСomponents.Power Power;
        public Bolid.PriborСomponents.RS485 RS485;
        public Bolid.PriborСomponents.PPZY PPZY;
        public Bolid.PriborСomponents.CP CP;
        public Bolid.PriborСomponents.Tamper Tamper;
        public Bolid.PriborСomponents.Shleif[] Shleif;
        public Bolid.PriborСomponents.Indicator IndicatorWork;
        public Bolid.PriborСomponents.Indicator IndicatorReley1;
        public Bolid.PriborСomponents.Indicator IndicatorReley2;
        public Bolid.PriborСomponents.Indicator IndicatorReley3;
        public Bolid.PriborСomponents.Indicator[] IndicatorShleif;
        }
    public class PriborСomponents
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
            public event OutStatePower Notify;
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
                
                Bolid.EvetsPribors.PowerEvents StatePower = Bolid.EvetsPribors.PowerEvents.АварияИсточникаПитания;
                StateVolt = GetV;
                if (StateVolt < VMinimum)
                {
                    //MessagePower("")
                }
                else if (StateVolt > VMinimum)
                {

                }
                else
                {

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

        }
    }

}