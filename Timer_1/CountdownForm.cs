using System;
using System.Windows.Forms;

namespace Timer
{
   public partial class CountdownForm : Form, ICountdownView
   {
      #region ICountdownView
      public event EventHandler SetCountdownClick;
      public event EventHandler CancelClick;
      public event EventHandler<SetTimerEventArgs> PlusClick;
      public event EventHandler<SetTimerEventArgs> MinusClick;
      public string Countdown { get => txtCountdown.Text; set => txtCountdown.Text = value; }
      public bool SetCoundownEnabled { get => btnSetCoundown.Enabled; set => btnSetCoundown.Enabled = value; }
      public void ShowViewDialog()
      {
         this.ShowDialog();
      }
      #endregion

      public CountdownForm()
      {
         InitializeComponent();
      }

      private void btnSetCountdown_Click(object sender, EventArgs e)
      {
         SetCountdownClick?.Invoke(sender, e);
      }

      private void btnPlusHour_Click(object sender, EventArgs e)
      {
         PlusClick?.Invoke(sender, new SetTimerEventArgs(TimePart.HOURS));
      }
      private void btnPlusMinute_Click(object sender, EventArgs e)
      {
         PlusClick?.Invoke(sender, new SetTimerEventArgs(TimePart.MINUTES));
      }
      private void btnPlusSecond_Click(object sender, EventArgs e)
      {
         PlusClick?.Invoke(sender, new SetTimerEventArgs(TimePart.SECONDS));
      }
      private void btnMinusHour_Click(object sender, EventArgs e)
      {
         MinusClick?.Invoke(sender, new SetTimerEventArgs(TimePart.HOURS));
      }
      private void btnMinusMinute_Click(object sender, EventArgs e)
      {
         MinusClick?.Invoke(sender, new SetTimerEventArgs(TimePart.MINUTES));
      }
      private void btnMinusSecond_Click(object sender, EventArgs e)
      {
         MinusClick?.Invoke(sender, new SetTimerEventArgs(TimePart.SECONDS));
      }
      private void btnCancel_Click(object sender, EventArgs e)
      {
         CancelClick?.Invoke(sender, e);
      }
   }
}
