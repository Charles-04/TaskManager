using System.Diagnostics;
namespace TaskManager
{
    internal class Program
    {
        public static int _verbId;
        public static Process? _Process = null;

        static void Main(string[] args)
        {
            /*  static void StartAProccess()
              {
                  try
                  {
                      *//*valid file name: C:/Users/KELLYNCODES/Downloads/OIP.jpg*//*
                      Console.Title = "Start a Task";
                      Console.WriteLine("Enter file name to open");
                      string fileInput = Console.ReadLine() ?? string.Empty;
                      Console.WriteLine("Enter text to serach");
                      string BrowserTab = Console.ReadLine() ?? string.Empty;
                      ProcessStartInfo processStart = new($@"{fileInput.Trim()}", $"{BrowserTab}");
                      _verbId = 0;
                      foreach (var verb in processStart.Verb)
                      {
                          Console.WriteLine($"{_verbId++} {verb}");
                      }

                      processStart.WindowStyle = ProcessWindowStyle.Normal;
                      processStart.Verb = "Open";
                      processStart.UseShellExecute = true;
                      _Process = Process.Start(processStart);

                  }
                  catch (Exception exceptonMessage)
                  {
                      Console.WriteLine(exceptonMessage.Message);
                      StartAProccess();
                  }

              }
              StartAProccess();*/


            Application.TaskManger.StartANewProcess("Spotify");
        }
    }
}