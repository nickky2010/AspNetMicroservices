﻿using Ordering.Application.Models;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Infrastructure
{
    internal interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
