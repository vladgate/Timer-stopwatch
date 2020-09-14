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
      event EventHandler PlusHourClick;
      event EventHandler MinusHourClick;
      event EventHandler PlusMinuteClick;
      event EventHandler MinusMinuteClick;
      event EventHandler PlusSecondClick;
      event EventHandler MinusSecondClick;
   }
}
