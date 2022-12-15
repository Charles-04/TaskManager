using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Utility
{
    
    internal static class Util
    {
        private static StringBuilder stringBuilder = new();
        public static void MakeMenu()
        {
            stringBuilder.AppendLine($"Task Manager\n \n \n");
            stringBuilder.AppendLine($"Options");
            stringBuilder.AppendLine($"1 Start a Task");
            stringBuilder.AppendLine($"2 Stop a Task");
            stringBuilder.AppendLine($"3 Get all current Tasks");
            stringBuilder.AppendLine($"4 Start custom process");
            stringBuilder.AppendLine($"6 Create a background thread");
            stringBuilder.AppendLine($"7 Check thread status (Live or Background)");

        }
        
        public static void DisplayMenu()
        {
            Console.WriteLine(stringBuilder);
        }
        
    }
}
