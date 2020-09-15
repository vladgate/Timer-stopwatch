using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   public interface IMainView
   {
      string Time { set; }
      string StartLabel { set; }
      bool TimerEnabled { set; }

      event EventHandler StartStopClick;
      event EventHandler ResetClick;
      event EventHandler TimerClick;
   }
}
