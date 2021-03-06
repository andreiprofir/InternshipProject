﻿using System.Collections.Generic;
using System.Security.Claims;
using CinemaTickets.Domain.Dtos;

namespace CinemaTickets.Services.Interfaces
{
    public interface IOrderService
    {
        long BuyTicketAndGetMovieId(ClaimsPrincipal user, BuyTicketDto model);

        List<OrderDto> GetAllBy(ClaimsPrincipal userClaims);
    }
}