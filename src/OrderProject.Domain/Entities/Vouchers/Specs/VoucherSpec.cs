﻿using OrderProject.Domain.Entities.Vouchers;
using OrderProject.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Domain.Entities.Vouchers.Specs
{
    public class VoucherSpec : Specification<Voucher>
    {
        public override Expression<Func<Voucher, bool>> ToExpression()
        {
            return discount => discount.ExpirationDate >= DateTime.Now;
        }
    }
}
