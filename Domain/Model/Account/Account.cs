using Akkatecture.Aggregates;

namespace Akkatecture_Tutorial.Domain.Model.Account
{
    public class Account : AggregateRoot<Account, AccountId, AccountState>
    {
        public Account(AccountId id) : base(id)
        {
        }
    }
}
