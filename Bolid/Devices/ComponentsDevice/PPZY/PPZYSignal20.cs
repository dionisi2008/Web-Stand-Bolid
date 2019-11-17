using System;

namespace Bolid
{
    namespace Devices
    {
        namespace ComponentsDevice
        {
            namespace PPZY
            {
                public class PPZYSignal20 : PPZY
                {                    
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
                    public bool[] OnLoop = new bool[20];
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
                            this.OnLoop[shag] = GetRandomBool();
                        }

                        this.ManualFireLoopControlMode = GetRandomByte(1, 4);
                        this.ProhibitionIndicationTakenLoop = GetRandomBool();
                        for (int shag = 0; shag <= 4; shag++)
                        {
                            this.RelayControlProgramNumber[shag] = GetRandomByte(0, 30);
                        }

                    }
                  }
            }
        }
    }
}