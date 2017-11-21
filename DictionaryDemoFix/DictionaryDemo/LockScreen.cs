using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Timers;

namespace DictionaryDemo
{
    public partial class LockScreen : Form
    {
        public LockScreen()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Play();
            VisibleText();
        }

        private SoundPlayer file;

        void VisibleText()
        {
            new Thread(() =>
                {
                    while (true)
                    {
                        //label2.ForeColor = Color.Wheat;
                        //Thread.Sleep(1000);
                        //label2.ForeColor = Color.Black;
                        //Thread.Sleep(1000);
                        label2.Visible = true;
                        Thread.Sleep(500);
                        label2.Visible = false;
                        Thread.Sleep(500);
                    }
                }
                ) {IsBackground = true}.Start();
        }

        public void Play()
        {
            //file = new SoundPlayer(@"D:\Trung Kiên\CodeWindowForm\DictionaryDemo\DictionaryDemo\bin\Debug\HaruHaru.wav");
            file = new SoundPlayer(@"HaruHaru.wav");
            file.PlayLooping();
        }

        private void LockScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //LockScreen lc = sender as LockScreen;
            //lc.Visible = false;
            //lc.ShowInTaskbar = false;
            //lc.Hide();
            MainScreen mc = new MainScreen();
            Hide();
            file.Stop();
            mc.Show();
        }
    }
}
