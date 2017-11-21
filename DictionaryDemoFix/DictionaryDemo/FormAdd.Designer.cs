namespace DictionaryDemo
{
    partial class FormAdd
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
            this.txt_AddName = new System.Windows.Forms.TextBox();
            this.lb_AddName = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lb_AddMeaning = new System.Windows.Forms.Label();
            this.txt_AddMeaning = new System.Windows.Forms.TextBox();
            this.lb_Add = new System.Windows.Forms.Label();
            this.lb_Explication = new System.Windows.Forms.Label();
            this.txt_AddExplication = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_AddName
            // 
            this.txt_AddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddName.Location = new System.Drawing.Point(126, 74);
            this.txt_AddName.Multiline = true;
            this.txt_AddName.Name = "txt_AddName";
            this.txt_AddName.Size = new System.Drawing.Size(364, 31);
            this.txt_AddName.TabIndex = 0;
            this.txt_AddName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AddName_KeyDown);
            // 
            // lb_AddName
            // 
            this.lb_AddName.AutoSize = true;
            this.lb_AddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddName.Location = new System.Drawing.Point(12, 81);
            this.lb_AddName.Name = "lb_AddName";
            this.lb_AddName.Size = new System.Drawing.Size(66, 24);
            this.lb_AddName.TabIndex = 1;
            this.lb_AddName.Text = "Name:";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(230, 292);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(93, 33);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lb_AddMeaning
            // 
            this.lb_AddMeaning.AutoSize = true;
            this.lb_AddMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddMeaning.Location = new System.Drawing.Point(12, 133);
            this.lb_AddMeaning.Name = "lb_AddMeaning";
            this.lb_AddMeaning.Size = new System.Drawing.Size(89, 24);
            this.lb_AddMeaning.TabIndex = 3;
            this.lb_AddMeaning.Text = "Meaning:";
            // 
            // txt_AddMeaning
            // 
            this.txt_AddMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddMeaning.Location = new System.Drawing.Point(126, 130);
            this.txt_AddMeaning.Multiline = true;
            this.txt_AddMeaning.Name = "txt_AddMeaning";
            this.txt_AddMeaning.Size = new System.Drawing.Size(364, 34);
            this.txt_AddMeaning.TabIndex = 4;
            this.txt_AddMeaning.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AddMeaning_KeyDown);
            // 
            // lb_Add
            // 
            this.lb_Add.AutoSize = true;
            this.lb_Add.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Add.Location = new System.Drawing.Point(131, 9);
            this.lb_Add.Name = "lb_Add";
            this.lb_Add.Size = new System.Drawing.Size(349, 48);
            this.lb_Add.TabIndex = 5;
            this.lb_Add.Text = "Fill your word";
            // 
            // lb_Explication
            // 
            this.lb_Explication.AutoSize = true;
            this.lb_Explication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Explication.Location = new System.Drawing.Point(12, 218);
            this.lb_Explication.Name = "lb_Explication";
            this.lb_Explication.Size = new System.Drawing.Size(107, 24);
            this.lb_Explication.TabIndex = 6;
            this.lb_Explication.Text = "Explication:";
            // 
            // txt_AddExplication
            // 
            this.txt_AddExplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddExplication.Location = new System.Drawing.Point(126, 185);
            this.txt_AddExplication.Multiline = true;
            this.txt_AddExplication.Name = "txt_AddExplication";
            this.txt_AddExplication.Size = new System.Drawing.Size(364, 92);
            this.txt_AddExplication.TabIndex = 7;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 350);
            this.Controls.Add(this.txt_AddExplication);
            this.Controls.Add(this.lb_Explication);
            this.Controls.Add(this.lb_Add);
            this.Controls.Add(this.txt_AddMeaning);
            this.Controls.Add(this.lb_AddMeaning);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_AddName);
            this.Controls.Add(this.txt_AddName);
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AddName;
        private System.Windows.Forms.Label lb_AddName;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lb_AddMeaning;
        private System.Windows.Forms.TextBox txt_AddMeaning;
        private System.Windows.Forms.Label lb_Add;
        private System.Windows.Forms.Label lb_Explication;
        private System.Windows.Forms.TextBox txt_AddExplication;
    }
}