using Akkatecture.Commands;
using Akkatecture_Tutorial.Domain.Model.Account.Entities;

namespace Akkatecture_Tutorial.Domain.Model.Account.Commands
{
    public class TransferMoneyCommand: Command<Account, AccountId>
    {
        public Transaction Transaction { get; }

        public TransferMoneyCommand(AccountId aggregateId, Transaction transaction): base (aggregateId)
        {
            Transaction = transaction;
        }
    }
}
