﻿using MediatR;
using ProjectE.Application.Responses;
using ProjectE.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectE.Application.Commands.Customers.CreateCustomers
{
    public class CreateCustomerCommand : IRequest<Response>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        public Customer ToEntity()
            => new(Name, Email, BirthDate, true);
    }
}
