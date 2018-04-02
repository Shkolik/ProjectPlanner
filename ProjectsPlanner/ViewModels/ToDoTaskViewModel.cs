using ProjectsPlanner.BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.ViewModels
{
    public class ToDoTaskViewModel : AbstractEntityViewModel<ToDoTask>
    {
        public ToDoTaskViewModel() : base()
        {
        }
        public ToDoTaskViewModel(ToDoTask model):base(model)
        {
        }

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

        public override void CreateModel()
        {
            Model = new ToDoTask();
            UpdateViewModel();
        }

        public override void UpdateViewModel()
        {
            base.UpdateViewModel();

            if (Model != null)
            {
                Effort = Model.Effort;
            }
        }

        public override void ApplyToModel()
        {
            if (Model != null)
            {
                Model.Effort = Effort;                
            }
            base.ApplyToModel();
        }
    }
}
