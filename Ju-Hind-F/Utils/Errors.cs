using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using firetruck.Utils;

namespace firetruck.Utils
{
    internal class Errors
    {
        
    }

    public class firetruckErrorList
    {
        public static List<string> ErrorsAre   = [];
        public static void New(string err_msg)
        {
            ErrorsAre.Add(err_msg);

            //Console.WriteLine(ErrorsAre.ToArray());
        }

        public static void CacheClean()
        {

            ErrorsAre.Clear();

        }

        public static void ListThem()
        {
            //BreakPoint.hit("listthem");
            if (ErrorsAre.Count > 0)
            {
                if (ErrorsAre.Count > 0 && ErrorsAre.Count < 20)
                {
                    firetruckOutput.errinfo($"Got {ErrorsAre.Count} Errors: Listing {ErrorsAre.Count} out of {ErrorsAre.Count} Errors!");
                    for (int i = 0; i <= (ErrorsAre.Count() - 1); i++)
                    {
                        firetruckOutput.err(ErrorsAre[i],"err");
                    }
                }
                else if (ErrorsAre.Count > 20)
                {
                    firetruckOutput.errinfo($"Got {ErrorsAre.Count} Errors: Listing 20 out of {ErrorsAre.Count} Errors!");
                    for (int i = 0; i <= (21); i++)
                    {
                        firetruckOutput.err(ErrorsAre[i],"err");
                    }
                }
                else 
                {
                    firetruckOutput.errinfo($"Got {ErrorsAre.Count} Errors: Listing {ErrorsAre.Count} out of {ErrorsAre.Count} Errors!");
                    for (int i = 0; i <= (ErrorsAre.Count() - 1); i++)
                    {
                        firetruckOutput.err(ErrorsAre[i],"err");
                    }
                }
            }
            else 
            {
                firetruckOutput.warninfo("0 Errors Found!");
            }       
        }

        public static void ListThemAll()
        {
            //BreakPoint.hit("listthem");
            if (ErrorsAre.Count > 0)
            {
                firetruckOutput.errinfo($"Got {ErrorsAre.Count} Errors: Listing {ErrorsAre.Count} out of {ErrorsAre.Count} Errors!");
                for (int i = 0; i <= (ErrorsAre.Count() - 1); i++)
                {
                    firetruckOutput.err(ErrorsAre[i],"err");
                }
            }
            else
            {
                firetruckOutput.warninfo("0 Errors Found!");
            }
        }
    }
}
