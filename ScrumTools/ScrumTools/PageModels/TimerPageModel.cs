﻿using FreshMvvm;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using ScrumTools.Helpers;

namespace ScrumTools.PageModels
{
    public class TimerPageModel : FreshBasePageModel
    {
        public TimerPageModel()
        {
            _isRunning = false;
            InitializeCommands();
        }

        /* Properties */
        private bool _isRunning;
        public bool IsRuning
        {
            get { return _isRunning; }
            set
            {
                _isRunning = value;
                RaisePropertyChanged("IsRuninng");
                RaisePropertyChanged("IsStop");
            }
        }

        public bool IsStop
        {
            get { return !_isRunning; }
            set
            {
                _isRunning = !value;
                RaisePropertyChanged("IsStop");
                RaisePropertyChanged("IsRuninng");
            }
        }

        private TimeSpan _timeLeft = Settings.Timer.Time;
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

        private string _time = Settings.Timer.Time.ToString();
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
        private Command _pauseCommand;
        public Command PauseCommand
        {
            get { return _pauseCommand; }
            set { _pauseCommand = value; }
        }
        private Command _stopCommand;
        public Command StopCommand
        {
            get { return _stopCommand; }
            set { _stopCommand = value; }
        }

        /* Private Methods */
        private void InitializeCommands()
        {
            _startCommand = new Command(() => StartExecute());
            _stopCommand = new Command(() => StopExecute());
        }

        private void StartExecute()
        {
            if (!_isRunning)
            {
                Device.StartTimer(new TimeSpan(0, 0, 1), TimerActive);
                IsStop = false;
            }
        }

        private void StopExecute()
        {
            _isRunning = true;
            _timeLeft = Settings.Timer.Time;
            _time = Settings.Timer.Time.ToString();

        }


        private bool TimerActive()
        {
            if (!_isRunning && ((TimeLeft.TotalSeconds==0)))
                /* Launch alarm events */
                return false;
            else
                TimeLeft = _timeLeft.Subtract(new TimeSpan(0, 0, 1));
                return true;
        }
    }
}
