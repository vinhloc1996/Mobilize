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
        private Dm dm;
        private mainFrame main;
        private RentTransport rent;
        private string emails = "";

        public string Get_Email()
        {
            return this.emails;
        }

        public LoginForm()
        {
            InitializeComponent();
            dm = new Dm();
        }

        public static bool isValidEmail(string inputEmail)
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
            dm.ConnectDb();
            string email = txtEmail.Text.Trim();
            string data = "Select * From Users Where email = '" + email + "'";
            string password = txtPass.Text.Trim();
            SqlDataReader reader = dm.SelectData(data);
            if (!isValidEmail(email))
            {
                MessageBox.Show("Emai must be followed the format");
            }
            else
            {
                if (txtEmail.Text.Trim() == "admin@admin.com" && txtPass.Text.Trim() == "123456")
                //if (email == "1" && password == "1")
                {
                    main = new mainFrame();
                    //this.Visible = false;
                    //main.Visible = true;
                    main.Show();
                    this.Hide();
                }
                else
                {
                    if (reader != null)
                    {
                        if (password.Equals(reader.GetString(1)))
                        {
                            emails = reader.GetString(0);
                            rent = new RentTransport(emails);
                            rent.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email not found");
                    }
                }
                if (dm.connection.State == ConnectionState.Open)
                {
                    dm.connection.Close();
                }
            }
        }

        public bool isExisted(string email)
        {
            bool isExisted = false;
            dm.ConnectDb();
            string data = "Select * From Users Where email = '" + email + "'";
            SqlDataReader reader = dm.SelectData(data);
            if (reader != null)
            {
                isExisted = true;
            }
            if (dm.connection.State == ConnectionState.Open)
            {
                dm.connection.Close();
            }
            return isExisted;
        } 

        private void lblRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlRegister.Visible = true;
            lblRegis.Visible = false;
            this.AcceptButton = btnRegister;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {   
            string reg_email = txtRegEmail.Text.Trim();
            string reg_password = txtRegPassword.Text.Trim();
            string fullname = txtFullNam.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (reg_email.Length == 0 || reg_email.Length > 255)
            {
                MessageBox.Show("Email cannot be left blank and its length must smaller than 255 characters!");
            }
            else if (reg_password.Length > 255 || reg_password.Length == 0)
            {
                MessageBox.Show("Password cannot be left blank and its length must smaller than 255 characters!");
            }else if (fullname.Length == 0 || fullname.Length > 255)
            {
                MessageBox.Show("Full Name cannot be left blank and its length must smaller than 255 characters!");
            }
            else if (phone.Length == 0 || phone.Length > 20)
            {
                MessageBox.Show("Phone cannot be left blank and its length must smaller than 20 characters!");
            }
            else if (!Regex.IsMatch(phone, @"^\d+$"))
            {
                MessageBox.Show("Phone must be contained number only");
            }
            else if (!isValidEmail(reg_email))
            {
                MessageBox.Show("Emai must be followed the format");
            }else if (isExisted(reg_email))
            {
                MessageBox.Show("Email is existed");
            }
            else
            {
                dm.ConnectDb();
                int success = dm.InsertData("[Users]",
                    new string[] {"email", "password", "fullname", "phone"},
                    new object[] {reg_email, reg_password, fullname, phone});
                if (success > 0)
                {
                    MessageBox.Show("Register Successful");
                    pnlRegister.Visible = false;
                    lblRegis.Visible = true;
                    this.AcceptButton = btnLogin;
                    if (dm.connection.State == ConnectionState.Open)
                    {
                        dm.connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Register Failure");
                }

            }
        }
    }
}