using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
   internal class MainPresenter
   {
      IMainView _view;
      public MainPresenter(IMainView view)
      {
         _view = view;
      }
   }
}
