using System;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
   public partial class MainForm : Form, IMainView
   {
      public MainForm()
      {
         InitializeComponent();
      }

      #region MyRegion
      public event EventHandler StartStopClick;
      public event EventHandler ResetClick;
      public event EventHandler TimerClick;
      public string Time { set => txtTime.Invoke(new Action(() => txtTime.Text = value)); }
      public string StartLabel { set => btnStart.Invoke(new Action(() => btnStart.Text = value)); }
      public bool TimerEnabled { set =>btnTimer.Invoke(new Action(()=> btnTimer.Enabled = value)); }

      #endregion

      private void btnStartStop_Click(object sender, EventArgs e)
      {
         StartStopClick?.Invoke(sender, e);
      }

      private void btnReset_Click(object sender, EventArgs e)
      {
         ResetClick?.Invoke(sender, e);
      }

      private void btnTimer_Click(object sender, EventArgs e)
      {
         TimerClick?.Invoke(sender, e);
      }
   }
}
