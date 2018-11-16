using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesUWP.Model
{
    class Filters
    {
        List<String> _facilities = new List<string>();
        List<String> _houseType = new List<string>();
        private IEnumerable<int> _priceRange = Enumerable.Range(0, 10000);
        private int _ratingOfficial;
        private int _ratingGuest;
        private bool _travelFood;
        private string _travelClass;
        private int _roomAmount;

        public Filters(IEnumerable<int> excludePriceRange, List<string> facilities, List<string> houseType, int ratingOfficial, int ratingGuest, bool travelFood, string travelClass, int roomAmount)
        {
            _priceRange = _priceRange.Except(excludePriceRange);
            _facilities = facilities;
            _houseType = houseType;
            _ratingOfficial = ratingOfficial;
            _ratingGuest = ratingGuest;
            _travelFood = travelFood;
            _travelClass = travelClass;
            _roomAmount = roomAmount;
        }

        public void ApplyFilter()
        {
            //TODO: Metode til at applyfilter ud fra checkliste.
        }
    }
}
