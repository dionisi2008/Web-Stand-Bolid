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
                    public string NameIndicator;
                    public Timer AllForTime;
                    public Timer OnTime;
                    public bool StateIndicator = false;
                    public Indicator(bool GetState, string GetNameIndicator)
                    {
                        this.NameIndicator = GetNameIndicator;
                        this.StateIndicator = GetState;
                        System.Console.WriteLine("Work Indicator Start");
                    }

                    public Indicator(double GetAllForTime, double GetOnTime, bool GetStartStete)
                    {
                        AllForTime = new Timer(GetAllForTime);
                        OnTime = new Timer(GetOnTime);
                        AllForTime.Elapsed += FunctionAllTimerPick;
                        OnTime.Elapsed += FunctionOnTimerPick;
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