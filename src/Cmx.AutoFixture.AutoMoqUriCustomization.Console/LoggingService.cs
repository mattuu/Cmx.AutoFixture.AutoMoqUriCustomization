using System.Collections.Generic;

namespace Cmx.AutoFixture.AutoMoqUriCustomization.Console
{
    public class LoggingService : ILoggingService
    {
        private readonly HashSet<string> _messages;

        public LoggingService()
        {
            _messages = new HashSet<string>();
        }

        public void Log(string message)
        {
            _messages.Add(message);
        }
    }
}