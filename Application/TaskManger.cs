using System.Diagnostics;
using System.Text;

namespace TaskManager.Application
{
    internal static class TaskManger
    {
        private static StringBuilder stringBuilder = new();
       
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
        public static void StartACustomProcess()
        {

         
         try
            {

                ProcessStartInfo customProcessInfo = new("Spotify");
              
                customProcessInfo.WindowStyle = ProcessWindowStyle.Maximized;
                customProcessInfo.Verb = "Open";
                customProcessInfo.UseShellExecute = true;
                Process.Start(customProcessInfo);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        public static void StartAThread()
        {
            Thread newThread = new(CookFood);
        }

        public static void CookFood()
        {
            Console.WriteLine("Preparing Breakfast\n");
            Console.WriteLine("Toasting bread....");
            Thread.Sleep(3000);
            Console.WriteLine("Brewing coffee....");
            Thread.Sleep(3000);
            Console.WriteLine("Frying eggs....");
            Thread.Sleep(3000);
            Console.WriteLine("BreakFast is ready!!! ");

            }
    }
}
