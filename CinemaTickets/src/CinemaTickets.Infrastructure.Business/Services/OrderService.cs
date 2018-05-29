using System.Security.Claims;
using CinemaTickets.Domain.Core.Models;
using CinemaTickets.Domain.Dtos;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Models.Identity;
using CinemaTickets.Infrastructure.Data.Repositories.Interfaces;
using CinemaTickets.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace CinemaTickets.Infrastructure.Business.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IMovieSessionRepository _movieSessionRepository;
        private readonly IRepository<Seat> _seatRepository;
        private readonly UserManager<User> _userManager;
        private readonly ISessionPriceRepository _sessionPriceRepository;
        private readonly IRepository<Customer> _customerRepository;

        public OrderService(
            IRepository<Order> orderRepository, 
            IMovieSessionRepository movieSessionRepository, 
            IRepository<Seat> seatRepository, 
            UserManager<User> userManager, 
            ISessionPriceRepository sessionPriceRepository, 
            IRepository<Customer> customerRepository)
        {
            _orderRepository = orderRepository;
            _movieSessionRepository = movieSessionRepository;
            _seatRepository = seatRepository;
            _userManager = userManager;
            _sessionPriceRepository = sessionPriceRepository;
            _customerRepository = customerRepository;
        }

        public long BuyTicketAndGetMovieId(ClaimsPrincipal userClaimsPrincipal, BuyTicketDto model)
        {
            User user = _userManager.GetUserAsync(userClaimsPrincipal).Result;
            MovieSession movieSession = _movieSessionRepository.Get(model.MovieSessionId);
            Seat seat = _seatRepository.Get(model.SeatId);

            decimal ticketPrice = _sessionPriceRepository.GetPrice(movieSession.Id, seat.SeatTypeId);
            if (ticketPrice < 1 && user.Wallet >= 20)
                user.Wallet -= 20;
            else
                user.Wallet -= ticketPrice;

            _userManager.UpdateAsync(user).Wait();

            Customer customer = _customerRepository.Get(user.Id);

            _orderRepository.Add(new Order
            {
                Customer = customer,
                Seat = seat,
                MovieSession = movieSession
            });

            _orderRepository.SaveChanges();

            return movieSession.MovieId;
        }
    }
}