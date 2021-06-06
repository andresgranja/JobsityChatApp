using JobsityChatApp.Entities;
using JobsityChatApp.Models;
using JobsityChatApp.Services.Stocks;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace JobsityChatApp.Hubs
{
    public class MessageHub : Hub
    {
        private readonly IStocksBotService _stocksBotService;
        public MessageHub(IStocksBotService stocksBotService)
        {
            _stocksBotService = stocksBotService;
        }
        public async Task NewMessage(Message msg)
        {
            await Clients.All.SendAsync("MessageReceived", msg);
            BotResponse botResponse = _stocksBotService.BotCommand(msg.Text);
            if (botResponse.Detected)
                if (botResponse.IsSuccessful)
                    await Clients.All.SendAsync("MessageReceived", BotMessage($"{botResponse.Symbol} quote is {botResponse.Close} per share."));
                else
                    await Clients.All.SendAsync("MessageReceived", BotMessage($"There was a problem with the request. {botResponse.ErrorMessage}"));
        }

        internal Message BotMessage(string msg)
        {
            return new Message
            {
                Text = msg,
                Date = DateTime.Now
            };
        }
    }
}
