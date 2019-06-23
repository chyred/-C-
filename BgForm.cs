using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class BgForm : Form
    {
        public BgForm()
        {
            InitializeComponent();
            // 隐藏播放器的ui
            axWindowsMediaPlayer1.uiMode = "none";

           // 最大化窗口（全屏）
           //WindowState = FormWindowState.Maximized;
           // 如果最大化窗口，屏幕边缘出现缝隙。改用如下代码进行全屏：
           this.Bounds = Screen.PrimaryScreen.Bounds;

           // 设置循环播放
           axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        private void BgForm_Load(object sender, EventArgs e)
        {

        }
        public void Play(AxWMPLib.AxWindowsMediaPlayer mediaPlayer)
        {
            // 使用Form1预览窗口中 url、音量。
            axWindowsMediaPlayer1.URL = mediaPlayer.URL;
            axWindowsMediaPlayer1.settings.volume = mediaPlayer.settings.volume;

            // 背景窗口播放器，播放视频。
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        public void pause(AxWMPLib.AxWindowsMediaPlayer mediaPlayer)
        {
            // 背景窗口播放器，播放视频。
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        public void stop(AxWMPLib.AxWindowsMediaPlayer mediaPlayer)
        {
            // 背景窗口播放器，播放视频。
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
         {
             if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
             {
                 axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
             }
         }
    }
}

