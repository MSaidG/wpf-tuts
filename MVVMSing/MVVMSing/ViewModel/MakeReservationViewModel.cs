using System.Windows.Input;

namespace MVVMSing.ViewModel
{
    internal class MakeReservationViewModel : ViewModelBase
    {
		private string _username;

		public string Username
		{
			get { return _username; }
			set { _username = value; OnPropertyChanged(nameof(Username)); }
		}

        private string _floorNumber;
        public string FloorNumber
        {
            get { return _floorNumber; }
            set { _floorNumber = value; OnPropertyChanged(nameof(FloorNumber)); }
        }

        private string _roomNumber;
        public string RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; OnPropertyChanged(nameof(RoomNumber)); }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; OnPropertyChanged(nameof(StartDate)); }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; OnPropertyChanged(nameof(EndDate)); }
        }

        public ICommand SubmitCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public MakeReservationViewModel()
        {
            
        }
    }
}
