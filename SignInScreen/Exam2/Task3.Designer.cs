
namespace SignInScreen.Forms
{
    partial class Task3
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
            this.lblTask1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTask1
            // 
            this.lblTask1.AutoSize = true;
            this.lblTask1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTask1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTask1.Location = new System.Drawing.Point(1, 0);
            this.lblTask1.Name = "lblTask1";
            this.lblTask1.Padding = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.lblTask1.Size = new System.Drawing.Size(370, 43);
            this.lblTask1.TabIndex = 1;
            this.lblTask1.Text = "In đậm từ chữ \"Capitalize\" đến \"subtitle\"";
            // 
            // FormTask3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTask1);
            this.Name = "FormTask3";
            this.Text = "FormTask3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTask1;
    }
}