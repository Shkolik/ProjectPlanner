using ProjectsPlanner.BussinessObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.ViewModels
{
    public class ProjectViewModel : AbstractEntityViewModel<Project>
    {
        public ProjectViewModel():base()
        { }

        public ProjectViewModel(Project model):base(model)
        {            
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

        public override void CreateModel()
        {
            Model = new Project() { Name = "New Project" };
            UpdateViewModel();
        }

        public override void UpdateViewModel()
        {
            base.UpdateViewModel();

            if (Model != null)
            {
                ValuePrice = Model.ValuePrice;
                if (Model.Tasks != null)
                {
                    foreach (var task in Model.Tasks)
                    {
                        Tasks.Add(new ToDoTaskViewModel(task));
                    }
                }
            }
        }

        public override void ApplyToModel()
        {
            if (Model != null)
            {
                Model.ValuePrice = ValuePrice;

                Model.Tasks = new List<ToDoTask>();
                foreach (var task in Tasks)
                {
                    task.ApplyToModel();
                    Model.Tasks.Add(task.Model);
                }
            }
            base.ApplyToModel();
        }
    }
}
