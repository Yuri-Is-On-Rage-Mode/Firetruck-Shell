using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firetruck.Utils
{
    internal class Warnings
    {
    }

    public class firetruckWarningList
    {
        public static List<string> WarningsAre = [];
        public static void New(string err_msg)
        {
            WarningsAre.Add(err_msg);

            //Console.WriteLine(WarningsAre.ToArray());
        }

        public static void CacheClean()
        {

            WarningsAre.Clear();

        }

        public static void ListThem()
        {
            //BreakPoint.hit("listthem");
            if (WarningsAre.Count > 0)
            {
                if (WarningsAre.Count > 0 && WarningsAre.Count < 20)
                {
                    firetruckOutput.warninfo($"Got {WarningsAre.Count} Warnings: Listing {WarningsAre.Count} out of {WarningsAre.Count} Warnings!");
                    for (int i = 0; i <= (WarningsAre.Count() - 1); i++)
                    {
                        firetruckOutput.warn(WarningsAre[i],"wrn");
                    }
                }
                else if (WarningsAre.Count > 20)
                {
                    firetruckOutput.warninfo($"Got {WarningsAre.Count} Warnings: Listing 20 out of {WarningsAre.Count} Warnings!");
                    for (int i = 0; i <= (21); i++)
                    {
                        firetruckOutput.warn(WarningsAre[i],"wrn");
                    }
                }
                else
                {
                    firetruckOutput.warninfo($"Got {WarningsAre.Count} Warnings: Listing {WarningsAre.Count} out of {WarningsAre.Count} Warnings!");
                    for (int i = 0; i <= (WarningsAre.Count() - 1); i++)
                    {
                        firetruckOutput.warn(WarningsAre[i],"wrn");
                    }
                }
            }
            else
            {
                firetruckOutput.warninfo("0 Warnings Found!");
            }
        }

        public static void ListThemAll()
        {
            //BreakPoint.hit("listthem");
            if (WarningsAre.Count > 0)
            {
                firetruckOutput.warninfo($"Got {WarningsAre.Count} Warnings: Listing {WarningsAre.Count} out of {WarningsAre.Count} Warnings!");
                for (int i = 0; i <= (WarningsAre.Count() - 1); i++)
                {
                    firetruckOutput.warn(WarningsAre[i],"wrn");
                }
            }
            else
            {
                firetruckOutput.warninfo("0 Warnings Found!");
            }
        }
    }
}
