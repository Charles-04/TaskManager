using System.Diagnostics;

namespace TaskManager.Application
{
    internal partial class TaskManger
    {
       
        public static void ListAllRunningTasks()
        {
         
          var runningTasks = Process.GetProcesses().OrderBy((x) => (x.ProcessName));    


            foreach (var task in runningTasks)
            {
                Console.WriteLine($" Task ID: {task.Id}\t TaskName: {task.ProcessName}");
            }
        }
        public static void KillATask()
        {
            try
            {
                Console.WriteLine("Enter Task name");
                var name = Console.ReadLine();

                foreach (var item in Process.GetProcessesByName(name))
                {
                    item.Kill(true);
                }

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void StartANewTask()
        {

            Process? process = null;

        StartTask: try
            {
                Console.WriteLine("Enter Task name");
                var name = Console.ReadLine();
                process = Process.Start(@$"{name}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                goto StartTask;
            }
        }
        public static void StartAThread()
        {
            Thread newThread = new();
        }

    }
}
