using Akkatecture.Aggregates;
using Akkatecture_Tutorial.Domain.Model.Account.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akkatecture_Tutorial.Domain.Model.Account.Events
{
    public class AccountOpenedEvent : AggregateEvent<Account, AccountId>
    {
        public Money OpeningBalance { get; }
        public AccountOpenedEvent(Money openingBalance)
        {
            OpeningBalance = openingBalance;
        }
    }
}
