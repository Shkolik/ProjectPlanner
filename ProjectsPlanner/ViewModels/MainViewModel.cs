using ProjectsPlanner.BussinessObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsPlanner.ViewModels
{
    public class MainViewModel : AbstractViewModel
    {
        public MainViewModel()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                foreach (var project in db.Projects)
                    Projects.Add(new ProjectViewModel(project));
            }
        }

        private ObservableCollection<ProjectViewModel> _Projects = new ObservableCollection<ProjectViewModel>();

        public ObservableCollection<ProjectViewModel> Projects
        {
            get => _Projects;
            set
            {
                _Projects = value;
                NotifyPropertyChanged();
            }
        }

        private ProjectViewModel _SelectedProject;

        public ProjectViewModel SelectedProject
        {
            get => _SelectedProject;
            set
            {
                _SelectedProject = value;
                NotifyPropertyChanged();
            }
        }
    }
}
