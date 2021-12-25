using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace SignInScreen
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=MNI-LINH\SQLEXPRESS01;Initial Catalog=DBW;Integrated Security=True");
                string query = "select _PASSWORD from THISINH Where _PASSWORD='" + textBox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count.ToString() == "1")
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE THISINH SET _PASSWORD='" + textBox3.Text + "' where _PASSWORD = '" + textBox1.Text + "'", con);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Your Password Is Successfully Updated....", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //label4.ForeColor = System.Drawing.Color.Green;
                        //label4.Text = "Your Password Is Successfully Updated....";
                    }
                    else
                    { }

                }
                else
                {
                    //label4.ForeColor = System.Drawing.Color.Red;
                    //label4.Text = "Your Password Is Not Update Please Try Again....";
                    MessageBox.Show("Your Password Is Not Update Please Try Again....", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void FgPass_Load(object sender, EventArgs e)
        {

        }

        private void btnHide1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                btnShow1.BringToFront();
                textBox1.PasswordChar = '*';
            }
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                btnHide1.BringToFront();
                textBox1.PasswordChar = '\0';
            }
        }

        private void btnHide2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                btnShow2.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                btnHide2.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void btnHide3_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '\0')
            {
                btnShow3.BringToFront();
                textBox3.PasswordChar = '*';
            }
        }

        private void btnShow3_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                btnHide3.BringToFront();
                textBox3.PasswordChar = '\0';
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SignIn objSingIn = new SignIn();
            this.Hide();
            objSingIn.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FgPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
