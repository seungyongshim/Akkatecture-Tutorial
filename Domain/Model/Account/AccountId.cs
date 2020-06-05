using Akkatecture.Core;

namespace Akkatecture_Tutorial.Domain.Model.Account
{
    public class AccountId: Identity<AccountId>
    {
        public AccountId(string value) : base(value)
        {

        }
    }
}
