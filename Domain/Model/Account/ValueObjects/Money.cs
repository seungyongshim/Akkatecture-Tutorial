using Akkatecture.ValueObjects;
using System;

namespace Akkatecture_Tutorial.Domain.Model.Account.ValueObjects
{
    public class Money : SingleValueObject<decimal>
    {
        public Money(decimal value) : base(value)
        {
            if (value < 0)
                throw new ArgumentException(nameof(value));
        }

        public static Money operator -(Money a, Money b) => new Money(a.Value - b.Value);
        public static Money operator +(Money a, Money b) => new Money(a.Value + b.Value);
    }
}
