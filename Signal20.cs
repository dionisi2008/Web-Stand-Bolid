using System;
using System.Collections.Generic;

public class  Signal20 : Bolid.PriborsRadialLoops
{
    public delegate void GetEventPowerDelegate(Bolid.EvetsPribors.PowerEvents GetEvent);
    public event GetEventPowerDelegate OutEventPower;
    public Signal20()
    {
        this.Power = new Bolid.PriborСomponents.Power();
        this.Power.MessageCPPower += ProgressEventPower;
        Power.VMaximum = 28;
        Power.VMinimum = 10.2;
    }

    public void ProgressEventPower(Bolid.EvetsPribors.PowerEvents GetEvent)
    {
        switch (GetEvent)
        {
            case Bolid.EvetsPribors.PowerEvents.АварияИсточникаПитания:
                this.IndicatorWork = new Bolid.PriborСomponents.Indicator(1000, 125, true);
            break;
            case Bolid.EvetsPribors.PowerEvents.НормаИсточникаПитания:
                this.IndicatorWork = new Bolid.PriborСomponents.Indicator(true); 
                //Переход к фунции чтения из памяти
            break;
        }
    }

}