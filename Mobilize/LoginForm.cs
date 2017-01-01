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

        public bool IsValidEmail(string inputEmail)
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
                        _main = new mainFrame(email, reader.GetString(4));
                        _main.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show(@"Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show(@"Invalid Email");
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
    }
}