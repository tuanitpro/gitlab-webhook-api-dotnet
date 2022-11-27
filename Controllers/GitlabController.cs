using beeWebHooksAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Telegram.Bot;

namespace beeWebHooksAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GitlabController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly ITelegramOptions _telegramOptions;

        public GitlabController(ILoggerFactory loggerFactory, ITelegramOptions telegramOptions)
        {
            _logger = loggerFactory.CreateLogger<GitlabController>();
            _telegramOptions = telegramOptions;
        }

        [HttpPost]
        [Route("incoming")]
        public async Task<IActionResult> Get(JObject obj)
        {
            var str = obj.ToString();
            try
            {
                var rootObject =
                    JsonConvert.DeserializeObject<GitLabPipelineModel>(str);
                if (rootObject != null && rootObject.ObjectKind == "pipeline")
                {
                    if (!string.IsNullOrEmpty(_telegramOptions.TelegramToken) && !string.IsNullOrEmpty(_telegramOptions.TelegramChatId))
                    {
                        TelegramBotClient botClient = new TelegramBotClient(_telegramOptions.TelegramToken);
                        var projectName = rootObject?.Project?.Name;
                        var text = $"{projectName} BUILD_{rootObject?.ObjectAttributes?.Status?.ToUpper()}";
                        await botClient.SendTextMessageAsync(
                            chatId: _telegramOptions.TelegramChatId,
                            text: text
                          );
                    }
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                return Ok("Error");
            }

            return Ok("Done");
        }
    }
}