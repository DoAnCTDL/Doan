namespace DictionaryDemo
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ptB_Edit = new System.Windows.Forms.PictureBox();
            this.ptB_Exit = new System.Windows.Forms.PictureBox();
            this.ptB_Speak2 = new System.Windows.Forms.PictureBox();
            this.ptB_Delete = new System.Windows.Forms.PictureBox();
            this.ptB_Add = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ptB_Speak1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Speak2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Speak1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 372);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownHeight = 300;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(3, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.ptB_Edit);
            this.panel2.Controls.Add(this.ptB_Exit);
            this.panel2.Controls.Add(this.ptB_Speak2);
            this.panel2.Controls.Add(this.ptB_Delete);
            this.panel2.Controls.Add(this.ptB_Add);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(183, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 372);
            this.panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 57);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(587, 201);
            this.textBox2.TabIndex = 8;
            // 
            // ptB_Edit
            // 
            this.ptB_Edit.Image = global::DictionaryDemo.Properties.Resources.addressbook_edit;
            this.ptB_Edit.Location = new System.Drawing.Point(331, 284);
            this.ptB_Edit.Name = "ptB_Edit";
            this.ptB_Edit.Size = new System.Drawing.Size(76, 60);
            this.ptB_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_Edit.TabIndex = 7;
            this.ptB_Edit.TabStop = false;
            this.ptB_Edit.Click += new System.EventHandler(this.ptB_Edit_Click);
            // 
            // ptB_Exit
            // 
            this.ptB_Exit.Image = global::DictionaryDemo.Properties.Resources.exitressbook_20edit1;
            this.ptB_Exit.Location = new System.Drawing.Point(464, 284);
            this.ptB_Exit.Name = "ptB_Exit";
            this.ptB_Exit.Size = new System.Drawing.Size(76, 60);
            this.ptB_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_Exit.TabIndex = 6;
            this.ptB_Exit.TabStop = false;
            this.ptB_Exit.Click += new System.EventHandler(this.ptB_Exit_Click);
            // 
            // ptB_Speak2
            // 
            this.ptB_Speak2.Image = global::DictionaryDemo.Properties.Resources.icon_1691327_960_720;
            this.ptB_Speak2.Location = new System.Drawing.Point(594, 10);
            this.ptB_Speak2.Name = "ptB_Speak2";
            this.ptB_Speak2.Size = new System.Drawing.Size(33, 41);
            this.ptB_Speak2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_Speak2.TabIndex = 5;
            this.ptB_Speak2.TabStop = false;
            this.ptB_Speak2.Click += new System.EventHandler(this.ptB_Speak2_Click);
            // 
            // ptB_Delete
            // 
            this.ptB_Delete.Image = global::DictionaryDemo.Properties.Resources.addressbook_delete;
            this.ptB_Delete.Location = new System.Drawing.Point(205, 284);
            this.ptB_Delete.Name = "ptB_Delete";
            this.ptB_Delete.Size = new System.Drawing.Size(76, 60);
            this.ptB_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_Delete.TabIndex = 3;
            this.ptB_Delete.TabStop = false;
            this.ptB_Delete.Click += new System.EventHandler(this.ptB_Delete_Click);
            // 
            // ptB_Add
            // 
            this.ptB_Add.Image = global::DictionaryDemo.Properties.Resources.addressbook_add;
            this.ptB_Add.Location = new System.Drawing.Point(72, 284);
            this.ptB_Add.Name = "ptB_Add";
            this.ptB_Add.Size = new System.Drawing.Size(79, 60);
            this.ptB_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_Add.TabIndex = 2;
            this.ptB_Add.TabStop = false;
            this.ptB_Add.Click += new System.EventHandler(this.ptB_Add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 41);
            this.textBox1.TabIndex = 0;
            // 
            // ptB_Speak1
            // 
            this.ptB_Speak1.Image = global::DictionaryDemo.Properties.Resources.icon_1691327_960_720;
            this.ptB_Speak1.Location = new System.Drawing.Point(147, 13);
            this.ptB_Speak1.Name = "ptB_Speak1";
            this.ptB_Speak1.Size = new System.Drawing.Size(33, 41);
            this.ptB_Speak1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_Speak1.TabIndex = 4;
            this.ptB_Speak1.TabStop = false;
            this.ptB_Speak1.Click += new System.EventHandler(this.ptB_Speak1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(825, 376);
            this.Controls.Add(this.ptB_Speak1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
         //   this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Speak2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Speak1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox ptB_Delete;
        private System.Windows.Forms.PictureBox ptB_Add;
        private System.Windows.Forms.PictureBox ptB_Speak1;
        private System.Windows.Forms.PictureBox ptB_Speak2;
        private System.Windows.Forms.PictureBox ptB_Exit;
        private System.Windows.Forms.PictureBox ptB_Edit;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
    }
}

