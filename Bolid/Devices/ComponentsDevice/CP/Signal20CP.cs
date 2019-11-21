namespace Bolid
{
    namespace Devices
    {
        namespace ComponentsDevice
        {
            namespace CP
            {
                public class CPSignal20 : Bolid.Devices.ComponentsDevice.CP.CPRadial
                {
                    public CPSignal20()
                    {

                    }

                    public override void LoadPPZY()
                    {
                        Signal20 GetPriborSignal20 = (Signal20)BasePribor;
                        for (int shag = 0; shag < 19; shag++)
                        {
                            if (GetPriborSignal20.PPZY.TypeLoop[shag] <= 3)
                            {
                                GetPriborSignal20.Loop[shag] = new Bolid.Devices.RadialLoops.TypesLoops.Signal20.TypeLoop123(0);
                            }
                            else if (GetPriborSignal20.PPZY.TypeLoop[shag] == 4)
                            {
                                GetPriborSignal20.Loop[shag] = new Bolid.Devices.RadialLoops.TypesLoops.Signal20.TypeLoop4(0);
                            }
                            else if (GetPriborSignal20.PPZY.TypeLoop[shag] == 5)
                            {
                                GetPriborSignal20.Loop[shag] = new Bolid.Devices.RadialLoops.TypesLoops.Signal20.TypeLoop5(0);
                            }
                        }

                    }
                }
            }
        }
    }
}