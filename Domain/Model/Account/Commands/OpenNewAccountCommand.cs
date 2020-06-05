using Akkatecture.Commands;
using Akkatecture_Tutorial.Domain.Model.Account.ValueObjects;
using System;

namespace Akkatecture_Tutorial.Domain.Model.Account.Commands
{
    public class OpenNewAccountCommand : Command<Account, AccountId>
    {
        public Money OpeningBalance { get; }

        public OpenNewAccountCommand(AccountId aggregateId, Money openingBalance) : base(aggregateId)
        {
            OpeningBalance = openingBalance ?? throw new ArgumentNullException(nameof(openingBalance));
        }
    }
}
