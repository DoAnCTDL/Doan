namespace DictionaryDemo
{
    partial class FormDelete
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
            this.lb_Del = new System.Windows.Forms.Label();
            this.btn_Del = new System.Windows.Forms.Button();
            this.lb_AddName = new System.Windows.Forms.Label();
            this.txt_DelName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Del
            // 
            this.lb_Del.AutoSize = true;
            this.lb_Del.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Del.Location = new System.Drawing.Point(128, 31);
            this.lb_Del.Name = "lb_Del";
            this.lb_Del.Size = new System.Drawing.Size(321, 43);
            this.lb_Del.TabIndex = 11;
            this.lb_Del.Text = "Fill your word";
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.Location = new System.Drawing.Point(219, 190);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(95, 33);
            this.btn_Del.TabIndex = 8;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // lb_AddName
            // 
            this.lb_AddName.AutoSize = true;
            this.lb_AddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddName.Location = new System.Drawing.Point(22, 114);
            this.lb_AddName.Name = "lb_AddName";
            this.lb_AddName.Size = new System.Drawing.Size(66, 24);
            this.lb_AddName.TabIndex = 7;
            this.lb_AddName.Text = "Name:";
            // 
            // txt_DelName
            // 
            this.txt_DelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DelName.Location = new System.Drawing.Point(117, 111);
            this.txt_DelName.Multiline = true;
            this.txt_DelName.Name = "txt_DelName";
            this.txt_DelName.Size = new System.Drawing.Size(364, 31);
            this.txt_DelName.TabIndex = 6;
            this.txt_DelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DelName_KeyDown);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 248);
            this.Controls.Add(this.lb_Del);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.lb_AddName);
            this.Controls.Add(this.txt_DelName);
            this.Name = "FormDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Del;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Label lb_AddName;
        private System.Windows.Forms.TextBox txt_DelName;
    }
}