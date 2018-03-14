using ProjectsPlanner.BussinessObjects;
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
        public ProjectViewModel(Project model)
        {
            if (model != null)
            {
                Id = model.Id;
                Name = model.Name;
                ValuePrice = model.ValuePrice;
                if(model.Tasks != null)
                    foreach (var task in model.Tasks)
                    {
                        Tasks.Add(new ToDoTaskViewModel(task));
                    }
            }
        }

        private int _ValuePrice;
        public int ValuePrice
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

        private int _Id;
        public int Id
        {
            get => _Id;
            set
            {
                if (_Id != value)
                {
                    _Id = value;
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
