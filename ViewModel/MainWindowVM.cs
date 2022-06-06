using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerForm.DataBase;

namespace TrackerForm.ViewModel
{
    internal class MainWindowVM : ViewModel
    {
        

        private string title = "ТРЕКЕР ПРИВЫЧЕК";

        public string Title 
        { 
            get => title;
            set => Set(ref title, value);
        }
        public MainWindowVM()
        {
           
        }


    }
}
