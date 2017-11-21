namespace DictionaryDemo
{
    partial class FormEdit
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
            this.lb_Edit = new System.Windows.Forms.Label();
            this.txt_EditMeaning = new System.Windows.Forms.TextBox();
            this.lb_EditMeaning = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.lb_EditName = new System.Windows.Forms.Label();
            this.txt_EditName = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.lb_AddExplication = new System.Windows.Forms.Label();
            this.txt_AddExplication = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Edit
            // 
            this.lb_Edit.AutoSize = true;
            this.lb_Edit.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Edit.Location = new System.Drawing.Point(148, 9);
            this.lb_Edit.Name = "lb_Edit";
            this.lb_Edit.Size = new System.Drawing.Size(347, 43);
            this.lb_Edit.TabIndex = 17;
            this.lb_Edit.Text = "Edit your word";
            // 
            // txt_EditMeaning
            // 
            this.txt_EditMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EditMeaning.Location = new System.Drawing.Point(147, 125);
            this.txt_EditMeaning.Multiline = true;
            this.txt_EditMeaning.Name = "txt_EditMeaning";
            this.txt_EditMeaning.Size = new System.Drawing.Size(364, 34);
            this.txt_EditMeaning.TabIndex = 16;
            this.txt_EditMeaning.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EditMeaning_KeyDown);
            // 
            // lb_EditMeaning
            // 
            this.lb_EditMeaning.AutoSize = true;
            this.lb_EditMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EditMeaning.Location = new System.Drawing.Point(18, 125);
            this.lb_EditMeaning.Name = "lb_EditMeaning";
            this.lb_EditMeaning.Size = new System.Drawing.Size(89, 24);
            this.lb_EditMeaning.TabIndex = 15;
            this.lb_EditMeaning.Text = "Meaning:";
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(194, 302);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(95, 33);
            this.btn_Check.TabIndex = 14;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // lb_EditName
            // 
            this.lb_EditName.AutoSize = true;
            this.lb_EditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EditName.Location = new System.Drawing.Point(18, 79);
            this.lb_EditName.Name = "lb_EditName";
            this.lb_EditName.Size = new System.Drawing.Size(66, 24);
            this.lb_EditName.TabIndex = 13;
            this.lb_EditName.Text = "Name:";
            // 
            // txt_EditName
            // 
            this.txt_EditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EditName.Location = new System.Drawing.Point(147, 72);
            this.txt_EditName.Multiline = true;
            this.txt_EditName.Name = "txt_EditName";
            this.txt_EditName.Size = new System.Drawing.Size(364, 31);
            this.txt_EditName.TabIndex = 12;
            this.txt_EditName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EditName_KeyDown);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(336, 302);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(95, 33);
            this.btn_Edit.TabIndex = 18;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // lb_AddExplication
            // 
            this.lb_AddExplication.AutoSize = true;
            this.lb_AddExplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddExplication.Location = new System.Drawing.Point(12, 211);
            this.lb_AddExplication.Name = "lb_AddExplication";
            this.lb_AddExplication.Size = new System.Drawing.Size(107, 24);
            this.lb_AddExplication.TabIndex = 19;
            this.lb_AddExplication.Text = "Explication:";
            // 
            // txt_AddExplication
            // 
            this.txt_AddExplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddExplication.Location = new System.Drawing.Point(147, 178);
            this.txt_AddExplication.Multiline = true;
            this.txt_AddExplication.Name = "txt_AddExplication";
            this.txt_AddExplication.Size = new System.Drawing.Size(364, 103);
            this.txt_AddExplication.TabIndex = 20;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 347);
            this.Controls.Add(this.txt_AddExplication);
            this.Controls.Add(this.lb_AddExplication);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.lb_Edit);
            this.Controls.Add(this.txt_EditMeaning);
            this.Controls.Add(this.lb_EditMeaning);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.lb_EditName);
            this.Controls.Add(this.txt_EditName);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Edit;
        private System.Windows.Forms.TextBox txt_EditMeaning;
        private System.Windows.Forms.Label lb_EditMeaning;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label lb_EditName;
        private System.Windows.Forms.TextBox txt_EditName;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label lb_AddExplication;
        private System.Windows.Forms.TextBox txt_AddExplication;
    }
}