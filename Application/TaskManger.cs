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
                ProcessStartInfo customProcessInfo = new($"{name}");

                customProcessInfo.WindowStyle = ProcessWindowStyle.Maximized;
                customProcessInfo.Verb = "Open";
                customProcessInfo.UseShellExecute = true;
                Process.Start(customProcessInfo);
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
            ThreadStart myFunc = new(CookFood);
            Thread newThread = new(myFunc);
            newThread.Priority = ThreadPriority.Highest;
            newThread.Start();
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
        public static void CheckThreadStatus()
        {
            var isAlive = Thread.CurrentThread.IsAlive;
            var isBackground = Thread.CurrentThread.IsBackground;

             Console.WriteLine($" Is Thread Alive : {isAlive} \t Is Thread Background: {isBackground} ");
            
        }
    }
}
