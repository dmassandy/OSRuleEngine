using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Contact
    {
        public String FullName { get; private set; }
        public String Position { get; private set; }
        public String Phone { get; private set; }
        public String Email { get; private set; }


        public Contact(string fullName, string position, string phone, string email)
        {
            FullName = fullName;
            Position = position;
            Phone = phone;
            Email = email;
        }
    }
}
