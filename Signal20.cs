using System;
using System.Collections.Generic;
using Bolid.Devices.ComponentsDevice.PPZY;

public class Signal20 : Bolid.Devices.RadialLoops.PriborsRadialLoops
{
    public new Bolid.Devices.ComponentsDevice.CP.CPSignal20 CP;
    public new Bolid.Devices.ComponentsDevice.PPZY.PPZYSignal20 PPZY;
    public Signal20()
    {        
        CP = new Bolid.Devices.ComponentsDevice.CP.CPSignal20();
        CP.GetPriborBoard(this);
        NamePribor = "Сигнал 20 исп. 02";
        Power = new Bolid.Devices.ComponentsDevice.Power.Power(CP);
        
    }
}