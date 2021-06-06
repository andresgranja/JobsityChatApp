using JobsityChatApp.DTO;
using JobsityChatApp.DTO.Users;
using JobsityChatApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobsityChatApp.Services.Users
{
    public interface IUserService
    {
        public Task<List<GetUserDto>> GetAllUsers();
        public Task<GetUserDto> GetUserById(int id);
        public Task<List<GetUserDto>> AddUser(AddUserDto user);
    }
}
