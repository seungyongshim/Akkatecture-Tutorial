using Akkatecture.Aggregates;
using Akkatecture_Tutorial.Domain.Model.Account.ValueObjects;

namespace Akkatecture_Tutorial.Domain.Model.Account
{
    public class AccountState : AggregateState<Account, AccountId>
    {
        public Money Balance { get; set; }
    }
}
