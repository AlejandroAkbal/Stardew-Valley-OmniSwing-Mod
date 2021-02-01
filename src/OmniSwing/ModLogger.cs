using StardewModdingAPI;

namespace OmniSwing
{
    public static class ModLogger
    {
        private static readonly IMonitor Monitor = ModEntry.Instance.Monitor;

        public static void Trace(string message)
        {
            Monitor.Log(message, LogLevel.Trace);
        }
    }
}