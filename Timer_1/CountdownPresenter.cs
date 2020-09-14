using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   internal class CountdownPresenter
   {
      private ICountdownView _view;
      public CountdownPresenter(ICountdownView view)
      {
         _view = view;
      }
   }
}
