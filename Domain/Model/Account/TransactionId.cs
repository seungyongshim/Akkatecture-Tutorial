using Akkatecture.Core;

namespace Akkatecture_Tutorial.Domain.Model.Account
{
    public class TransactionId: Identity<TransactionId>
    {
        public TransactionId(string value) : base(value)
        {

        }
    }
}
