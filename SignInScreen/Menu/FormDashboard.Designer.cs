
namespace SignInScreen.Forms
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelExam1 = new System.Windows.Forms.Panel();
            this.btnExam1 = new System.Windows.Forms.Button();
            this.lblExam1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelExam1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recent Activity";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(56, 79);
            this.panel2.MaximumSize = new System.Drawing.Size(1500, 1);
            this.panel2.MinimumSize = new System.Drawing.Size(703, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 1);
            this.panel2.TabIndex = 2;
            // 
            // panelExam1
            // 
            this.panelExam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.panelExam1.Controls.Add(this.btnExam1);
            this.panelExam1.Controls.Add(this.lblExam1);
            this.panelExam1.Controls.Add(this.pictureBox1);
            this.panelExam1.Location = new System.Drawing.Point(56, 124);
            this.panelExam1.Name = "panelExam1";
            this.panelExam1.Size = new System.Drawing.Size(378, 195);
            this.panelExam1.TabIndex = 5;
            // 
            // btnExam1
            // 
            this.btnExam1.FlatAppearance.BorderSize = 0;
            this.btnExam1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam1.Image = ((System.Drawing.Image)(resources.GetObject("btnExam1.Image")));
            this.btnExam1.Location = new System.Drawing.Point(334, 3);
            this.btnExam1.Name = "btnExam1";
            this.btnExam1.Size = new System.Drawing.Size(41, 34);
            this.btnExam1.TabIndex = 4;
            this.btnExam1.UseVisualStyleBackColor = true;
            this.btnExam1.Click += new System.EventHandler(this.btnExam1_Click);
            // 
            // lblExam1
            // 
            this.lblExam1.AutoSize = true;
            this.lblExam1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExam1.ForeColor = System.Drawing.Color.White;
            this.lblExam1.Location = new System.Drawing.Point(52, 90);
            this.lblExam1.Name = "lblExam1";
            this.lblExam1.Size = new System.Drawing.Size(296, 28);
            this.lblExam1.TabIndex = 3;
            this.lblExam1.Text = "Word 2016 Core Practice Exam 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelExam1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelExam1.ResumeLayout(false);
            this.panelExam1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelExam1;
        private System.Windows.Forms.Button btnExam1;
        private System.Windows.Forms.Label lblExam1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}