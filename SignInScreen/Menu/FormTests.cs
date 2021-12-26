using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using msword = Microsoft.Office.Interop.Word;
using System.Diagnostics;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Data.SqlClient;

namespace SignInScreen.Forms
{
    public partial class FormTests : Form
    {
        public object Application { get; private set; }

        public FormTests()
        {
            InitializeComponent();
        }
        private void FormTest_Load(object sender, EventArgs e)
        {
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
            new Status1().Show();
            this.Hide();

        }

        private void btnExam2_Click(object sender, EventArgs e)
        {
            System.IO.File.Copy(@"F:\Study\3rdyrs_1st\C#Windows\MSW\Database\DeThi\BOOK TITLE.docx", "C:/Users/Admin/OneDrive/Documents/BookTitle.docx", true);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\WinWord.exe";
            startInfo.Arguments = "C:/Users/Admin/OneDrive/Documents/BookTitle.docx";
            Process.Start(startInfo);

            // Open Status Task
            new Status2().Show();
            this.Hide();
            //////////////////////////
            ///
            

        }
        }
    }

