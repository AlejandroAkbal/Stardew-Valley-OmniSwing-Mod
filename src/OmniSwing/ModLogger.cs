using StardewModdingAPI;

namespace OmniSwing
{
    internal class ModLogger
    {
        private static IMonitor _Monitor;

        public static void Initialize(IMonitor monitor)
        {
            _Monitor = monitor;
        }

        public static void Debug(string message)
        {
            _Monitor.Log(message, LogLevel.Debug);
        }
    }
}