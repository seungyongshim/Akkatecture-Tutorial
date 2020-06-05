using Akkatecture.Aggregates;
using Akkatecture_Tutorial.Domain.Model.Account.Events;
using Akkatecture_Tutorial.Domain.Model.Account.ValueObjects;

namespace Akkatecture_Tutorial.Domain.Model.Account
{
    public class AccountState : AggregateState<Account, AccountId>,
        IApply<AccountOpenedEvent>,
        IApply<MoneySentEvent>,
        IApply<FeesDeductedEvent>,
        IApply<MoneyReceivedEvent>
    {
        public Money Balance { get; set; }

        public void Apply(AccountOpenedEvent aggregateEvent)
        {
            Balance = aggregateEvent.OpeningBalance;
        }

        public void Apply(MoneySentEvent aggregateEvent)
        {
            Balance -= aggregateEvent.Transaction.Amount;
        }

        public void Apply(FeesDeductedEvent aggregateEvent)
        {
            Balance -= aggregateEvent.Amount;
        }

        public void Apply(MoneyReceivedEvent aggregateEvent)
        {
            Balance += aggregateEvent.Transaction.Amount;
        }
    }
}
