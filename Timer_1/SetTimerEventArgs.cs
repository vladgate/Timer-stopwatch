using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   public class SetTimerEventArgs : EventArgs
   {
      public TimePart TimePart { get; }
      public SetTimerEventArgs(TimePart timePart)
      {
         TimePart = timePart;
      }
   }
}
