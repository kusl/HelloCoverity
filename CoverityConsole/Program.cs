using Serilog;

namespace CoverityConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug) // restricted... is Option
                .CreateLogger();
            Log.Debug("hello, world!");
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    Log.Debug($"argument is {arg}");
                }
            }
        }
    }
}
