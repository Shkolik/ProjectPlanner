using ProjectsPlanner.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjectsPlanner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DataContext = (Application.Current as App)?.ViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var project = new ProjectViewModel();
            var vm = (Application.Current as App)?.ViewModel;
            if (vm != null)
            {
                vm.Projects.Add(project);
                vm.SelectedProject = project;
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {  
            MainFrame.Navigate(typeof(ProjectPage));
        }
    }
}
