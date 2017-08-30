using FreshMvvm;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace ScrumTools.PageModels
{
    public class TimerPageModel : FreshBasePageModel
    {
        public TimerPageModel()
        {
            InitializeCommands();
        }

        /* Properties */
        private TimeSpan _setTime = new TimeSpan(0, 5, 0);
        public TimeSpan SetTime
        {
            get { return _setTime; }
            set
            {
                _setTime = value;
                _timeLeft = value;
                RaisePropertyChanged("SetTime");
                Time = string.Format("{0:m\\:ss}", _setTime);
            }
        }

        private TimeSpan _timeLeft;
        public TimeSpan TimeLeft
        {
            get { return _timeLeft; }
            set
            {
                _timeLeft = value;
                RaisePropertyChanged("TimeLeft");
                Time = string.Format("{0:m\\:ss}", _timeLeft);
            }
        }

        private string _time = "5:00";
        public string Time
        {
            get { return _time; }
            set { _time = value; RaisePropertyChanged("Time"); }
        }



        /* Commands */
        private Command _startCommand;
        public Command StartCommand
        {
            get { return _startCommand; }
            set { _startCommand = value; }
        }
                
        /* Private Methods */
        private void InitializeCommands()
        {
            _startCommand = new Command(() => StartExecute());
        }

        private void StartExecute()
        {
            Device.StartTimer(new TimeSpan(0, 0, 1), TimerActive);
            /* Need to disable the command */
        }

        private bool TimerActive()
        {
            if (TimeLeft.TotalSeconds==0)
                return false;
            else
                TimeLeft = _timeLeft.Subtract(new TimeSpan(0, 0, 1));
                return true;
        }
    }
}
