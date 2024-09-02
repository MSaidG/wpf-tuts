using Stopwatch.ViewModel;
using System.Threading;

namespace Stopwatch.View
{
    internal class StopwatchView
    {
        private StopwatchViewModel _viewModel = new StopwatchViewModel();
        private bool _quit = false;

        public StopwatchView() 
        {
            ClearScreenAndAddHelpMessage();

            TimerCallback timerCallback = UpdateTimeCallback;
            var _timer = new Timer(timerCallback, null, 0, 10);
            while(!_quit)
            {
                Thread.Sleep(100);
            }

            Console.CursorVisible = true;
        }

        private void ClearScreenAndAddHelpMessage()
        {
            Console.Clear();
            Console.CursorTop = 3;
            Console.WriteLine("Space to start or stop, R to reset, " +
                "any other key to quit");
            Console.CursorVisible = false;
        }

        private void WriteCurrentTime()
        {
            Console.CursorTop = 1;
            Console.CursorLeft = 23;
            var time = _viewModel.Hours + ":"
                + _viewModel.Minutes + ":"
                + _viewModel.Seconds + "."
                + _viewModel.Tenths;
            var lapTime = _viewModel.LapHours + ":"
                + _viewModel.LapMinutes + ":"
                + _viewModel.LapSeconds + "."
                + _viewModel.LapTenths;
            Console.Write($"{time} - lap time {lapTime}");
        }

        private void UpdateTimeCallback(object? state)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    _viewModel.StartStop();
                }
                else if (keyInfo.Key == ConsoleKey.R)
                {
                    _viewModel.Reset();
                }
                else if (keyInfo.Key == ConsoleKey.L)
                {
                    _viewModel.LapTime();
                }
                else
                {
                    Console.CursorVisible = true;
                    Console.CursorLeft = 0;
                    Console.CursorTop = 5;
                    _quit = true;
                }
            }
            WriteCurrentTime();
        }
    }
}
