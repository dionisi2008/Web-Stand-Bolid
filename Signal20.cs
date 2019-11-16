using System;
using System.Collections.Generic;
using Bolid.Devices.ComponentsDevice.PPZY;

public class Signal20 : Bolid.Devices.RadialLoops.PriborsRadialLoops
{
    new string NamePribor = "Сигнал 20 исп. 02";
    public PPZYSignal20 PPZYSignal;

    public Signal20()
    {
        PPZYSignal = new PPZYSignal20(true);
        this.Power = new Bolid.Devices.ComponentsDevice.Power.Power();
        this.Power.MessageCPPower += ProgressEventPower;
    }

    public void ProgressEventPower(Bolid.Devices.ComponentsDevice.Power.PowerStates GetEvent)
    {
        switch (GetEvent)
        {
            case Bolid.Devices.ComponentsDevice.Power.PowerStates.АварияИсточникаПитания:
                this.IndicatorWork = new Bolid.Devices.ComponentsDevice.Indicator.Indicator(1000, 125, true);
                break;
            case Bolid.Devices.ComponentsDevice.Power.PowerStates.НормаИсточникаПитания:
                this.IndicatorWork = new Bolid.Devices.ComponentsDevice.Indicator.Indicator(true);
                //Переход к фунции чтения из памяти
                
                break;
        }
    }

    public class PPZYSignal20 : PPZY
    {
        private System.Random RandomInfo = new Random(DateTime.Now.Millisecond);
        public byte[] TypeLoop { get; set; } = new byte[20];
        public bool[] RelayManagement1 { get; set; } = new bool[20];
        public bool[] RelayManagement2 { get; set; } = new bool[20];
        public bool[] RelayManagement3 { get; set; } = new bool[20];
        public bool[] ExitControlFlute { get; set; } = new bool[20];
        public bool[] ExitControlLamp { get; set; } = new bool[20];
        public byte[] AlarmDelay { get; set; } = new byte[20];
        public byte[] CaptureDelay { get; set; } = new byte[20];
        public bool[] SilentAlarm { get; set; } = new bool[20];
        public bool[] GroupBondWithdrawal { get; set; } = new bool[20];
        public bool[] Integration300 { get; set; } = new bool[20];
        public bool[] AutoReload { get; set; } = new bool[20];
        public bool[] ProhibitionWithdrawal { get; set; } = new bool[20];
        public bool[] ReEnableSiren { get; set; } = new bool[20];
        public byte[] ExitControlDelayFlute { get; set; } = new byte[20];
        public byte[] ExitControlDelayLamp { get; set; } = new byte[20];
        public byte ManualFireLoopControlMode;
        public bool ProhibitionIndicationTakenLoop;
        public byte[] RelayControlProgramNumber = new byte[5];
        public byte[] RelayControlTime = new byte[5];
        public PPZYSignal20(bool RandomGen)
        {
            RandomInfo.NextBytes(this.AlarmDelay);
            RandomInfo.NextBytes(this.CaptureDelay);
            RandomInfo.NextBytes(this.ExitControlDelayFlute);
            RandomInfo.NextBytes(this.ExitControlDelayLamp);
            RandomInfo.NextBytes(this.RelayControlTime);

            for (int shag = 0; shag <= 19; shag++)
            {
                this.TypeLoop[shag] = GetRandomByte(1, 5);
                this.RelayManagement1[shag] = GetRandomBool();
                this.RelayManagement2[shag] = GetRandomBool();
                this.RelayManagement3[shag] = GetRandomBool();
                this.ExitControlFlute[shag] = GetRandomBool();
                this.ExitControlLamp[shag] = GetRandomBool();
                this.SilentAlarm[shag] = GetRandomBool();
                this.GroupBondWithdrawal[shag] = GetRandomBool();
                this.Integration300[shag] = GetRandomBool();
                this.AutoReload[shag] = GetRandomBool();
                this.ProhibitionWithdrawal[shag] = GetRandomBool();
                this.ReEnableSiren[shag] = GetRandomBool();
            }

            this.ManualFireLoopControlMode = GetRandomByte(1, 4);
            this.ProhibitionIndicationTakenLoop = GetRandomBool();
            for (int shag = 0; shag <= 4; shag++)
            {
                this.RelayControlProgramNumber[shag] = GetRandomByte(0, 30);
            }

        }
        public byte GetRandomByte(int GetMin, int GetMax)
        {
            return System.Convert.ToByte(RandomInfo.Next(GetMin, GetMax));
        }
        public bool GetRandomBool()
        {
            if (GetRandomByte(0, 1) == 0)
            {
                return false;
            }
            return true;
        }
    }

    private void LoadPPZY()
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