using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.ViewModels
{
    public class ProjectViewModel : AbstractViewModel
    {
        private decimal _ValuePrice;
        public decimal ValuePrice
        {
            get => _ValuePrice;
            set
            {
                if (_ValuePrice != value)
                {
                    _ValuePrice = value;
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

        private ObservableCollection<ToDoTaskViewModel> _Tasks = new ObservableCollection<ToDoTaskViewModel>();

        public ObservableCollection<ToDoTaskViewModel> Tasks
        {
            get => _Tasks;
            set
            {
                if (_Tasks != value)
                {
                    _Tasks = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
