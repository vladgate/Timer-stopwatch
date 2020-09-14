namespace Timer
{
    partial class CountdownForm
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
         this.txtCountdown = new System.Windows.Forms.Label();
         this.btnPlusHours = new System.Windows.Forms.Button();
         this.btnPlusMinutes = new System.Windows.Forms.Button();
         this.btnPlusSeconds = new System.Windows.Forms.Button();
         this.btnMinusSeconds = new System.Windows.Forms.Button();
         this.btnMinusMinutes = new System.Windows.Forms.Button();
         this.btnMinusHours = new System.Windows.Forms.Button();
         this.btnSetCoundown = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.btnCancel = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtCountdown
         // 
         this.txtCountdown.AutoSize = true;
         this.txtCountdown.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold);
         this.txtCountdown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.txtCountdown.Location = new System.Drawing.Point(-4, 34);
         this.txtCountdown.Name = "txtCountdown";
         this.txtCountdown.Size = new System.Drawing.Size(263, 60);
         this.txtCountdown.TabIndex = 3;
         this.txtCountdown.Text = "00:00:00";
         this.txtCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnPlusHours
         // 
         this.btnPlusHours.BackColor = System.Drawing.Color.Transparent;
         this.btnPlusHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnPlusHours.Location = new System.Drawing.Point(6, 7);
         this.btnPlusHours.Name = "btnPlusHours";
         this.btnPlusHours.Size = new System.Drawing.Size(63, 34);
         this.btnPlusHours.TabIndex = 4;
         this.btnPlusHours.Text = "+";
         this.btnPlusHours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.btnPlusHours.UseVisualStyleBackColor = false;
         this.btnPlusHours.Click += new System.EventHandler(this.plus1_Click);
         // 
         // btnPlusMinutes
         // 
         this.btnPlusMinutes.BackColor = System.Drawing.Color.Transparent;
         this.btnPlusMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnPlusMinutes.Location = new System.Drawing.Point(93, 7);
         this.btnPlusMinutes.Name = "btnPlusMinutes";
         this.btnPlusMinutes.Size = new System.Drawing.Size(64, 34);
         this.btnPlusMinutes.TabIndex = 4;
         this.btnPlusMinutes.Text = "+";
         this.btnPlusMinutes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.btnPlusMinutes.UseVisualStyleBackColor = false;
         this.btnPlusMinutes.Click += new System.EventHandler(this.plus2_Click);
         // 
         // btnPlusSeconds
         // 
         this.btnPlusSeconds.BackColor = System.Drawing.Color.Transparent;
         this.btnPlusSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnPlusSeconds.Location = new System.Drawing.Point(180, 7);
         this.btnPlusSeconds.Name = "btnPlusSeconds";
         this.btnPlusSeconds.Size = new System.Drawing.Size(64, 34);
         this.btnPlusSeconds.TabIndex = 4;
         this.btnPlusSeconds.Text = "+";
         this.btnPlusSeconds.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.btnPlusSeconds.UseVisualStyleBackColor = false;
         this.btnPlusSeconds.Click += new System.EventHandler(this.plus3_Click);
         // 
         // btnMinusSeconds
         // 
         this.btnMinusSeconds.BackColor = System.Drawing.Color.Transparent;
         this.btnMinusSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnMinusSeconds.Location = new System.Drawing.Point(180, 88);
         this.btnMinusSeconds.Name = "btnMinusSeconds";
         this.btnMinusSeconds.Size = new System.Drawing.Size(64, 34);
         this.btnMinusSeconds.TabIndex = 5;
         this.btnMinusSeconds.Text = "-";
         this.btnMinusSeconds.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.btnMinusSeconds.UseVisualStyleBackColor = false;
         this.btnMinusSeconds.Click += new System.EventHandler(this.minus3_Click);
         // 
         // btnMinusMinutes
         // 
         this.btnMinusMinutes.BackColor = System.Drawing.Color.Transparent;
         this.btnMinusMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnMinusMinutes.Location = new System.Drawing.Point(93, 88);
         this.btnMinusMinutes.Name = "btnMinusMinutes";
         this.btnMinusMinutes.Size = new System.Drawing.Size(64, 34);
         this.btnMinusMinutes.TabIndex = 6;
         this.btnMinusMinutes.Text = "-";
         this.btnMinusMinutes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.btnMinusMinutes.UseVisualStyleBackColor = false;
         this.btnMinusMinutes.Click += new System.EventHandler(this.minus2_Click);
         // 
         // btnMinusHours
         // 
         this.btnMinusHours.BackColor = System.Drawing.Color.Transparent;
         this.btnMinusHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnMinusHours.Location = new System.Drawing.Point(6, 88);
         this.btnMinusHours.Name = "btnMinusHours";
         this.btnMinusHours.Size = new System.Drawing.Size(63, 34);
         this.btnMinusHours.TabIndex = 7;
         this.btnMinusHours.Text = "-";
         this.btnMinusHours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.btnMinusHours.UseVisualStyleBackColor = false;
         this.btnMinusHours.Click += new System.EventHandler(this.minus1_Click);
         // 
         // btnSetCoundown
         // 
         this.btnSetCoundown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnSetCoundown.Location = new System.Drawing.Point(6, 133);
         this.btnSetCoundown.Name = "btnSetCoundown";
         this.btnSetCoundown.Size = new System.Drawing.Size(238, 23);
         this.btnSetCoundown.TabIndex = 8;
         this.btnSetCoundown.TabStop = false;
         this.btnSetCoundown.Text = "Set Coundown";
         this.btnSetCoundown.UseVisualStyleBackColor = true;
         this.btnSetCoundown.Click += new System.EventHandler(this.SetCountdown_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.label1.Location = new System.Drawing.Point(32, 120);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(33, 13);
         this.label1.TabIndex = 9;
         this.label1.Text = "hours";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.label2.Location = new System.Drawing.Point(127, 120);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(28, 13);
         this.label2.TabIndex = 9;
         this.label2.Text = "mins";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.label3.Location = new System.Drawing.Point(213, 120);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(29, 13);
         this.label3.TabIndex = 9;
         this.label3.Text = "secs";
         // 
         // btnCancel
         // 
         this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.btnCancel.Location = new System.Drawing.Point(6, 158);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(236, 23);
         this.btnCancel.TabIndex = 10;
         this.btnCancel.TabStop = false;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.button1_Click);
         // 
         // CountdownForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ButtonShadow;
         this.ClientSize = new System.Drawing.Size(250, 190);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnSetCoundown);
         this.Controls.Add(this.btnMinusSeconds);
         this.Controls.Add(this.btnMinusMinutes);
         this.Controls.Add(this.btnMinusHours);
         this.Controls.Add(this.btnPlusSeconds);
         this.Controls.Add(this.btnPlusMinutes);
         this.Controls.Add(this.btnPlusHours);
         this.Controls.Add(this.txtCountdown);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.MaximizeBox = false;
         this.Name = "CountdownForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCountdown;
        private System.Windows.Forms.Button btnPlusHours;
        private System.Windows.Forms.Button btnPlusMinutes;
        private System.Windows.Forms.Button btnPlusSeconds;
        private System.Windows.Forms.Button btnMinusSeconds;
        private System.Windows.Forms.Button btnMinusMinutes;
        private System.Windows.Forms.Button btnMinusHours;
        private System.Windows.Forms.Button btnSetCoundown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
    }
}