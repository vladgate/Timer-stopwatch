using System;
using System.Windows.Forms;

namespace Timer
{
   public partial class CountdownForm : Form, ICountdownView
   {
      sbyte _second = 0;
      sbyte _minute = 0;
      sbyte _hour = 0;
      string str_hour = "00", str_minute = "00", str_second = "00";

      #region ICountdownView
      public event EventHandler SetCountdownClick;
      public event EventHandler CancelClick;
      public event EventHandler PlusHourClick;
      public event EventHandler MinusHourClick;
      public event EventHandler PlusMinuteClick;
      public event EventHandler MinusMinuteClick;
      public event EventHandler PlusSecondClick;
      public event EventHandler MinusSecondClick;
      public string Countdown { get => txtCountdown.Text; set => txtCountdown.Text = value; }
      #endregion

      public CountdownForm()
      {
         InitializeComponent();
      }










      private void SetCountdown_Click(object sender, EventArgs e)
      {
         MainForm.isTimer = true;
         MainForm._hour = _hour;
         MainForm._minute = _minute;
         MainForm._second = _second;
         MainForm._milisecond = 0;
         this.Close();
      }

      private void plus1_Click(object sender, EventArgs e)
      {
         plus('h');
      }
      private void plus2_Click(object sender, EventArgs e)
      {
         plus('m');
      }
      private void plus3_Click(object sender, EventArgs e)
      {
         plus('s');
      }
      private void minus1_Click(object sender, EventArgs e)
      {
         minus('h');
      }
      private void minus2_Click(object sender, EventArgs e)
      {
         minus('m');
      }
      private void minus3_Click(object sender, EventArgs e)
      {
         minus('s');
      }
      private void button1_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      public void minus(char par)
      {
         switch (par)
         {
            case 'h':
               {
                  if (_hour == 0)
                     _hour = 24;
                  str_hour = String.Format("{0:D2}", --_hour); break;
               }
            case 'm':
               {
                  if (_minute == 0)
                     _minute = 60;
                  str_minute = String.Format("{0:D2}", --_minute); break;
               }
            case 's':
               {
                  if (_second == 0)
                     _second = 60;
                  str_second = String.Format("{0:D2}", --_second); break;
               }
         }
         txtCountdown.Text = str_hour + ":" + str_minute + ":" + str_second;
      }
      private void plus(char par)
      {
         switch (par)
         {
            case 'h':
               {
                  if (_hour == 23)
                     _hour = -1;
                  str_hour = String.Format("{0:D2}", ++_hour); break;
               }
            case 'm':
               {
                  if (_minute == 59)
                     _minute = -1;
                  str_minute = String.Format("{0:D2}", ++_minute); break;
               }
            case 's':
               {
                  if (_second == 59)
                     _second = -1;
                  str_second = String.Format("{0:D2}", ++_second); break;
               }
         }
         txtCountdown.Text = str_hour + ":" + str_minute + ":" + str_second;
      }
   }
}
