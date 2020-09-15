using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   public class MainPresenter
   {
      private const string START_LABEL = "Start";
      private const string STOP_LABEL = "Stop";
      private const string RESUME_LABEL = "Resume";
      private IMainView _view;
      private TimerModel _model;
      public MainPresenter(IMainView view, TimerModel model)
      {
         if (view == null)
         {
            throw new ArgumentNullException(nameof(view));
         }
         if (model == null)
         {
            throw new ArgumentNullException(nameof(model));
         }
         _model = model;
         _model.TimeChanged += Model_TimeChanged;
         _model.TimerStarted += Model_TimerStarted;
         _model.TimerStopped += Model_TimerStopped;
         _model.TimerFinished += Model_TimerFinished;

         _view = view;
         _view.TimerClick += View_TimerClick;
         _view.StartStopClick += View_StartStopClick;
         _view.ResetClick += View_ResetClick;
      }

      private void Model_TimerFinished(object sender, EventArgs e)
      {
         _view.StartLabel = START_LABEL;
         _view.TimerEnabled = true;
      }

      private void Model_TimerStopped(object sender, EventArgs e)
      {
         _view.StartLabel = RESUME_LABEL;
         _view.TimerEnabled = true;
      }

      private void Model_TimerStarted(object sender, EventArgs e)
      {
         _view.StartLabel = STOP_LABEL;
         _view.TimerEnabled = false;
      }

      private void Model_TimeChanged(object sender, EventArgs e)
      {
         _view.Time = _model.GetTime();
      }

      private void View_ResetClick(object sender, EventArgs e)
      {
         _model.Reset();
         _view.StartLabel = START_LABEL;
         _view.Time = _model.GetTime();
         _view.TimerEnabled = true;
      }

      private void View_StartStopClick(object sender, EventArgs e)
      {
         if (!_model.IsTimerStarted)
         {
            _model.StartTimer();
         }
         else
         {
            if (_model.TimerState == TimerState.Paused)
            {
               _model.StartTimer();
            }
            else
            {
               _model.PauseTimer();
            }
         }
      }

      private void View_TimerClick(object sender, EventArgs e)
      {
         _model.Reset();
         ICountdownView countdownForm = new CountdownForm();
         CountdownModel countdownModel = new CountdownModel();
         CountdownPresenter countdownPresenter = new CountdownPresenter(countdownForm, countdownModel);
         countdownPresenter.SetCountdownClick += CountdownPresenter_SetCountdownClick;
         countdownForm.ShowViewDialog();
      }
      private void CountdownPresenter_SetCountdownClick(object sender, SetCountdownEventArgs e)
      {
         _model.Hours = e.Hours;
         _model.Minutes = e.Minutes;
         _model.Seconds = e.Seconds;
         _model.IsTimerMode = true;
         _view.StartLabel = START_LABEL;
         _view.Time = _model.GetTime();
      }
   }
}
