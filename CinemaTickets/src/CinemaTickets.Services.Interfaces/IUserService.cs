using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaTickets.Domain.Dtos.User;

namespace CinemaTickets.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserWithRolesDto>> GetAllWithRoles();

        Task SaveUsersWithRoles(List<UserWithRolesDto> users);
    }
}