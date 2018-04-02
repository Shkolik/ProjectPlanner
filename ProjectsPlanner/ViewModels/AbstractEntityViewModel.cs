using ProjectsPlanner.BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.ViewModels
{
    public abstract class AbstractEntityViewModel<T> : AbstractViewModel where T : EntityObject
    {
        public AbstractEntityViewModel()
        {
            CreateModel();
        }

        public AbstractEntityViewModel(T model)
        {
            Model = model;
            UpdateViewModel();
        }

        public T Model
        { get; set; }

        public virtual void ApplyToModel()
        {
            if (Model != null)
            {
                Model.Name = Name;                
                Model.Save();
            }
        }

        public abstract void CreateModel();

        public virtual void UpdateViewModel()
        {
            if (Model != null)
            {
                Id = Model.Id;
                Name = Model.Name;
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
    }
}
