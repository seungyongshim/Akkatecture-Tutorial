using Akkatecture.Aggregates;
using Akkatecture.Commands;

namespace Akkatecture_Tutorial.Domain.Model.Account
{
    public class AccountManager: AggregateManager<Account, AccountId, Command<Account, AccountId>>
    {

    }
}
