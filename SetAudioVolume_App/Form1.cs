using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetAudioVolume_App
{
   
    public partial class Form1 : Form
    {
        CoreAudioDevice defaultPlaybackDevice;
        public Form1()
        {
            InitializeComponent();

            defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            if (defaultPlaybackDevice.IsMuted)
            {
                defaultPlaybackDevice.Mute(false);
                btnMute.Text = "Mute";
            }
            MessageBox.Show("Current Volume:" + defaultPlaybackDevice.Volume + "%");
            
        }
       
        private void SetVolume(int volume)
        {
            if (defaultPlaybackDevice.IsMuted)
                defaultPlaybackDevice.Mute(false);
            if (volume != defaultPlaybackDevice.Volume)
            {
                defaultPlaybackDevice.Volume = volume;
                MessageBox.Show("Current Volume:" + defaultPlaybackDevice.Volume + "%");
            }
        }
        private void MuteButton_Click(object sender, EventArgs e)
        {
            if (defaultPlaybackDevice.IsMuted)
            {
                defaultPlaybackDevice.Mute(false);
                btnMute.Text = "Mute";
            }
            else
            {
                defaultPlaybackDevice.Mute(true);
                btnMute.Text = "UnMute";
            }
        }
       
        private void btnSetVolume_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //year,month,day,hour,minute,second  
            DateTime date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, dtRange1From.Value.Hour, dtRange1From.Value.Minute, dtRange1From.Value.Second);
            DateTime date2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, dtRange1To.Value.Hour, dtRange1To.Value.Minute, dtRange1To.Value.Second);
            if (DateTime.Now>=date1 && DateTime.Now<=date2)
            {
                SetVolume(Convert.ToInt32(txtVolume1.Text));

            }
            DateTime date3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, dtRange2From.Value.Hour, dtRange2From.Value.Minute, dtRange2From.Value.Second);
            DateTime date4 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, dtRange2To.Value.Hour, dtRange2To.Value.Minute, dtRange2To.Value.Second);
            if (DateTime.Now >= date3 && DateTime.Now<=date4)
            {
                SetVolume(Convert.ToInt32(txtVolume2.Text));

            }

        }
       
    }
}
