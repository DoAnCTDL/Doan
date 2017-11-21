using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DictionaryDemo
{
    public partial class Option : Form
    {
        public MainScreen _frmMainScreen;

        public Option(Form frmMainScreen)
        {
            _frmMainScreen = (MainScreen) frmMainScreen;
            InitializeComponent();
        }

        private string filepath = @"http://dict.laban.vn/";

        private void ptB_Information_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }

        private void ptB_Web_Click(object sender, EventArgs e)
        {
            Process.Start(filepath);
        }

        private void ptB_History_Click(object sender, EventArgs e)
        {
            History htr = new History(this);
            htr.Show();
        }
    }
}
