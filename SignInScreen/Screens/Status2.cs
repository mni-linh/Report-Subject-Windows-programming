using SignInScreen.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using asp = Aspose.Words;
using Aspose.Words.Lists;
using Aspose.Words;
using System.Text.RegularExpressions;

namespace SignInScreen
{
    public partial class Status2 : Form
    {
        // Fields
        private Random random;
        private Form activeForm;
        private Button currentButton;

        public Status2()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(169, 169, 169);
            public static Color color2 = Color.FromArgb(169, 169, 169);
            //public static Color color3 = Color.FromArgb(253, 138, 114);
            //public static Color color4 = Color.FromArgb(95, 77, 221);
            //public static Color color5 = Color.FromArgb(24, 161, 251);
        }

        private void panelStatus_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //
        
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender, RGBColors.color1);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDetail.Controls.Add(childForm);
            this.panelDetail.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        private void ActivateButton(object btnSender, Color color)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    //////////
                    currentButton.BackColor = color;
                }
            }
        }
        
        private void DisableButton()
        {
            foreach (Control previousBtn in panelTask.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(64, 64, 64);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                }
            }
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.Overview(), sender);
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.Task1(), sender);
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.Task2(), sender);
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.Task3(), sender);
        }

        private void btnTask4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.Task4(), sender);
        }

        private void btnTask5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.Task5(), sender);
        }

        private void btnGradeProject_Click(object sender, EventArgs e)
        {
            string keyword = @"((Capitalize)[a-zA-Z_0-9 ]*(subtitle))";
            //string file = @"C:/Users/Admin/OneDrive/Documents/BookTitle.docx";
            string file = @"C:\Users\Admin\OneDrive\Documents\templates\BookTitle.docx";

            asp.Document doc = new asp.Document(file);

            string[] paraNeedFind;
            NodeCollection paragraphCollection = doc.GetChildNodes(NodeType.Paragraph, true);
            Node[] paragraph = paragraphCollection.ToArray();
            paraNeedFind = new string[paragraph.Length];
            for (int i = 0; i < paragraph.Length; i++)
            {
                paraNeedFind[i] = paragraph[i].GetText();
            }
            Regex regex = new Regex(keyword);
            int[][] table1 = new int[paraNeedFind.Length][];
            for (int i = 0; i < paraNeedFind.Length; i++)
            {
                MatchCollection matches = regex.Matches((string)paraNeedFind[i]);
                //Console.WriteLine("doan: " + i.ToString());
                //Console.WriteLine(paraNeedFind[i]);
                table1[i] = new int[matches.Count];
                for (int j = 0; j < matches.ToArray().Length; j++)
                {
                    table1[i][j] = matches.ToArray()[j].Index;
                    //Console.WriteLine(table1[i][j].ToString());//
                }
                //Console.WriteLine(table1[i].Length.ToString());
            }
            //Console.WriteLine("-----------------------------");//

            //table1 = FindAll(paraNeedFind, keyword);

            int[][] table2 = new int[paraNeedFind.Length][];
            Regex regex2 = new Regex(keyword);
            for (int i = 0; i < paragraph.Length; i++)
            {
                int pos = 0;
                //NodeCollection nodeCollection_typeruns = ((asp.Paragraph)paragraph[i]).ChildNodes;
                asp.Paragraph paragraphSelected = ((asp.Paragraph)doc.GetChild(NodeType.Paragraph, i, true));
                //Node[] runsCollection = nodeCollection_typeruns.ToArray();

                Run[] runsCollection = paragraphSelected.Runs.ToArray();
                table2[i] = new int[runsCollection.Length];
                for (int j = 0; j < runsCollection.Length; j++)
                {
                    string text = runsCollection[j].GetText();
                    //Console.WriteLine(text);
                    //string color = HexConverter(((Run)runsCollection[j]).Font.Color);
                    string color = HexConverter(((Run)runsCollection[j]).Font.Color);
                    //Console.WriteLine(color);
                    Match match = regex2.Match(text);

                    if ((match.Success) && (color == "Red"))
                    {
                        table2[i][j] = pos;
                    }
                    else
                    {
                        table2[i][j] = -1;
                    }
                    pos = pos + runsCollection[j].GetText().Length;
                    if (table2[i][j] != -1)
                    {
                        Console.WriteLine(table2[i][j].ToString());
                    }
                }
                //Console.WriteLine(table2[i].Length.ToString());
            }

            //CheckPassed(table1, table2)
            if (CheckPassed(table1, table2))
            {
                //Console.WriteLine("Win");
                MessageBox.Show("Ok", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Console.WriteLine("Game Over \nTry again");
                MessageBox.Show("No Ok", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private static int[][] FindAll(string[] para, string keyword)
        {
            int[][] results = new int[para.Length][];
            Regex regex = new Regex(keyword);
            for (int i = 0; i < para.Length; i++)
            {

                MatchCollection matches = regex.Matches((string)para[i]);
                results[i] = new int[matches.Count];
                int j = 0;
                foreach (Match match in matches)
                {
                    results[i][j] = match.Index;
                    //Console.WriteLine("doan: "+ i.ToString());

                    Console.WriteLine(results[i][j].ToString());
                    j++;
                }


            }
            Console.WriteLine("------------------------------------");
            return results;
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
        private static bool CheckPassed(int[][] table1, int[][] table2)
        {
            for (int i = 0; i < table1.Length; i++)
            {
                for (int j = 0; j < table1[i].Length; j++)
                {
                    for (int k = 0; k < table2[i].Length; k++)
                    {
                        if (table2[i][k] == -1)
                        {
                            continue;
                        }
                        else
                        {
                            if (table1[i][j] == table2[i][k])
                            {
                                continue;
                            }
                            else
                            {
                                return false;
                            }
                            //
                        }
                    }
                }
            }
            return true;
        }
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void panelStatus_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

    }
}
