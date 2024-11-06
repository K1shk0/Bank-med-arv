using System;

namespace Bank
{
    internal sealed class AccountOwner : Person
    {
        public int ID { get; private set; }


        public AccountOwner(int id, string firstName, string lastName) : base(firstName, lastName)
        {
            ID = id;
        }
    }
}
