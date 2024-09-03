using MVVMSing.Model;

namespace MVVMSing.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {

        public ViewModelBase CurrentViewModel { get; set; }

        public MainViewModel(Hotel hotel)
        {
            CurrentViewModel = new ReservationListingViewModel();
        }
    }
}
