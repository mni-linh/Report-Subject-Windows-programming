using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInScreen.Forms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Themes.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Themes.SecondaryColor;

                }
            }
            //label14.ForeColor = Themes.SecondaryColor;
            //label15.ForeColor = Themes.PrimaryColor;
        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panelExam1.BackColor = Color.FromArgb(74, 104, 148);
            
        }

        private void btnExam1_Click(object sender, EventArgs e)
        {
            System.IO.File.Copy("C:/Users/Admin/OneDrive/Documents/templates/Templates1.docx", "C:/Users/Admin/OneDrive/Documents/Templates1_Copy.docx", true);
            //Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
            //Document document = ap.Documents.Open(@"C:/Users/Admin/OneDrive/Documents/templates/Templates1_Copy.docx");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\WinWord.exe";
            startInfo.Arguments = "C:/Users/Admin/OneDrive/Documents/Templates1_Copy.docx";
            Process.Start(startInfo);

            // Open Status Task
            new Screen2().Show();
            this.Hide();
        }
    }
}
