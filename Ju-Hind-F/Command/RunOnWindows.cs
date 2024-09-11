using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firetruck.Utils;

namespace firetruck.Command
{
    internal class RunOnWindows
    {
        public static void RunCmd(List<string> commands)
        {

            string structured_command = "";

            for (int i = 0; i < commands.Count; i++)
            { 
                structured_command = structured_command + " " +commands[i];
            }

            //firetruckOutput.result(structured_command);

            //IMPLEMENT ACTUAL WAY OF RUNNING COMMANDS
        
        }
    }
}
