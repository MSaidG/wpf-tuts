using Microsoft.EntityFrameworkCore;
using MVVMSing.Db;
using MVVMSing.Model;
using MVVMSing.Services;
using MVVMSing.Services.ReservationConflictValidators;
using MVVMSing.Services.ReservationCreators;
using MVVMSing.Services.ReservationProviders;
using MVVMSing.Store;
using MVVMSing.ViewModel;
using System.Windows;

namespace MVVMSing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Data Source=reservoom.db";
        private readonly Hotel _hotel;
        private readonly HotelStore _hotelStore;
        private readonly NavigationStore _navigationStore;
        private readonly ReservoomDbContextFactory _reservoomDbContextFactory;

        public App()
        {
            _reservoomDbContextFactory = new ReservoomDbContextFactory(CONNECTION_STRING);
            IReservationConflictValidator reservationConflictValidator = new DatabaseReservationConflictValidator(_reservoomDbContextFactory);
            IReservationProvider reservationProvider = new DatabaseReservationProvider(_reservoomDbContextFactory);
            IReservationCreator reservationCreator = new DatabaseReservationCreator(_reservoomDbContextFactory);

            ReservationBook reservationBook = new ReservationBook(reservationProvider, reservationCreator, reservationConflictValidator);

            _hotel = new Hotel("Singleton Suites", reservationBook);
            _hotelStore = new HotelStore(_hotel);
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            using (ReservoomDbContext dbContext = _reservoomDbContextFactory.CreateDbContext())
            {
                dbContext.Database.Migrate();
            }

            _navigationStore.CurrentViewModel = CreateReservationViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotelStore, new NavigationService(_navigationStore, CreateReservationViewModel));
        }

        private ReservationListingViewModel CreateReservationViewModel()
        {
            return ReservationListingViewModel.LoadViewModel(_hotelStore, new NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }

}
