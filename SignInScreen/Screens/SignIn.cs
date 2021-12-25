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
using System.Data.SqlClient;

namespace SignInScreen
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            SqlConnection sqlCon = new SqlConnection(@"Data Source=MNI-LINH\SQLEXPRESS01;Initial Catalog=DBW;Integrated Security=True");
            //string query = "SELECT * FROM THISINH WHERE USERNAME = '" + txtUserName.Text.Trim() + "' AND _PASSWORD = '" + txtPassword.Text.Trim() + "'";
            string query = "SELECT * FROM THISINH WHERE USERNAME = '" + txtUserName.Text.Trim() + "' AND _PASSWORD = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Account objAccScr = new Account();
                this.Hide();
                objAccScr.Show() ;
            }
            else
            {
                MessageBox.Show("The user name or password you entered is incorrect, try again");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }
        

            /*
            if (txtUserName.Text == "" && txtPassword.Text == "")
            {
                new AccountScreen().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The user name or password you entered is incorrect, try again");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();

            }
        }*/

    private void btnFgPass_Click(object sender, EventArgs e)
    {
        try
        {
            this.Hide();
            ForgotPassword ps = new ForgotPassword();
            ps.Show();
        }
        catch (Exception f)
        {
            MessageBox.Show(f.Message);
        }
    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void cbRemember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUp objSignUp = new SignUp();
            this.Hide();
            objSignUp.Show();
        }
    }
}
