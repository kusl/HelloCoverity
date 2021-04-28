using Serilog;
using static System.Console;

namespace CoverityConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            Serilog.Log.Logger = new Serilog.LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug) // restricted... is Option
                .CreateLogger();
            for (int i = 0; i < int.MaxValue; i++)
            {
                Log.Information($"The current step is {i}");
            }
        }
    }
}
