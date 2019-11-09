using System;
using System.Collections.Generic;

public class  Signal20 : Bolid.PriborsRadialLoops
{
    public Bolid.Chips.Signal20CP CP;
  
    public Signal20()
    {
        CP = new Bolid.Chips.Signal20CP();
        this.Power.MessageCPPower
        this.Power = new Bolid.PriborСomponents.Power();
        Power.VMaximum = 28;
        Power.VMinimum = 10.2;
    }

}
