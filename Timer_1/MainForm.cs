using System;
using System.Media;
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
      public event EventHandler StartClick;
      public event EventHandler ResetClick;
      public event EventHandler TimerClick;

      public string Time { get => txtTime.Text; set => txtTime.Text = value; }
      #endregion




      public static sbyte _milisecond = 0;
      public static sbyte _second = 0;
      public static sbyte _minute = 0;
      public static sbyte _hour = 0;
      public static bool isTimer = false;


      private void timer_Tick(object sender, EventArgs e)
      {
         if (isTimer)
            _Timer();
         else
            StopWatch();
         ResetTimer();
      }

      private void _Timer()
      {
         if (!(_hour > 0 | _minute > 0 | _second > 0 | _milisecond > 0))
         {
            btnStart.Text = "Start";
            timer.Enabled = false;
            isTimer = false;
            SoundPlayer timer_sound = new SoundPlayer(Properties.Resources.Sound5930_0001);
            timer_sound.Play();
            return;
         }
         if (_milisecond == 0)
         {
            _milisecond = 10;
            _milisecond--;
            if (_second == 0 && (_minute > 0 | _hour > 0))
            {
               _second = 60;
               _second--;
               if (_minute == 0 & _hour > 0)
               {
                  _minute = 60;
                  _minute--;
                  if (_hour > 0)
                  {
                     _hour--;
                  }
               }
               else
               {
                  _minute--;
               }
            }
            else
            {
               _second--;
            }
         }
         else
         {
            _milisecond--;
         }

      }
      private void StopWatch()
      {
         if (_milisecond == 9)
         {
            if (_second == 59)
            {
               if (_minute == 59)
               {
                  _hour++;
                  _minute = 0;
               }
               else
               {
                  _minute++;
                  _second = 0;
               }
            }
            else
            {
               _second++;
               _milisecond = 0;
            }
         }
         else
            _milisecond++;
      }

      private void Form1_Shown(object sender, EventArgs e)
      {
         ResetTimer();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         CountdownForm form2 = new CountdownForm();
         form2.ShowDialog();
         ResetTimer();
      }

      private void Start_Click(object sender, EventArgs e)
      {
         if (!timer.Enabled)
         {
            btnStart.Text = "Stop";
            timer.Enabled = true;
         }
         else
         {
            btnStart.Text = "Start";
            timer.Enabled = false;
         }
      }

      private void Reset_Click(object sender, EventArgs e)
      {
         timer.Enabled = false;
         _milisecond = 0;
         _second = 0;
         _minute = 0;
         _hour = 0;
         isTimer = false;
         ResetTimer();
      }
      private void ResetTimer()
      {
         txtTime.Text = String.Format("{0:D2}:{1:D2}:{2:D2}:{3:D1}", _hour, _minute, _second, _milisecond);
      }
   }
}
