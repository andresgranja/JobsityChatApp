using JobsityChatApp.Entities;

namespace JobsityChatApp.Services.Stocks
{
    public interface IStocksBotService
    {
        public BotResponse BotCommand(string code);
    }
}