namespace Timer_1
{
    partial class Form2
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
            this.TextField = new System.Windows.Forms.Label();
            this.plus1 = new System.Windows.Forms.Button();
            this.plus2 = new System.Windows.Forms.Button();
            this.plus3 = new System.Windows.Forms.Button();
            this.minus3 = new System.Windows.Forms.Button();
            this.minus2 = new System.Windows.Forms.Button();
            this.minus1 = new System.Windows.Forms.Button();
            this.SetCoundown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextField
            // 
            this.TextField.AutoSize = true;
            this.TextField.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.TextField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextField.Location = new System.Drawing.Point(-4, 34);
            this.TextField.Name = "TextField";
            this.TextField.Size = new System.Drawing.Size(263, 60);
            this.TextField.TabIndex = 3;
            this.TextField.Text = "00:00:00";
            this.TextField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plus1
            // 
            this.plus1.BackColor = System.Drawing.Color.Transparent;
            this.plus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus1.Location = new System.Drawing.Point(6, 7);
            this.plus1.Name = "plus1";
            this.plus1.Size = new System.Drawing.Size(63, 34);
            this.plus1.TabIndex = 4;
            this.plus1.Text = "+";
            this.plus1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.plus1.UseVisualStyleBackColor = false;
            this.plus1.Click += new System.EventHandler(this.plus1_Click);
            // 
            // plus2
            // 
            this.plus2.BackColor = System.Drawing.Color.Transparent;
            this.plus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus2.Location = new System.Drawing.Point(93, 7);
            this.plus2.Name = "plus2";
            this.plus2.Size = new System.Drawing.Size(64, 34);
            this.plus2.TabIndex = 4;
            this.plus2.Text = "+";
            this.plus2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.plus2.UseVisualStyleBackColor = false;
            this.plus2.Click += new System.EventHandler(this.plus2_Click);
            // 
            // plus3
            // 
            this.plus3.BackColor = System.Drawing.Color.Transparent;
            this.plus3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus3.Location = new System.Drawing.Point(180, 7);
            this.plus3.Name = "plus3";
            this.plus3.Size = new System.Drawing.Size(64, 34);
            this.plus3.TabIndex = 4;
            this.plus3.Text = "+";
            this.plus3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.plus3.UseVisualStyleBackColor = false;
            this.plus3.Click += new System.EventHandler(this.plus3_Click);
            // 
            // minus3
            // 
            this.minus3.BackColor = System.Drawing.Color.Transparent;
            this.minus3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus3.Location = new System.Drawing.Point(180, 88);
            this.minus3.Name = "minus3";
            this.minus3.Size = new System.Drawing.Size(64, 34);
            this.minus3.TabIndex = 5;
            this.minus3.Text = "-";
            this.minus3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minus3.UseVisualStyleBackColor = false;
            this.minus3.Click += new System.EventHandler(this.minus3_Click);
            // 
            // minus2
            // 
            this.minus2.BackColor = System.Drawing.Color.Transparent;
            this.minus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus2.Location = new System.Drawing.Point(93, 88);
            this.minus2.Name = "minus2";
            this.minus2.Size = new System.Drawing.Size(64, 34);
            this.minus2.TabIndex = 6;
            this.minus2.Text = "-";
            this.minus2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minus2.UseVisualStyleBackColor = false;
            this.minus2.Click += new System.EventHandler(this.minus2_Click);
            // 
            // minus1
            // 
            this.minus1.BackColor = System.Drawing.Color.Transparent;
            this.minus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus1.Location = new System.Drawing.Point(6, 88);
            this.minus1.Name = "minus1";
            this.minus1.Size = new System.Drawing.Size(63, 34);
            this.minus1.TabIndex = 7;
            this.minus1.Text = "-";
            this.minus1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minus1.UseVisualStyleBackColor = false;
            this.minus1.Click += new System.EventHandler(this.minus1_Click);
            // 
            // SetCoundown
            // 
            this.SetCoundown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetCoundown.Location = new System.Drawing.Point(6, 133);
            this.SetCoundown.Name = "SetCoundown";
            this.SetCoundown.Size = new System.Drawing.Size(238, 23);
            this.SetCoundown.TabIndex = 8;
            this.SetCoundown.TabStop = false;
            this.SetCoundown.Text = "Set Coundown";
            this.SetCoundown.UseVisualStyleBackColor = true;
            this.SetCoundown.Click += new System.EventHandler(this.SetCountdown_Click);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(6, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 23);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(250, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetCoundown);
            this.Controls.Add(this.minus3);
            this.Controls.Add(this.minus2);
            this.Controls.Add(this.minus1);
            this.Controls.Add(this.plus3);
            this.Controls.Add(this.plus2);
            this.Controls.Add(this.plus1);
            this.Controls.Add(this.TextField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextField;
        private System.Windows.Forms.Button plus1;
        private System.Windows.Forms.Button plus2;
        private System.Windows.Forms.Button plus3;
        private System.Windows.Forms.Button minus3;
        private System.Windows.Forms.Button minus2;
        private System.Windows.Forms.Button minus1;
        private System.Windows.Forms.Button SetCoundown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}