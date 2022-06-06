using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TrackerForm.ViewModel
{
    internal class MonthListVM : ViewModel
    {
        private ObservableCollection<MonthVM> items = new();
        public ObservableCollection<MonthVM> Items
        {
            get => items;
            set => Set(ref items, value);

        }
        public MonthListVM()
        {
            for (int i = 0; i < 11; i++)
                items.Add(new MonthVM());

        }


    }
}
