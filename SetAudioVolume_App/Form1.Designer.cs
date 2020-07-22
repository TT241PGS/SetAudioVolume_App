namespace SetAudioVolume_App
{
    partial class Form1
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
            this.txtVolume1 = new System.Windows.Forms.TextBox();
            this.btnSetVolume = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtRange1From = new System.Windows.Forms.DateTimePicker();
            this.dtRange1To = new System.Windows.Forms.DateTimePicker();
            this.dtRange2From = new System.Windows.Forms.DateTimePicker();
            this.dtRange2To = new System.Windows.Forms.DateTimePicker();
            this.txtVolume2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVolume1
            // 
            this.txtVolume1.Location = new System.Drawing.Point(539, 31);
            this.txtVolume1.Name = "txtVolume1";
            this.txtVolume1.Size = new System.Drawing.Size(100, 20);
            this.txtVolume1.TabIndex = 1;
            // 
            // btnSetVolume
            // 
            this.btnSetVolume.Location = new System.Drawing.Point(274, 160);
            this.btnSetVolume.Name = "btnSetVolume";
            this.btnSetVolume.Size = new System.Drawing.Size(75, 23);
            this.btnSetVolume.TabIndex = 2;
            this.btnSetVolume.Text = "Set Volume";
            this.btnSetVolume.UseVisualStyleBackColor = true;
            this.btnSetVolume.Click += new System.EventHandler(this.btnSetVolume_Click);
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(374, 160);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 23);
            this.btnMute.TabIndex = 3;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dtRange1From
            // 
            this.dtRange1From.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtRange1From.Location = new System.Drawing.Point(173, 31);
            this.dtRange1From.Name = "dtRange1From";
            this.dtRange1From.ShowUpDown = true;
            this.dtRange1From.Size = new System.Drawing.Size(111, 20);
            this.dtRange1From.TabIndex = 4;
            // 
            // dtRange1To
            // 
            this.dtRange1To.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtRange1To.Location = new System.Drawing.Point(360, 31);
            this.dtRange1To.Name = "dtRange1To";
            this.dtRange1To.ShowUpDown = true;
            this.dtRange1To.Size = new System.Drawing.Size(111, 20);
            this.dtRange1To.TabIndex = 5;
            // 
            // dtRange2From
            // 
            this.dtRange2From.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtRange2From.Location = new System.Drawing.Point(173, 88);
            this.dtRange2From.Name = "dtRange2From";
            this.dtRange2From.ShowUpDown = true;
            this.dtRange2From.Size = new System.Drawing.Size(111, 20);
            this.dtRange2From.TabIndex = 6;
            // 
            // dtRange2To
            // 
            this.dtRange2To.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtRange2To.Location = new System.Drawing.Point(360, 88);
            this.dtRange2To.Name = "dtRange2To";
            this.dtRange2To.ShowUpDown = true;
            this.dtRange2To.Size = new System.Drawing.Size(111, 20);
            this.dtRange2To.TabIndex = 7;
            // 
            // txtVolume2
            // 
            this.txtVolume2.Location = new System.Drawing.Point(539, 88);
            this.txtVolume2.Name = "txtVolume2";
            this.txtVolume2.Size = new System.Drawing.Size(100, 20);
            this.txtVolume2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 248);
            this.Controls.Add(this.txtVolume2);
            this.Controls.Add(this.dtRange2To);
            this.Controls.Add(this.dtRange2From);
            this.Controls.Add(this.dtRange1To);
            this.Controls.Add(this.dtRange1From);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnSetVolume);
            this.Controls.Add(this.txtVolume1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVolume1;
        private System.Windows.Forms.Button btnSetVolume;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtRange1From;
        private System.Windows.Forms.DateTimePicker dtRange1To;
        private System.Windows.Forms.DateTimePicker dtRange2From;
        private System.Windows.Forms.DateTimePicker dtRange2To;
        private System.Windows.Forms.TextBox txtVolume2;
    }
}

