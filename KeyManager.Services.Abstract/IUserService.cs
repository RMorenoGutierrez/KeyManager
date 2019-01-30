using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KeyManager.Shared.Models.Dtos;

namespace KeyManager.Services.Abstract
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetUsers();
    }
}
