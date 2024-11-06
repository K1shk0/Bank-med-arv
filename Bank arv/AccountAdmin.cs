using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal sealed class AccountAdmin : Person
    {
        public int IDMed { get; private set; }



        public AccountAdmin(int idMed, string firstName, string lastName) : base(firstName, lastName)
        {
            IDMed = idMed;
        }
    }
}
