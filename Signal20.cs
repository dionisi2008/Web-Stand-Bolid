using System;
using System.Collections.Generic;

public class Signal20 : Bolid.PriborsRadialLoops
{

    public Signal20()
    {
        this.Power = new Bolid.PriborСomponents.Power();
        Power.VMaximum = 28;
        Power.VMinimum = 10.2;
    }
}