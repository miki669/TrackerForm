using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TrackerForm.ViewModel
{
    internal class DayVM : ViewModel
    {
        private bool checkbox;
        public bool Checkbox
        {
            get => checkbox;
            set => Set(ref checkbox, value);    
        }
        private List<CheckBox> checkBoxes = new();
        public List<CheckBox> CheckBoxes
        {
            get => checkBoxes;
            set => Set(ref checkBoxes, value);
        }

        public DayVM()
        {
            
        }
    }
}
