using BackgroundQueue.API.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundQueue.API.Background
{
    public class BackgroundWorker : BackgroundService
    {
        private readonly IBackgroundQueue<Book> queue;
        private readonly IServiceScopeFactory serviceFactory;
        private readonly ILogger<BackgroundWorker> logger;

        public BackgroundWorker(IBackgroundQueue<Book> queue, IServiceScopeFactory serviceFactory, ILogger<BackgroundWorker> logger)
        {
            this.queue = queue;
            this.serviceFactory = serviceFactory;
            this.logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger.LogInformation("{Type} is now running in the background.", nameof(BackgroundWorker));
            await BackgroundProcessing(stoppingToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogCritical("The {Type} is stopping due to a host shutdown, queued items might not be processed anymore.", nameof(BackgroundWorker));
            return base.StopAsync(cancellationToken);
        }

        private async Task BackgroundProcessing(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await Task.Delay(500, stoppingToken);
                    var book = queue.Dequeue();
                    if (book == null) continue;

                    logger.LogInformation("Book Found! Starting to process");
                    using (var scope = serviceFactory.CreateScope())
                    {
                        var publisher = scope.ServiceProvider.GetRequiredService<IBookPublisher>();
                        await publisher.Publish(book, stoppingToken);
                    }

                }
                catch (System.Exception ex)
                {
                    logger.LogError("An Error when publishing a book. Exception", ex);
                }
            }
        }
    }
}
