using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;

namespace Timer
{
   public enum TimerState
   {
      NotRunning = 0,
      Paused,
      Running
   }
   public class TimerModel
   {
      private TimerState _timerState;
      private sbyte _miliseconds = 0;
      private sbyte _seconds = 0;
      private sbyte _minutes = 0;
      private sbyte _hours = 0;
      private bool _isTimerMode = false; // in timer mode
      private bool _isTimerStarted = false;
      private System.Threading.Timer _timer;

      public event EventHandler TimeChanged;
      public event EventHandler TimerStarted;
      public event EventHandler TimerStopped;
      public event EventHandler TimerFinished;
      public TimerModel()
      {
         _timer = new System.Threading.Timer(ChangeElapsedTime, null, -1, 100);
      }

      private void ChangeElapsedTime(object state)
      {
         if (_isTimerMode)
            RunTimer();
         else
            RunStopwatch();
         TimeChanged?.Invoke(this, EventArgs.Empty);
      }

      public sbyte Hours { get => _hours; set => _hours = value; }
      public sbyte Minutes { get => _minutes; set => _minutes = value; }
      public sbyte Seconds { get => _seconds; set => _seconds = value; }
      public sbyte Miliseconds { get => _miliseconds; set => _miliseconds = value; }
      public bool IsTimerStarted { get => _isTimerStarted; }
      public bool IsTimerMode { get => _isTimerMode; set => _isTimerMode = value; }
      public TimerState TimerState { get => _timerState; }

      public string GetTime()
      {
         return String.Format("{0:D2}:{1:D2}:{2:D2}:{3:D1}", _hours, _minutes, _seconds, _miliseconds);
      }

      public void Reset()
      {
         _timerState = TimerState.NotRunning;
         if (_isTimerStarted)
         {
            PauseTimer();
            _isTimerStarted = false;
         }
         _hours = 0;
         _minutes = 0;
         _seconds = 0;
         _miliseconds = 0;
      }
      public void StartTimer()
      {
         _timerState = TimerState.Running;
         _timer.Change(0, 100); //start timer
         _isTimerStarted = true;
         TimerStarted?.Invoke(this, EventArgs.Empty);
      }
      public void PauseTimer()
      {
         _timerState = TimerState.Paused;
         _timer.Change(-1, 100); //stop timer
         TimerStopped?.Invoke(this, EventArgs.Empty);
      }

      public void StopTimer()
      {
         _timerState = TimerState.NotRunning;
         _isTimerMode = false;
         _isTimerStarted = false;
         _timer.Change(-1, 100); //stop timer
      }

      private void RunStopwatch()
      {
         if (_miliseconds == 9)
         {
            if (_seconds == 59)
            {
               if (_minutes == 59)
               {
                  _hours++;
                  _minutes = 0;
               }
               else
               {
                  _minutes++;
                  _seconds = 0;
               }
            }
            else
            {
               _seconds++;
               _miliseconds = 0;
            }
         }
         else
            _miliseconds++;
      }

      private void RunTimer()
      {
         if (_hours == 0 && _minutes == 0 && _seconds == 0 && _miliseconds == 0)
         {
            SoundPlayer timer_sound = new SoundPlayer(Properties.Resources.Sound5930_0001);
            timer_sound.Play();
            StopTimer();
            _timerState = TimerState.NotRunning;
            TimerFinished?.Invoke(this, EventArgs.Empty);
            return;
         }
         if (_miliseconds == 0)
         {
            _miliseconds = 9;
            if (_seconds == 0 && (_minutes > 0 || _hours > 0))
            {
               _seconds = 59;
               if (_minutes == 0 && _hours > 0)
               {
                  _minutes = 59;
                  if (_hours > 0)
                  {
                     _hours--;
                  }
               }
               else
               {
                  _minutes--;
               }
            }
            else
            {
               _seconds--;
            }
         }
         else
         {
            _miliseconds--;
         }
      }
   }
}
