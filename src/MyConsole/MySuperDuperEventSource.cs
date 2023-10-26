using System.Diagnostics.Tracing;

namespace MyConsole
{
    [EventSource(Name = "MySuperDuperEventSource")]
    public class MySuperDuperEventSource : EventSource
    {
        public static MySuperDuperEventSource Log = new();

        [Event(1001, Message = "Application Starting")]
        public void ApplicationStarting()
        {
            if (IsEnabled())
            {
                WriteEvent(1001);
            }
        }

        [Event(2001, Message = "User Login: {0}")]
        public void UserLogin(string userName)
        {
            if (IsEnabled())
            {
                WriteEvent(2001, userName);
            }
        }

        [Event(2003, Message = "Element processed: {0}")]
        public void ElementProcessed(string elementName)
        {
            if (IsEnabled())
            {
                WriteEvent(2003, elementName);
            }
        }

        [Event(9001, Message = "Application Ending")]
        public void ApplicationEnding()
        {
            if (IsEnabled())
            {
                WriteEvent(9001);
            }
        }
    }
}