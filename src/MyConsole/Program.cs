using Microsoft.Diagnostics.EventFlow;

namespace MyConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var pipeline = DiagnosticPipelineFactory.CreatePipeline("eventFlowConfig.json"))
            {
                MySuperDuperEventSource.Log.ApplicationStarting();
                MySuperDuperEventSource.Log.UserLogin("Some One");

                DoSomeWork();

                MySuperDuperEventSource.Log.ApplicationEnding();
            }
        }

        private static void DoSomeWork()
        {
            for (int i = 0; i < 3; i++)
            {
                MySuperDuperEventSource.Log.ElementProcessed("Element " + i.ToString());
                Task.Delay(1000).Wait();
            }
        }
    }
}