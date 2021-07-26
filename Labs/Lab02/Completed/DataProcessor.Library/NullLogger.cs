using System.Threading.Tasks;

namespace DataProcessor.Library
{
    public class NullLogger : ILogger
    {
        public Task LogMessage(string message, string data)
        {
            return Task.CompletedTask;
        }
    }
}
