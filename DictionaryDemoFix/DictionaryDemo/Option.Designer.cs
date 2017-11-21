namespace DictionaryDemo
{
    partial class Option
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
            this.ptB_Web = new System.Windows.Forms.PictureBox();
            this.ptB_Information = new System.Windows.Forms.PictureBox();
            this.ptB_History = new System.Windows.Forms.PictureBox();
            this.lb_t = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Web)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_History)).BeginInit();
            this.SuspendLayout();
            // 
            // ptB_Web
            // 
            this.ptB_Web.Image = global::DictionaryDemo.Properties.Resources.www_1632431_960_720;
            this.ptB_Web.Location = new System.Drawing.Point(180, 120);
            this.ptB_Web.Name = "ptB_Web";
            this.ptB_Web.Size = new System.Drawing.Size(100, 74);
            this.ptB_Web.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_Web.TabIndex = 2;
            this.ptB_Web.TabStop = false;
            this.ptB_Web.Click += new System.EventHandler(this.ptB_Web_Click);
            // 
            // ptB_Information
            // 
            this.ptB_Information.Image = global::DictionaryDemo.Properties.Resources.info_3_512;
            this.ptB_Information.Location = new System.Drawing.Point(325, 120);
            this.ptB_Information.Name = "ptB_Information";
            this.ptB_Information.Size = new System.Drawing.Size(100, 74);
            this.ptB_Information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_Information.TabIndex = 1;
            this.ptB_Information.TabStop = false;
            this.ptB_Information.Click += new System.EventHandler(this.ptB_Information_Click);
            // 
            // ptB_History
            // 
            this.ptB_History.Image = global::DictionaryDemo.Properties.Resources.Ic_restore_48px1;
            this.ptB_History.Location = new System.Drawing.Point(32, 120);
            this.ptB_History.Name = "ptB_History";
            this.ptB_History.Size = new System.Drawing.Size(100, 74);
            this.ptB_History.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB_History.TabIndex = 0;
            this.ptB_History.TabStop = false;
            this.ptB_History.Click += new System.EventHandler(this.ptB_History_Click);
            // 
            // lb_t
            // 
            this.lb_t.AutoSize = true;
            this.lb_t.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_t.Location = new System.Drawing.Point(5, 25);
            this.lb_t.Name = "lb_t";
            this.lb_t.Size = new System.Drawing.Size(457, 39);
            this.lb_t.TabIndex = 3;
            this.lb_t.Text = "Choose Your Command";
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.lb_t);
            this.Controls.Add(this.ptB_Web);
            this.Controls.Add(this.ptB_Information);
            this.Controls.Add(this.ptB_History);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Web)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_Information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_History)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptB_History;
        private System.Windows.Forms.PictureBox ptB_Information;
        private System.Windows.Forms.PictureBox ptB_Web;
        private System.Windows.Forms.Label lb_t;
    }
}