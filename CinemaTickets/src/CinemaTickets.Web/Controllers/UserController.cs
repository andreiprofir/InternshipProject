using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CinemaTickets.Domain.Dtos.User;
using CinemaTickets.Infrastructure.Data.Models.Identity;
using CinemaTickets.Services.Application.ViewModels.User;
using CinemaTickets.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTickets.Web.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;
        private IMapper _mapper;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [Route("/users")]
        public async Task<IActionResult> Index()
        {
            List<UserWithRolesDto> source = await _userService.GetAllWithRoles();

            List<UserForListViewModels> model = _mapper.Map<List<UserForListViewModels>>(source);

            return View(model);
        }

        [Route("/users")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(List<UserForListViewModels> users)
        {
            if (!ModelState.IsValid)
                return View(users);

            List<UserWithRolesDto> destination = _mapper.Map<List<UserWithRolesDto>>(users);
            await _userService.SaveUsersWithRoles(destination);

            return RedirectToAction("Index");
        }
    }
}