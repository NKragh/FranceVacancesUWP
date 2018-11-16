using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesUWP.Model
{
    class Booking
    {
        private String _name;
        private DateTime _birthdate;
        private String _phoneNumber;
        private String _email;
        private String _gender;

        public Booking(string name, DateTime birthdate, string phoneNumber, string email, string gender)
        {
            _name = name;
            _birthdate = birthdate;
            _phoneNumber = phoneNumber;
            _email = email;
            _gender = gender;
        }
        
    }
}
