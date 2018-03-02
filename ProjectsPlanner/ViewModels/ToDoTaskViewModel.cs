using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.ViewModels
{
    public class ToDoTaskViewModel : AbstractViewModel
    {
        private int _Effort;
        public int Effort
        {
            get => _Effort;
            set
            {
                if (_Effort != value)
                {
                    _Effort = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int _ID;
        public int ID
        {
            get => _ID;
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
