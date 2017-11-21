namespace DictionaryDemo
{
    partial class Information
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
            this.lb_Information = new System.Windows.Forms.Label();
            this.lb_PrjName = new System.Windows.Forms.Label();
            this.lb_Prj = new System.Windows.Forms.Label();
            this.lb_PrjStudents = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Subject = new System.Windows.Forms.Label();
            this.lb_Student1 = new System.Windows.Forms.Label();
            this.lb_Student2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Information
            // 
            this.lb_Information.AutoSize = true;
            this.lb_Information.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Information.Location = new System.Drawing.Point(174, 20);
            this.lb_Information.Name = "lb_Information";
            this.lb_Information.Size = new System.Drawing.Size(298, 43);
            this.lb_Information.TabIndex = 0;
            this.lb_Information.Text = "Information";
            // 
            // lb_PrjName
            // 
            this.lb_PrjName.AutoSize = true;
            this.lb_PrjName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrjName.Location = new System.Drawing.Point(12, 112);
            this.lb_PrjName.Name = "lb_PrjName";
            this.lb_PrjName.Size = new System.Drawing.Size(168, 25);
            this.lb_PrjName.TabIndex = 1;
            this.lb_PrjName.Text = "Project\'s Name: ";
            // 
            // lb_Prj
            // 
            this.lb_Prj.AutoSize = true;
            this.lb_Prj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Prj.Location = new System.Drawing.Point(12, 201);
            this.lb_Prj.Name = "lb_Prj";
            this.lb_Prj.Size = new System.Drawing.Size(178, 25);
            this.lb_Prj.TabIndex = 2;
            this.lb_Prj.Text = "Project\'s Subject:";
            // 
            // lb_PrjStudents
            // 
            this.lb_PrjStudents.AutoSize = true;
            this.lb_PrjStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PrjStudents.Location = new System.Drawing.Point(12, 321);
            this.lb_PrjStudents.Name = "lb_PrjStudents";
            this.lb_PrjStudents.Size = new System.Drawing.Size(103, 25);
            this.lb_PrjStudents.TabIndex = 3;
            this.lb_PrjStudents.Text = "Students:";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(253, 106);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(393, 31);
            this.lb_Name.TabIndex = 4;
            this.lb_Name.Text = "Demo Dictionary By HashTable";
            // 
            // lb_Subject
            // 
            this.lb_Subject.AutoSize = true;
            this.lb_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Subject.Location = new System.Drawing.Point(253, 195);
            this.lb_Subject.Name = "lb_Subject";
            this.lb_Subject.Size = new System.Drawing.Size(394, 31);
            this.lb_Subject.TabIndex = 5;
            this.lb_Subject.Text = "Data Structures And Algorithms";
            // 
            // lb_Student1
            // 
            this.lb_Student1.AutoSize = true;
            this.lb_Student1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Student1.Location = new System.Drawing.Point(253, 279);
            this.lb_Student1.Name = "lb_Student1";
            this.lb_Student1.Size = new System.Drawing.Size(325, 31);
            this.lb_Student1.TabIndex = 6;
            this.lb_Student1.Text = "_Nguyễn Trần Trung Kiên";
            // 
            // lb_Student2
            // 
            this.lb_Student2.AutoSize = true;
            this.lb_Student2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Student2.Location = new System.Drawing.Point(253, 342);
            this.lb_Student2.Name = "lb_Student2";
            this.lb_Student2.Size = new System.Drawing.Size(166, 31);
            this.lb_Student2.TabIndex = 7;
            this.lb_Student2.Text = "_Vũ Tấn Đạt";
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 395);
            this.Controls.Add(this.lb_Student2);
            this.Controls.Add(this.lb_Student1);
            this.Controls.Add(this.lb_Subject);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_PrjStudents);
            this.Controls.Add(this.lb_Prj);
            this.Controls.Add(this.lb_PrjName);
            this.Controls.Add(this.lb_Information);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Information;
        private System.Windows.Forms.Label lb_PrjName;
        private System.Windows.Forms.Label lb_Prj;
        private System.Windows.Forms.Label lb_PrjStudents;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Subject;
        private System.Windows.Forms.Label lb_Student1;
        private System.Windows.Forms.Label lb_Student2;
    }
}