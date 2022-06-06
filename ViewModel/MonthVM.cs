using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerForm.ViewModel
{
    internal class MonthVM : ViewModel
    {
        private ObservableCollection<DayVM> items = new();
        public ObservableCollection<DayVM> Items
        {
            get => items;
            set => Set(ref items, value);

        }
        public MonthVM()
        {
            for (int i = 0; i < 29; i++)
                items.Add(new DayVM());
            
        }
    }
}
