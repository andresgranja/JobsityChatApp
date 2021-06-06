using JobsityChatApp.Models;

namespace StocksBot.Services.StocksBot
{
    public interface IStocksBotService
    {
        Stock GetStock(string code);
    }
}