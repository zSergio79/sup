using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class CommonPlan : ModelBase
    {
        private string caption;
        private ObservableCollection<WorkItem> items;

        public string Caption
        {
            get => caption;
            set 
                {
                if (caption != value)
                {
                    caption = value;
                    OnPropertyChanged();
                }
            } 
        }
        public ObservableCollection<WorkItem> Items
        {
            get => items;
            set 
            {
                if (items != value)
                {
                    items = value;
                    OnPropertyChanged();
                }

            }
        }

        public CommonPlan()
        {
            Items = new ObservableCollection<WorkItem>();
        }

    }
}
