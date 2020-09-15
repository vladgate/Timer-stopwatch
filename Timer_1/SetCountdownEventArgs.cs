using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   public class SetCountdownEventArgs : EventArgs
   {
      public sbyte Hours { get; }
      public sbyte Minutes { get; }
      public sbyte Seconds { get; }
      public SetCountdownEventArgs(sbyte hours, sbyte minutes, sbyte seconds, sbyte miliseconds = 0)
      {
         Hours = hours;
         Minutes = minutes;
         Seconds = seconds;
      }
   }
}
