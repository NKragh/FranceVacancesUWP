using System.Collections.Generic;

namespace FranceVacancesUWP.Model
{
    class House
    {
        #region Properties
        private string _location;
        private double _price;
        private int _rooms;
        private int _ratingOfficial;
        private int _ratingGuest;
        private string _destinationType;

        private Dictionary<string, bool> facilitiesDict = new Dictionary<string, bool>()
        {
            {"Internet", false},
            {"Breakfast", false},
            {"Dinner", false},
            {"Pets", false},
            {"Pool", false},
            {"Parking", false},
            {"Aircondition", false},
            {"Kitchen", false},
            {"Elevator", false},
        };
        #endregion

        #region Constructor

        public House()
        {

        }

        public House(string address, double price, int rooms, string destinationType, Dictionary<string, bool> inputDict)
        {
            _location = address;
            _price = price;
            _rooms = rooms;
            _destinationType = destinationType;

            foreach (KeyValuePair<string, bool> facility in inputDict)
            {
                facilitiesDict[facility.Key] = inputDict[facility.Key];
            }
        }
        #endregion  
    }
}
