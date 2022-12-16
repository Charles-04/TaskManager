using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application;

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
            stringBuilder.AppendLine($"5 Create a background thread");
            stringBuilder.AppendLine($"6 Check thread status (Live or Background)");
            stringBuilder.AppendLine($"7 Exit");

        }
        
        public static void DisplayMenu()
        {
            Console.WriteLine(stringBuilder);
        }

        public static void Run()
        {
            Run: try {
               
                DisplayMenu();
                var option = int.Parse(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        TaskManger.StartANewTask();
                        goto Run;
                    case 2:
                        Console.Clear();
                        TaskManger.KillATask();
                        goto Run;
                    case 3:
                        Console.Clear();
                        TaskManger.ListAllRunningTasks();
                        goto Run;
                    case 4:
                        Console.Clear();
                        TaskManger.StartACustomProcess();
                        goto Run;
                    case 5:
                        Console.Clear();
                        TaskManger.StartAThread();
                        goto Run;
                    case 6:
                        Console.Clear();
                        TaskManger.CheckThreadStatus();
                        goto Run;
                    case 7:
                        Environment.Exit(000);
                        break;
                    default:
                        Console.WriteLine("Incorrect Option");
                        goto Run;
                   
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Run;
            }
            }
        
    }
}
