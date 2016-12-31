using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Mobilize.database;

namespace Mobilize
{
    public partial class LoginForm : Form
    {
        private Dm _dm;
        private mainFrame _main;

        public LoginForm()
        {
            InitializeComponent();
            _dm = new Dm();
        }

        public static bool IsValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                              @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                              @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _dm.ConnectDb();
            string email = txtEmail.Text.Trim();
            string data = "Select * From [Users] Where email = '" + email + "'";
            string password = txtPass.Text.Trim();
            SqlDataReader reader = _dm.SelectData(data);
            if (!IsValidEmail(email))
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
            else
            {
                if (reader != null)
                {
                    if (password.Equals(reader.GetString(1)))
                    {
                        _main = new mainFrame(reader.GetString(4));
                        _main.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show(@"Emai must be followed the format");
                    }
                }
                else
                {
                    MessageBox.Show(@"Emai must be followed the format");
                }
            }
            if (_dm.connection.State == ConnectionState.Open)
            {
                _dm.connection.Close();
            }
        }

        public bool IsExisted(string email)
        {
            bool isExisted = false;
            _dm.ConnectDb();
            string data = "Select * From [Users] Where email = '" + email + "'";
            SqlDataReader reader = _dm.SelectData(data);
            if (reader != null)
            {
                isExisted = true;
            }
            if (_dm.connection.State == ConnectionState.Open)
            {
                _dm.connection.Close();
            }
            return isExisted;
        }

        private void lblRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlRegister.Visible = true;
            lblRegis.Visible = false;
            AcceptButton = btnRegister;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string regEmail = txtRegEmail.Text.Trim();
            string regPassword = txtRegPassword.Text.Trim();
            string fullname = txtFullNam.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (regEmail.Length == 0 || regEmail.Length > 255)
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
            else if (regPassword.Length > 255 || regPassword.Length == 0)
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
            else if (fullname.Length == 0 || fullname.Length > 255)
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
            else if (phone.Length == 0 || phone.Length > 20)
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
            else if (!Regex.IsMatch(phone, @"^\d+$"))
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
            else if (!IsValidEmail(regEmail))
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
            else if (IsExisted(regEmail))
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
            else
            {
                _dm.ConnectDb();
                int success = _dm.InsertData("[Users]",
                    new string[] {"email", "password", "fullname", "phone"},
                    new object[] {regEmail, regPassword, fullname, phone});
                if (success > 0)
                {
                    MessageBox.Show(@"Emai must be followed the format");
                    pnlRegister.Visible = false;
                    lblRegis.Visible = true;
                    AcceptButton = btnLogin;
                    if (_dm.connection.State == ConnectionState.Open)
                    {
                        _dm.connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show(@"Emai must be followed the format");
                }
            }
        }
    }
}