using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CinemaTickets.Domain.Dtos.User;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Models.Identity;
using CinemaTickets.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class UserService : IUserService
    {
        private IMapper _mapper;
        private UserManager<User> _userManager;
        private IRepository<User> _userRepository;

        public UserService(IMapper mapper, UserManager<User> userManager, IRepository<User> userRepository)
        {
            _mapper = mapper;
            _userManager = userManager;
            _userRepository = userRepository;
        }

        public async Task<List<UserWithRolesDto>> GetAllWithRoles()
        {
            List<User> source = _userRepository.GetAll();

            List<UserWithRolesDto> result = _mapper.Map<List<UserWithRolesDto>>(source);

            for (int i = 0; i < source.Count; i++)
            {
                result[i].Roles = (await _userManager.GetRolesAsync(source[i])).ToList();
            }

            return result;
        }

        public async Task SaveUsersWithRoles(List<UserWithRolesDto> users)
        {
            if (users == null) throw new ArgumentNullException(paramName: nameof(users));

            foreach (var user in users)
            {
                if (user.Roles == null) continue;

                User userFromDb = await _userManager.FindByEmailAsync(user.Email);

                if (userFromDb != null)
                {
                    IList<string> rolesFromDb = await _userManager.GetRolesAsync(userFromDb);

                    IEnumerable<string> rolesForDelete = rolesFromDb.Except(user.Roles).ToList();
                    IEnumerable<string> rolesForAdd = user.Roles.Except(rolesFromDb);
                    
                    await _userManager.RemoveFromRolesAsync(userFromDb, rolesForDelete);
                    await _userManager.AddToRolesAsync(userFromDb, rolesForAdd);
                }
            }
        }
    }
}