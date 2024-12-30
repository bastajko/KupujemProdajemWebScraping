using System;
using System.Configuration;
using KupujemProdajemWebScraping.Interfaces;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace KupujemProdajemWebScraping
{
    public class OnceADayTimerTrigger
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private readonly IWebScraper _webScraper;
        private readonly IEmailNotifier _emailNotifier;

        public OnceADayTimerTrigger(
            ILoggerFactory loggerFactory,
            IConfiguration configuration,
            IWebScraper webScraper,
            IEmailNotifier emailNotifier)
        {
            _logger = loggerFactory.CreateLogger<OnceADayTimerTrigger>();
            _configuration = configuration;
            _webScraper = webScraper;
            _emailNotifier = emailNotifier;
        }

        [Function("OnceADayTimerTrigger")]
        public async Task RunAsync([TimerTrigger("0 0 11 * * *")] TimerInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            // Perform web scraping
            var url = _configuration["Values:BaseApiUrl"] ?? throw new NullReferenceException("Empty url in config");
            var results = await _webScraper.ScrapeAsync(url);

            // Send email if results are found
            if (results.Count > 0)
            {
                await _emailNotifier.SendEmailAsync("recipient@example.com", "Interesting Results Found", string.Join("\n", results));
            }

            if (myTimer.ScheduleStatus is not null)
            {
                _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
            }
        }
    }
}
