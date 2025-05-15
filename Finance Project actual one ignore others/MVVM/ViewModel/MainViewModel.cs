using Finance_Project_actual_one_ignore_others.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_Project_actual_one_ignore_others.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand RecurringExpenseCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        public RecurringExpenseModel RecurringVM { get; set; }


        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }





        public MainViewModel() 
        { 
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            RecurringVM = new RecurringExpenseModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            { 
            CurrentView = HomeVM;
            });
            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM; ;
            });
            RecurringExpenseCommand = new RelayCommand(o =>
            {
                CurrentView = RecurringVM;
            });
            
        }
    }
}
