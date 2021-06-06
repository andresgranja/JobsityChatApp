using JobsityChatApp.DTO;
using JobsityChatApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsityChatApp.Services.Messages
{
    public interface IMessageService
    {
        public Task<List<Message>> GetMessages();
        public Task<List<Message>> AddMessage(Message msg);
        public void AddMessageFromHub(Message msg);
    }
}
