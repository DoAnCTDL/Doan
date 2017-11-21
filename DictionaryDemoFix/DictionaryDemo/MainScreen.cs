using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace DictionaryDemo
{
    public partial class MainScreen : Form
    {
        public History _frmHistory;
        public MainScreen()
        {
            InitializeComponent();
            //List<Word> L = new List<Word>();
            // AddList(L);
            BB = new BangBam();
            LoadDataFile();
            AddComboBox(BB, comboBox1);
            Loading();
            SpeakWord();

            #region Test

            //List<Word> DS = new List<Word>();
            //AddList(DS);
            //Hashtable hashname = new Hashtable();
            //Hashtable hashmean = new Hashtable();
            //for (int i = 0; i < DS.Count; i++)
            //{
            //    hashname.Add(i, DS[i].name.ToString());
            //    hashmean.Add(i, DS[i].meaning.ToString());
            //}
            //comboBox1.DataSource = DS;
            //comboBox1.DisplayMember = "name";
            //comboBox1.DataSource = hashname.Values;
            //comboBox1.DisplayMember = hashname.Values.ToString();

            #endregion

        }

        public void LoadDataFile()
        {
            FileStream file = new FileStream(
                @"F:\DictionaryDemoFix\DictionaryDemo\input.txt",
                FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(file);
            string s = sr.ReadLine();

            do
            {
                string name = null, meaning = null, explication = null;
                int j = 0;
                while (j < s.Length && s[j] != '@')
                {
                    name += s[j];
                    j++;
                }
                j++;
                while (j < s.Length && s[j] != '@')
                {
                    meaning += s[j];
                    j++;
                }
                j++;
                while (j < s.Length)
                {
                    explication += s[j];
                    j++;
                }
                Word wd = new Word(name, meaning, explication);
                BB.Add(wd);
                s = sr.ReadLine();
            }
            while (s != null);
            sr.Close();
            file.Close();
        }

        public void SpeakWord()
        {
            WebBrowser wbVN = new WebBrowser();
            wbVN.Width = 0;
            wbVN.Height = 0;
            wbVN.Visible = false;
            wbVN.ScriptErrorsSuppressed = true;
            wbVN.Navigate(Link.VietNamLink);
            wbVN.DocumentCompleted += wbVN_DocumentCompleted;
            this.Controls.Add(wbVN);

            WebBrowser wbEn = new WebBrowser();
            wbEn.Width = 0;
            wbEn.Height = 0;
            wbEn.Visible = false;
            wbEn.Navigate(Link.EnglishLink);
            wbEn.ScriptErrorsSuppressed = true;
            wbEn.DocumentCompleted += wbEn_DocumentCompleted;
            this.Controls.Add(wbEn);

            VietNamese = new SpeakText(wbVN);
            English = new SpeakText(wbEn);
        }

        private void wbEn_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            isLoading1 = false;
            Loading();
        }

        private void wbVN_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            isLoading2 = false;
            Loading();
        }

        public void Loading()
        {
            this.Enabled = !(isLoading1 && isLoading2);
        }

        public static void AddComboBox(BangBam BB, ComboBox comboBox1)
        {
            Node p = new Node();
            for (int i = 0; i < 26; i++)
            {
                p = BB.Table[i].Head;
                while (p != null)
                {
                    comboBox1.Items.Add(p.word.Name);
                    p = p.pNext;
                }
            }
        }

        private SpeakText VietNamese;
        private SpeakText English;
        public bool isLoading1 = true;
        public bool isLoading2 = true;
        public BangBam BB;
        public List<Word> LS = new List<Word>();
        public DSLK LichSu = new DSLK();

        //private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    LockScreen lc = sender as LockScreen;
        //    Application.Exit();
        //}

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string s = cb.Text;
            Node k = BB.Search_Lookup(s);
            if (k != null)
            {
                textBox1.Text = k.word.Meaning;
                textBox2.Text = k.word.Explication;
                //LS.Add(new Word(s, textBox1.Text, textBox2.Text));
                Word wd = new Word(s, textBox1.Text, textBox2.Text);
                Node p = new Node();
                p.CreateNode(wd);
                LichSu.AddHead(p);
            }
            else
            {
                MessageBox.Show("Dictionay does not have this word", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ptB_Add_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd(this);
            form.Activate();
            form.ShowDialog();
        }

        private void ptB_Speak1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == null)
                    throw new Exception("Dictionary can not speak");
                English.Spreak(comboBox1.SelectedText);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ptB_Speak2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == null)
                    throw new Exception("Dictionary can not speak");
                VietNamese.Spreak(textBox1.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ptB_Delete_Click(object sender, EventArgs e)
        {
            FormDelete fd = new FormDelete(this);
            fd.ShowDialog();
        }

        private void ptB_Exit_Click(object sender, EventArgs e)
        {
            //DialogResult kq = MessageBox.Show("Do you want to exit", "Notification", MessageBoxButtons.OKCancel,
            //    MessageBoxIcon.Question);
            //if (kq == DialogResult.OK)
            //{
            //    Application.Exit();
            //}
            Option op = new Option(this);
            op.ShowDialog();
        }

        private void ptB_Edit_Click(object sender, EventArgs e)
        {
            FormEdit fe = new FormEdit(this);
            fe.ShowDialog();
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Do you want to exit", "Notification", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (kq == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
