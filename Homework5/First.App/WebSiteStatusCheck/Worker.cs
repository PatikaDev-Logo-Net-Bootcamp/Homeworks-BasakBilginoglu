using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WebSiteStatusCheck
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private HttpClient httpClient;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }


        public override Task StartAsync(CancellationToken cancellationToken)
        {
            httpClient = new HttpClient();
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            httpClient.Dispose();
            return base.StopAsync(cancellationToken);
        }

        public override void Dispose()
        {
            base.Dispose();
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var request = await httpClient.GetAsync("https://www.patika.dev/");
                if (request.IsSuccessStatusCode)
                {
                    _logger.LogInformation("Patika.dev site is up Status Code {StatusCode}",request.StatusCode);
                }
                else
                {
                    _logger.LogError("Patika.dev site is down Status Code {StatusCode}", request.StatusCode);
                }
               
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
