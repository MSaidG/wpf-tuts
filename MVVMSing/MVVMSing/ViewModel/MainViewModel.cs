namespace MVVMSing.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {

        public ViewModelBase CurrentViewModel { get; set; }

        public MainViewModel()
        {
            CurrentViewModel = new ReservationListingViewModel();
        }
    }
}
