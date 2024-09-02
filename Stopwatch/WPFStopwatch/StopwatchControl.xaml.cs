using Stopwatch.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WPFStopwatch
{
    public partial class StopwatchControl : UserControl
    {
        DispatcherTimer _timer = new DispatcherTimer();
        StopwatchViewModel _viewModel;
        public StopwatchControl()
        {
            InitializeComponent();

            _viewModel = Resources["viewModel"] as StopwatchViewModel;

            _timer.Interval = TimeSpan.FromMilliseconds(100);
            _timer.Tick += TimerTick;
            _timer.Start();
        }

        private void TimerTick(object? sender, EventArgs e)
        {
            _viewModel.OnPropertyChanged(String.Empty);
        }

        private void StartStopButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.StartStop();
        }
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Reset();
        }
        private void LapButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.LapTime();
        }
    }
}
