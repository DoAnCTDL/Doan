using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryDemo
{
    public partial class History : Form
    {
        private Option _frmOption;

        public History(Form frmOption)
        {
            _frmOption = (Option)frmOption;
            InitializeComponent();
            AddComboBox();
        }
        
        public void AddComboBox()
        {
            //for (int i = _frmOption._frmMainScreen.LS.Count - 1; i >= 0; i--)
            //    comboBox_History.Items.Add(_frmOption._frmMainScreen.LS[i].Name);
            Node p = _frmOption._frmMainScreen.LichSu.Head;
            while (p != null)
            {
                comboBox_History.Items.Add(p.word.Name);
                p = p.pNext;
            }
        }

        private void comboBox_History_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            //for (int i = 0; i < _frmOption._frmMainScreen.LS.Count; i++)
            //{
            //    if (cb.Text == _frmOption._frmMainScreen.LS[i].Name)
            //    {
            //        txt_Name.Text = _frmOption._frmMainScreen.LS[i].Name;
            //        txt_Meaning.Text = _frmOption._frmMainScreen.LS[i].Meaning;
            //        txt_Explication.Text = _frmOption._frmMainScreen.LS[i].Explication;
            //    }
            //}
            Node p = _frmOption._frmMainScreen.LichSu.Head;
            while (p != null)
            {
                if (cb.Text == p.word.Name)
                {
                    txt_Name.Text = p.word.Name;
                    txt_Meaning.Text = p.word.Meaning;
                    txt_Explication.Text = p.word.Explication;
                }
                p = p.pNext;
            }
        }
    }
}
