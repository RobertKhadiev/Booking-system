using Aero_booking_system.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aero_booking_system.Domain.Interfaces
{
    public interface IUserService
    {
        public List<UserModel> GetAll();
        public UserModel GetById(long userId);
        public Task<long> CreateUser(UserModel userModel);
    }
}
