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
using System.Text.RegularExpressions;

namespace SignInScreen
{
    public partial class SignUp : Form
    {
        string connectionString = @"Data Source=MNI-LINH\SQLEXPRESS01;Initial Catalog=DBW;Integrated Security=True";
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnShow1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHide1.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow1.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == '*')
            {
                btnHide2.BringToFront();
                txtConfirmPass.PasswordChar = '\0';
            }
        }

        private void btnHide2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == '\0')
            {
                btnShow2.BringToFront();
                txtConfirmPass.PasswordChar = '*';
            }
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            SignIn objSignIn = new SignIn();
            this.Hide();
            objSignIn.Show();
        }

        void Clear()
        {
            txtStudentCode.Text = txtFullName.Text = txtBirth.Text = txtUserName.Text = txtPassword.Text = txtConfirmPass.Text = "";
        }
        public bool checkStudentCode(string sc) // student code
        {
            return Regex.IsMatch(sc, "^[0-9]{10,13}$");
        }
        public bool checkFullName(string fn) // full name
        {
            return Regex.IsMatch(fn, "^[a-zA-Z]{1,50}$");
        }
        public bool checkBirth(string bd) // birth
        {
            return Regex.IsMatch(bd, "^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)/d/d$");
        }
        public bool checkAccount(string acc) // pass-user
        {
            return Regex.IsMatch(acc, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool checkEmail(string em) // email
        {
            return Regex.IsMatch(em, "^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
            private void btnSignUp_Click(object sender, EventArgs e)
            {
            /*
            if (!checkStudentCode(txtStudentCode.Text))
            {
                MessageBox.Show("Student ID must include digits from 0 to 9 and be 10 to 13 characters long", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!checkFullName(txtFullName.Text))
            {
                MessageBox.Show("Please enter Full name 5-24 characters long, with uppercase or lowercase characters", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!checkAccount(txtUserName.Text))
            {
                MessageBox.Show("Please enter full name 1-50 characters long, with alphanumeric characters, uppercase and lowercase", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!checkAccount(txtPassword.Text))
            {
                MessageBox.Show("Please enter full name 1-50 characters long, with alphanumeric characters, uppercase and lowercase", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/
            if (txtStudentCode.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill out the required fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtPassword.Text != txtConfirmPass.Text)
                MessageBox.Show("Password don't match", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand SqlCmd = new SqlCommand("UserAdd", sqlCon);
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlCmd.Parameters.AddWithValue("@SBD", txtStudentCode.Text.Trim());
                    SqlCmd.Parameters.AddWithValue("@HOTEN", txtFullName.Text.Trim());
                    SqlCmd.Parameters.AddWithValue("@NGAYSINH", txtBirth.Text.Trim());
                    SqlCmd.Parameters.AddWithValue("@USERNAME", txtUserName.Text.Trim());
                    SqlCmd.Parameters.AddWithValue("@_PASSWORD", txtPassword.Text.Trim());
                    SqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is sucessfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                }
            }
        }
    }
}
