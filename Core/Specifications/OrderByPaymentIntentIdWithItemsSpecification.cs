﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrderByPaymentIntentIdSpecification : BaseSpecification<Order>
    {
        public OrderByPaymentIntentIdSpecification(string paymentIntentId)
            : base (o => o.PaymentItentId == paymentIntentId)
        {
            
        }
    }
}