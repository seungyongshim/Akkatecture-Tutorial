using Akkatecture.Aggregates;
using Akkatecture_Tutorial.Domain.Model.Account.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akkatecture_Tutorial.Domain.Model.Account.Events
{
    public class FeesDeductedEvent: AggregateEvent<Account, AccountId>
    {
        public Money Amount { get; }
        public FeesDeductedEvent(Money amount)
        {
            Amount = amount;
        }
    }
}
