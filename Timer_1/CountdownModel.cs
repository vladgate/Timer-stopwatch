using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   public class CountdownModel
   {
      private sbyte _hours = 0;
      private sbyte _minutes = 0;
      private sbyte _seconds = 0;

      public sbyte Hours { get => _hours ; }
      public sbyte Minutes { get => _minutes; }
      public sbyte Seconds { get => _seconds; }

      public CountdownModel()
      {

      }

      public override string ToString()
      {
         return base.ToString();
      }

      public void Plus(TimePart timePart)
      {
         switch (timePart)
         {
            case TimePart.HOURS:
               {
                  if (_hours == 23)
                  {
                     _hours = 0;
                  }
                  else
                  {
                     _hours++;
                  }

                  break;
               }
            case TimePart.MINUTES:
               {
                  if (_minutes == 59)
                  {
                     _minutes = 0;
                  }
                  else
                  {
                     _minutes++;
                  }
                  break;
               }
            case TimePart.SECONDS:
               {
                  if (_seconds == 59)
                  {
                     _seconds = 0;
                  }
                  else
                  {
                     _seconds++;
                  }
                  break;
               }
         }
      }
      public void Minus(object timePart)
      {
         switch (timePart)
         {
            case TimePart.HOURS:
               {
                  if (_hours == 0)
                  {
                     _hours = 23;
                  }
                  else
                  {
                     _hours--;
                  }
                  break;
               }
            case TimePart.MINUTES:
               {
                  if (_minutes == 0)
                  {
                     _minutes = 59;
                  }
                  else
                  {
                     _minutes--;
                  }
                  break;
               }
            case TimePart.SECONDS:
               {
                  if (_seconds == 0)
                  {
                     _seconds = 59;
                  }
                  else
                  {
                     _seconds--;
                  }
                  break;
               }
         }
      }
      public string GetRepresentation()
      {
         return String.Format("{0:D2}", _hours) + ":" + String.Format("{0:D2}", _minutes) + ":" + String.Format("{0:D2}", _seconds);
      }
   }
}
