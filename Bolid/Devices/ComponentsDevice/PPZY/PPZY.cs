using System;
namespace Bolid
{
    namespace Devices
    {
        namespace ComponentsDevice
        {
            namespace PPZY
            {
                public class PPZY
                {
                    public static System.Random RandomInfo = new Random(DateTime.Now.Millisecond);
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

            }
        }
    }
}