using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace FranceVacancesUWP.View
{
    public partial class CreateHouse : Page
    {
        ObservableCollection<string> types = new ObservableCollection<string>();
        public CreateHouse()
        {
            InitializeComponent();

            types.Add("Hus");
            types.Add("Hytte");
            types.Add("Lejlighed");
            types.Add("Værelse");
        }

        
    }
}
