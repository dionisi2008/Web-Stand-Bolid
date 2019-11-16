using System.Timers;
namespace Bolid
{
    namespace Devices
    {
        namespace ComponentsDevice
        {
            namespace Indicator
            {
                public class Indicator
                {
                    public Timer AllForTime;
                    public Timer OnTime;
                    public bool StateIndicator = false;
                    public Indicator(bool GetState)
                    {
                        this.StateIndicator = GetState;
                        System.Console.WriteLine("Work Indicator Start");
                    }

                    public Indicator(double GetAllForTime, double GetOnTime, bool StartStete)
                    {
                        AllForTime = new Timer(GetAllForTime);
                        OnTime = new Timer(GetOnTime);
                        AllForTime.Elapsed += FunctionAllTimerPick;
                        OnTime.Elapsed += FunctionOnTimerPick;
                        this.StateIndicator = StartStete;
                        AllForTime.Start();
                    }

                    public void FunctionAllTimerPick(object sender, ElapsedEventArgs e)
                    {
                        System.Console.ForegroundColor = System.ConsoleColor.Green;
                        System.Console.WriteLine("Work Indicator Start");
                        OnTime.Start();
                    }

                    public void FunctionOnTimerPick(object sender, ElapsedEventArgs e)
                    {
                        System.Console.ForegroundColor = System.ConsoleColor.Black;
                        System.Console.WriteLine("Work Indicator Stop");
                        this.StateIndicator = true;
                        this.OnTime.Stop();
                    }

                }
            }
        }
    }
}