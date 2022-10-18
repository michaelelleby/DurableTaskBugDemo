using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Hosting;

namespace DurableTaskBugDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var hostBuilder = new HostBuilder()
                .ConfigureWebJobs(config =>
                {
                    config.AddDurableTask(options => { options.HubName = "MyTaskHub"; });
                })
                .UseConsoleLifetime();

            var host = hostBuilder.Build();

            using (host)
            {
                host.Run();
            }
        }
    }
}