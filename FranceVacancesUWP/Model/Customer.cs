using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesUWP.Model
{
    class Customer
    {
        private String _name;
        private String _phoneNumber;
        private String _email;
        private String _password;

        public Customer(String name, String phoneNumber, String email, String Password)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _email = email;
            _password = Password;
        }
    }
}
