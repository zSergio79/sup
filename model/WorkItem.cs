using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class WorkItem : ModelBase
    {
        private int code;
        private string zakaz;
        private string theme;
        private string result;

        private int id;
        private string name;
        private DateTime start;
        private int pDay;
        private string description;
        private string noteNumber;
        private ObservableCollection<Person> persons;
        private int progress;
        private WorkStatus status;

        public int Id
        {
            get => id;
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Description
        {
            get => description;
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime Start
        {
            get => start;
            set
            {
                if (start != value)
                {
                    start = value;
                    OnPropertyChanged();
                }
            }
        }
        public int PDay
        {
            get => pDay;
            set 
            {
                if (pDay != value)
                {
                    pDay = value;
                    OnPropertyChanged();
                }
            }
        }
        public string NoteNumber
        {
            get => noteNumber;
            set
            {
                if (noteNumber != value)
                {
                    noteNumber = value;
                    OnPropertyChanged();
                }
            }
        }
        public ObservableCollection<Person> Persons 
        {
            get => persons;
            set 
            {
                if (persons != value)
                {
                    persons = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Progress
        {
            get => progress;
            set
            {
                if (progress != value)
                {
                    progress = value;
                    OnPropertyChanged();
                }
            }
        }
        public WorkStatus Status 
        {
            get => status;
            set 
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Code
        {
            get => code;
            set
            {
                if (code != value)
                {
                    code = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Zakaz
        {
            get => zakaz;
            set
            {
                if (zakaz != value)
                {
                    zakaz = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Theme
        {
            get => theme;
            set
            {
                if (theme != value)
                {
                    OnPropertyChanged();
                    theme = value;
                }
            }
        }
        public string Result
        {
            get => result;
            set
            {
                if (result != value)
                {
                    result = value;
                    OnPropertyChanged();
                }
            }
        }

        public WorkItem()
        {
            Persons = new ObservableCollection<Person>();
        }
    }

    public enum WorkStatus
    {
        New,
        Process,
        Closed
    }
}
