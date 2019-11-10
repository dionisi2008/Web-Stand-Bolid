using System;
using System.Collections.Generic;

public class  Signal20 : Bolid.Deviecs.RadialLoops.PriborsRadialLoops
{
  
    public delegate void GetEventPowerDelegate(Bolid.Deviecs.ComponentsDevice.Power.PowerStates GetEvent);
    public event GetEventPowerDelegate OutEventPower;
    public Signal20()
    {
        this.Power = new Bolid.Deviecs.ComponentsDevice.Power.Power();
        this.Power.MessageCPPower += ProgressEventPower;
        Power.VMaximum = 28;
        Power.VMinimum = 10.2;
    }

    public void ProgressEventPower(Bolid.Deviecs.ComponentsDevice.Power.PowerStates GetEvent)
    {
        switch (GetEvent)
        {
            case Bolid.Deviecs.ComponentsDevice.Power.PowerStates.АварияИсточникаПитания:
                this.IndicatorWork = new Bolid.Deviecs.ComponentsDevice.Indicator.Indicator(1000, 125, true);
            break;
            case Bolid.Deviecs.ComponentsDevice.Power.PowerStates.НормаИсточникаПитания:
                this.IndicatorWork = new Bolid.Deviecs.ComponentsDevice.Indicator.Indicator(true); 
                //Переход к фунции чтения из памяти
            break;
        }
    }

}