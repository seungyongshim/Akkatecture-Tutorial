﻿using Akkatecture.Aggregates;
using Akkatecture_Tutorial.Domain.Model.Account.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akkatecture_Tutorial.Domain.Model.Account.Events
{
    public class MoneySentEvent: AggregateEvent<Account, AccountId>
    {
        public Transaction Transaction { get; }
        public MoneySentEvent(Transaction transaction)
        {
            Transaction = transaction;
        }
    }
}
