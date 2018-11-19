using System.Collections.Generic;
using System.Collections.ObjectModel;

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
            {"Toaster", false},
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


        private ObservableCollection<House> _houseList = new ObservableCollection<House>();

        private Dictionary<string, bool> testdict = new Dictionary<string, bool>()
        {
            {"Internet", true},
            {"Breakfast", false},
            {"Dinner", false},
            {"Pets", true},
            {"Pool", false},
            {"Parking", true},
            {"Aircondition", false},
            {"Kitchen", true},
            {"Elevator", false},
            {"Toaster", true},
        };

        public ObservableCollection<House> HouseList
        {
            get { return _houseList; }
        }

        public void TestHouses()
        {
            _houseList.Add(new House("Testadresse, 1234 Test", 123.4, 3, "Hytte", testdict));
            _houseList.Add(new House("Pariservej, 5620 Paris", 1005, 1, "Værelse", testdict));
            _houseList.Add(new House("Romvej, 6790 Baguette", 2043, 3, "Lejlighed", testdict));
            _houseList.Add(new House("Liegevej, 4310 Croissant", 5000000, 6, "Hus", testdict));
        }

        #region GETTERSETTER
        public string Location{
            get { return _location; }
        }

        public double Price{
            get { return _price; }
            set { _price = value; }
        }

        public int Rooms{
            get { return _rooms; }
            set { _rooms = value; }
        }

        public int RatingOfficial{
            get { return _ratingOfficial; }
            set { _ratingOfficial = value; }
        }

        public int RatingGuest{
            get { return _ratingGuest; }
            set { _ratingGuest = value; }
        }

        public string DestinationType{
            get { return _destinationType; }
            set { _destinationType = value; }
        }
        #endregion
    }
}
