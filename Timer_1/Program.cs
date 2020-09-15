using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         MainForm view = new MainForm();
         TimerModel model = new TimerModel();
         MainPresenter mainPresenter = new MainPresenter(view, model);
         Application.Run(view);
      }
   }
}
