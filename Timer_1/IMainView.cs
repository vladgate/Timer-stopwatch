using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   public interface IMainView
   {
      string Time { get; set; }
      event EventHandler StartClick;
      event EventHandler ResetClick;
      event EventHandler TimerClick;
   }
}
