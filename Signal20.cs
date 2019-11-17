using System;
using System.Collections.Generic;
using Bolid.Devices.ComponentsDevice.PPZY;

public class Signal20 : Bolid.Devices.RadialLoops.PriborsRadialLoops
{
    new string NamePribor = "Сигнал 20 исп. 02";
    public PPZYSignal20 PPZYSignal;

    public Signal20()
    {
        CP = new Bolid.Devices.ComponentsDevice.CP.CPSignal20();
        this.Loop = new Bolid.Devices.ComponentsDevice.Loop.Loop[20];
        PPZYSignal = new PPZYSignal20(true);
        LoadPPZYSignal20(this);
    }



    public void LoadPPZYSignal20(Signal20 a)
    {
        for (int shag = 0; shag < 19; shag++)
        {
            if (this.PPZYSignal.TypeLoop[shag] <= 3)
            {
                this.Loop[shag] = new Bolid.Devices.RadialLoops.TypesLoops.Signal20.TypeLoop123(0);
            }
            else if (this.PPZYSignal.TypeLoop[shag] == 4)
            {
                this.Loop[shag] = new Bolid.Devices.RadialLoops.TypesLoops.Signal20.TypeLoop4(0);
            }
            else if (this.PPZYSignal.TypeLoop[shag] == 5)
            {
                this.Loop[shag] = new Bolid.Devices.RadialLoops.TypesLoops.Signal20.TypeLoop5(0);
            }
        }

    }
}