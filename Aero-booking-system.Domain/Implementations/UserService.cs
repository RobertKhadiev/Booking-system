using Aero_booking_system.DAL;
using Aero_booking_system.DAL.Entities;
using Aero_booking_system.Domain.Interfaces;
using Aero_booking_system.Domain.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aero_booking_system.Domain.Implementations
{
    public class UserService : IUserService
    {
        private readonly BsDbContext _context;
        private readonly IMapper _mapper;

        public UserService(BsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<UserModel> GetAll()
        {
            var users = _context.Users.ToList();
            return _mapper.Map<List<UserModel>>(users);
        }
        public UserModel GetById(long userId)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == userId);
            return _mapper.Map<UserModel>(user);
        }
        public async Task<long> CreateUser(UserModel userModel)
        {
            var user = _mapper.Map<UserEntity>(userModel);
            var result = await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return result.Entity.Id;
        }
    }
}
