using System;

namespace FranceVacancesUWP.Model
{
    class Searchbar
    {
        private String _airportTo;
        private String _airportFrom;
        private DateTime? _dateFrom;
        private DateTime? _dateTo;
        private int _people;
        private string _travelType;

        public Searchbar(string travelType, string airportFrom, string airportTo, DateTime? dateInput, int numberOfTravelers)
        {
            //Grib værdier fra UI, hvor brugeren skriver de værdier der skal søges efter, og sæt dem lige med properties.

            _travelType = travelType;
            _airportFrom = airportFrom;
            _airportTo = airportTo;
            _dateFrom = dateInput;
            _dateTo = dateInput;
            _people = numberOfTravelers;
        }

        public void MakeSearch()
        {
            //TODO: Implementer; Skal kunne display de boliger der matcher de valgte properties

            
        }
    }
}
