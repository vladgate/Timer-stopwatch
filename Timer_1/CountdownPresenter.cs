using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   public class CountdownPresenter
   {
      private ICountdownView _view;
      private CountdownModel _model;

      public event EventHandler<SetCountdownEventArgs> SetCountdownClick;
      public CountdownPresenter(ICountdownView view, CountdownModel model)
      {
         if (view == null)
         {
            throw new ArgumentNullException(nameof(view));
         }
         if (model == null)
         {
            throw new ArgumentNullException(nameof(model));
         }

         _view = view;
         _view.SetCoundownEnabled = false;
         _view.SetCountdownClick += View_SetCountdownClick;
         _view.CancelClick += View_CancelClick;
         _view.MinusClick += View_MinusClick;
         _view.PlusClick += View_PlusClick;

         _model = model;
      }

      private void View_PlusClick(object sender, SetTimerEventArgs e)
      {
         _model.Plus(e.TimePart);
         _view.Countdown = _model.GetRepresentation();
         CheckValues();
      }

      private void CheckValues()
      {
         if (_model.Hours == 0 && _model.Minutes == 0 && _model.Seconds == 0)
         {
            _view.SetCoundownEnabled = false;
         }
         else
         {
            _view.SetCoundownEnabled = true;
         }
      }

      private void View_MinusClick(object sender, SetTimerEventArgs e)
      {
         _model.Minus(e.TimePart);
         _view.Countdown = _model.GetRepresentation();
         CheckValues();
      }

      private void View_CancelClick(object sender, EventArgs e)
      {
         _view.Close();
      }

      private void View_SetCountdownClick(object sender, EventArgs e)
      {
         SetCountdownClick?.Invoke(sender, new SetCountdownEventArgs(_model.Hours, _model.Minutes, _model.Seconds));
         _view.Close();
      }
   }
}
