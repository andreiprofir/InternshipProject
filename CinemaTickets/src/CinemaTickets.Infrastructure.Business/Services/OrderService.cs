using System;
using System.Collections.Generic;
using System.Security.Claims;
using AutoMapper;
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
        private readonly IOrderRepository _orderRepository;
        private readonly IMovieSessionRepository _movieSessionRepository;
        private readonly IRepository<Seat> _seatRepository;
        private readonly UserManager<User> _userManager;
        private readonly ISessionPriceRepository _sessionPriceRepository;
        private readonly IRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public OrderService(
            IMovieSessionRepository movieSessionRepository, 
            IRepository<Seat> seatRepository, 
            UserManager<User> userManager, 
            ISessionPriceRepository sessionPriceRepository, 
            IRepository<Customer> customerRepository, 
            IOrderRepository orderRepository, IMapper mapper)
        {
            _movieSessionRepository = movieSessionRepository;
            _seatRepository = seatRepository;
            _userManager = userManager;
            _sessionPriceRepository = sessionPriceRepository;
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public long BuyTicketAndGetMovieId(ClaimsPrincipal userClaimsPrincipal, BuyTicketDto model)
        {
            User user = _userManager.GetUserAsync(userClaimsPrincipal).Result;
            MovieSession movieSession = _movieSessionRepository.Get(model.MovieSessionId);
            Seat seat = _seatRepository.Get(model.SeatId);

            decimal ticketPrice = _sessionPriceRepository.GetPrice(movieSession.Id, seat.SeatTypeId);
            if (ticketPrice > user.Wallet)
                return movieSession.MovieId;
            else
                user.Wallet -= ticketPrice;

            _userManager.UpdateAsync(user).Wait();

            Customer customer = _customerRepository.Get(user.Id);

            _orderRepository.Add(new Order
            {
                Customer = customer,
                Seat = seat,
                MovieSession = movieSession,
                Identifier = Guid.NewGuid()
            });

            _orderRepository.SaveChanges();

            return movieSession.MovieId;
        }

        public List<OrderDto> GetAllBy(ClaimsPrincipal userClaims)
        {
            User user = _userManager.GetUserAsync(userClaims).Result;

            List<Order> orders = _orderRepository.GetAllBy(user.Id);

            return _mapper.Map<List<Order>, List<OrderDto>>(orders);
        }
    }
}