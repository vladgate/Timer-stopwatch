using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   public interface ICountdownView
   {
      string Countdown { get; set; }
      event EventHandler SetCountdownClick;
      event EventHandler CancelClick;
      event EventHandler<SetTimerEventArgs> PlusClick;
      event EventHandler<SetTimerEventArgs> MinusClick;
      void ShowViewDialog();
      void Close();
      bool SetCoundownEnabled { get; set; }
   }
}
