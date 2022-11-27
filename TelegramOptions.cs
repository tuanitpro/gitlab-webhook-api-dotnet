namespace beeWebHooksAPI
{
    public interface ITelegramOptions
    {
        string? TelegramToken { get; set; }
        string? TelegramChatId { get; set; }
    }

    public class TelegramOptions : ITelegramOptions
    {
        public string? TelegramToken { get; set; }
        public string? TelegramChatId { get; set; }
    }
}