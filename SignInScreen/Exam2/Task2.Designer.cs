
namespace SignInScreen.Forms
{
    partial class Task2
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
            this.lblTask2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTask2
            // 
            this.lblTask2.AutoSize = true;
            this.lblTask2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTask2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTask2.Location = new System.Drawing.Point(-1, -1);
            this.lblTask2.Name = "lblTask2";
            this.lblTask2.Padding = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.lblTask2.Size = new System.Drawing.Size(421, 43);
            this.lblTask2.TabIndex = 1;
            this.lblTask2.Text = "Đổi cỡ chữ 13 từ chữ \"Capitalize\" đến \"subtitle\"";
            // 
            // FormTask2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTask2);
            this.Name = "FormTask2";
            this.Text = "FormTask2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTask2;
    }
}