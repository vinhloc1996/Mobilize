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
        private readonly Dm _dm;
        private MainFrame _main;

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
            _dm.ConnectDb();    //Connect to DB
            string email = txtEmail.Text.Trim();
            string query = "Select * From [Users] Where email = '" + email + "'";
            string password = txtPass.Text.Trim();
            SqlDataReader reader = _dm.SelectData(query);    //Get Users from DB by query
            if (!IsValidEmail(email))   //Check if email is valid
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
            else
            {
                if (reader != null)    //Check if email is existed in DB
                {
                    if (password.Equals(reader.GetString(1)))    //Check if password is equaled in DB
                    {
                        _main = new MainFrame(email, reader.GetString(4));    //Show main frame
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
            #region Close Connection
            if (_dm.Connection.State == ConnectionState.Open)
            {
                _dm.Connection.Close();
            }
            #endregion
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
            if (_dm.Connection.State == ConnectionState.Open)
            {
                _dm.Connection.Close();
            }
            return isExisted;
        }
    }
}