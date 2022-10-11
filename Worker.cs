
using turacican.Mydll;

namespace workerApp;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        //while (!stoppingToken.IsCancellationRequested)
        //{
        //    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        //    await Task.Delay(1000, stoppingToken);
        //}

        //_logger.LogInformation(TuracicanMydll.Yazdir("Mevlut") + " :D");

        TuracicanMydll.MyFunct();

    }

    public override async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Started service");
        await base.StartAsync(cancellationToken);
    }

    public override async Task StopAsync(CancellationToken cancellationToken)
    {
        await base.StopAsync(cancellationToken);
    }

    public override void Dispose()
    {
    }


}