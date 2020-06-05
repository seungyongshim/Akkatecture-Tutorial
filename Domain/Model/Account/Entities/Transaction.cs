using Akkatecture.Entities;
using Akkatecture_Tutorial.Domain.Model.Account.ValueObjects;

namespace Akkatecture_Tutorial.Domain.Model.Account.Entities
{
    public class Transaction: Entity<TransactionId>
    {
        public AccountId Sender { get; }
        public AccountId Receiver { get; }
        public Money Amount { get; }

        public Transaction(TransactionId id, AccountId sender, AccountId receiver, Money amount) : base(id)
        {
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
        }
    }
}
