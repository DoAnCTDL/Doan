namespace DictionaryDemo
{
    partial class History
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
            this.lb_HistoryForm = new System.Windows.Forms.Label();
            this.lb_Lookedup = new System.Windows.Forms.Label();
            this.comboBox_History = new System.Windows.Forms.ComboBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Meaning = new System.Windows.Forms.Label();
            this.lb_Explication = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Meaning = new System.Windows.Forms.TextBox();
            this.txt_Explication = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_HistoryForm
            // 
            this.lb_HistoryForm.AutoSize = true;
            this.lb_HistoryForm.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HistoryForm.Location = new System.Drawing.Point(297, 9);
            this.lb_HistoryForm.Name = "lb_HistoryForm";
            this.lb_HistoryForm.Size = new System.Drawing.Size(287, 63);
            this.lb_HistoryForm.TabIndex = 0;
            this.lb_HistoryForm.Text = "History";
            // 
            // lb_Lookedup
            // 
            this.lb_Lookedup.AutoSize = true;
            this.lb_Lookedup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Lookedup.Location = new System.Drawing.Point(30, 90);
            this.lb_Lookedup.Name = "lb_Lookedup";
            this.lb_Lookedup.Size = new System.Drawing.Size(122, 25);
            this.lb_Lookedup.TabIndex = 1;
            this.lb_Lookedup.Text = "Looked up";
            // 
            // comboBox_History
            // 
            this.comboBox_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_History.FormattingEnabled = true;
            this.comboBox_History.Location = new System.Drawing.Point(23, 137);
            this.comboBox_History.Name = "comboBox_History";
            this.comboBox_History.Size = new System.Drawing.Size(140, 32);
            this.comboBox_History.TabIndex = 2;
            this.comboBox_History.SelectedIndexChanged += new System.EventHandler(this.comboBox_History_SelectedIndexChanged);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(311, 101);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(79, 25);
            this.lb_Name.TabIndex = 3;
            this.lb_Name.Text = "Name:";
            // 
            // lb_Meaning
            // 
            this.lb_Meaning.AutoSize = true;
            this.lb_Meaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Meaning.Location = new System.Drawing.Point(311, 213);
            this.lb_Meaning.Name = "lb_Meaning";
            this.lb_Meaning.Size = new System.Drawing.Size(109, 25);
            this.lb_Meaning.TabIndex = 4;
            this.lb_Meaning.Text = "Meaning:";
            // 
            // lb_Explication
            // 
            this.lb_Explication.AutoSize = true;
            this.lb_Explication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Explication.Location = new System.Drawing.Point(311, 368);
            this.lb_Explication.Name = "lb_Explication";
            this.lb_Explication.Size = new System.Drawing.Size(135, 25);
            this.lb_Explication.TabIndex = 4;
            this.lb_Explication.Text = "Explication:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(480, 96);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(358, 34);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_Meaning
            // 
            this.txt_Meaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Meaning.Location = new System.Drawing.Point(480, 208);
            this.txt_Meaning.Multiline = true;
            this.txt_Meaning.Name = "txt_Meaning";
            this.txt_Meaning.Size = new System.Drawing.Size(358, 34);
            this.txt_Meaning.TabIndex = 6;
            // 
            // txt_Explication
            // 
            this.txt_Explication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Explication.Location = new System.Drawing.Point(480, 308);
            this.txt_Explication.Multiline = true;
            this.txt_Explication.Name = "txt_Explication";
            this.txt_Explication.Size = new System.Drawing.Size(358, 167);
            this.txt_Explication.TabIndex = 7;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 487);
            this.Controls.Add(this.txt_Explication);
            this.Controls.Add(this.txt_Meaning);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lb_Explication);
            this.Controls.Add(this.lb_Meaning);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.comboBox_History);
            this.Controls.Add(this.lb_Lookedup);
            this.Controls.Add(this.lb_HistoryForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_HistoryForm;
        private System.Windows.Forms.Label lb_Lookedup;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Meaning;
        private System.Windows.Forms.Label lb_Explication;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Meaning;
        private System.Windows.Forms.TextBox txt_Explication;
        public System.Windows.Forms.ComboBox comboBox_History;
    }
}