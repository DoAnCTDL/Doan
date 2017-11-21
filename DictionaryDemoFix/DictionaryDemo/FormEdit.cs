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
    public partial class FormEdit : Form
    {
        private MainScreen _frmMainScreen;
        public FormEdit(Form frmMainScreen)
        {
            _frmMainScreen = (MainScreen) frmMainScreen;
            InitializeComponent();
        }


        private void btn_Check_Click(object sender, EventArgs e)
        {
            string s1 = txt_EditName.Text;
            try
            {
                if (txt_EditName == null)
                    throw new Exception("You have to fill an right word");
                bool check = _frmMainScreen.BB.Search_Check(s1);
                if (check == false)
                {
                    MessageBox.Show("This word is not had in Dictionary", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("You can edit this word", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_EditName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_EditMeaning.Focus();
        }

        private void txt_EditMeaning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Edit.Focus();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_EditName.Text == "")
                    throw new Exception("You have to fill an right word");

                _frmMainScreen.BB.EditWord(txt_EditName.Text, txt_EditMeaning.Text, txt_AddExplication.Text);
                MessageBox.Show("This word has been edited", "Congratulation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //MainScreen.AddComboBox(_frmMainScreen.BB, _frmMainScreen.comboBox1);
                //_frmMainScreen.Loading();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
