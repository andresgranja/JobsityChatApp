using JobsityChatApp.DTO;
using JobsityChatApp.Models;
using JobsityChatApp.Services.Messages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JobsityChatApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        [HttpGet]
        public async Task<IActionResult> GetMessages()
        {
            return Ok(await _messageService.GetMessages());
        }
        [HttpPost]
        public async Task<IActionResult> AddMessage(Message message)
        {
            return Ok(await _messageService.AddMessage(message));
        }
    }
}
