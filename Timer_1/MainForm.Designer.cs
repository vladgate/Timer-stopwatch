namespace Timer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.btnStart = new System.Windows.Forms.Button();
         this.btnReset = new System.Windows.Forms.Button();
         this.timer = new System.Windows.Forms.Timer(this.components);
         this.txtTime = new System.Windows.Forms.Label();
         this.lblHours = new System.Windows.Forms.Label();
         this.lblMinutes = new System.Windows.Forms.Label();
         this.lblSeconds = new System.Windows.Forms.Label();
         this.lblMiliseconds = new System.Windows.Forms.Label();
         this.btnTimer = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnStart
         // 
         this.btnStart.BackColor = System.Drawing.SystemColors.ActiveBorder;
         resources.ApplyResources(this.btnStart, "btnStart");
         this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.btnStart.Name = "btnStart";
         this.btnStart.UseVisualStyleBackColor = false;
         this.btnStart.Click += new System.EventHandler(this.Start_Click);
         // 
         // btnReset
         // 
         this.btnReset.BackColor = System.Drawing.SystemColors.ActiveBorder;
         resources.ApplyResources(this.btnReset, "btnReset");
         this.btnReset.Name = "btnReset";
         this.btnReset.UseVisualStyleBackColor = false;
         this.btnReset.Click += new System.EventHandler(this.Reset_Click);
         // 
         // timer
         // 
         this.timer.Tick += new System.EventHandler(this.timer_Tick);
         // 
         // txtTime
         // 
         resources.ApplyResources(this.txtTime, "txtTime");
         this.txtTime.Name = "txtTime";
         // 
         // lblHours
         // 
         resources.ApplyResources(this.lblHours, "lblHours");
         this.lblHours.Name = "lblHours";
         // 
         // lblMinutes
         // 
         resources.ApplyResources(this.lblMinutes, "lblMinutes");
         this.lblMinutes.Name = "lblMinutes";
         // 
         // lblSeconds
         // 
         resources.ApplyResources(this.lblSeconds, "lblSeconds");
         this.lblSeconds.Name = "lblSeconds";
         // 
         // lblMiliseconds
         // 
         resources.ApplyResources(this.lblMiliseconds, "lblMiliseconds");
         this.lblMiliseconds.Name = "lblMiliseconds";
         // 
         // btnTimer
         // 
         this.btnTimer.BackColor = System.Drawing.SystemColors.ActiveBorder;
         resources.ApplyResources(this.btnTimer, "btnTimer");
         this.btnTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.btnTimer.Name = "btnTimer";
         this.btnTimer.UseVisualStyleBackColor = false;
         this.btnTimer.Click += new System.EventHandler(this.button1_Click);
         // 
         // MainForm
         // 
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
         this.Controls.Add(this.btnTimer);
         this.Controls.Add(this.lblMiliseconds);
         this.Controls.Add(this.lblSeconds);
         this.Controls.Add(this.lblMinutes);
         this.Controls.Add(this.lblHours);
         this.Controls.Add(this.txtTime);
         this.Controls.Add(this.btnReset);
         this.Controls.Add(this.btnStart);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.Name = "MainForm";
         this.Shown += new System.EventHandler(this.Form1_Shown);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMiliseconds;
        private System.Windows.Forms.Button btnTimer;
    }
}

