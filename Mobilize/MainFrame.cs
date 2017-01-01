using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Mobilize.database;

namespace Mobilize
{
    public partial class mainFrame : Form
    {
        private Dm _dm;
        private LoginForm _login;
        SqlDataAdapter adapt;
        private int id = 0;
        private string cur_email = ""; 
        private string email_user = "";

        public mainFrame(string email, string role)
        {
            InitializeComponent();
            Text = @"Mobilize - " + email + " (" + role + ")";
            cur_email = email;
            _dm = new Dm();
            _login = new LoginForm();
            DisplayData();
            AcceptButton = btnInsert;
            InitCbb();
            if (role.Equals("Staff"))
            {
                tabControl1.TabPages.Remove(tabUser);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                base.OnFormClosing(e);

                if (e.CloseReason == CloseReason.WindowsShutDown) return;

                // Confirm user wants to close
                switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception exp)
            {
                Environment.Exit(0);
            }
        }

        public void DisplayOrder()
        {
            _dm.ConnectDb();
            DataTable dataTable = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM [Orders]", _dm.connection);
            adapt.Fill(dataTable);
            gridOrder.DataSource = dataTable;
            gridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            if (_dm.connection.State == ConnectionState.Open)
            {
                _dm.connection.Close();
            }
        }

        public void DisplayData()
        {
            _dm.ConnectDb();
            DataTable dataTable = new DataTable();

            adapt = new SqlDataAdapter("SELECT * FROM Vehicles", _dm.connection);
            adapt.Fill(dataTable);
            gridVehicle.DataSource = dataTable;
            gridVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            if (_dm.connection.State == ConnectionState.Open)
            {
                _dm.connection.Close();
            }
        }

        public void DisplayUser()
        {
            _dm.ConnectDb();
            DataTable dataTable = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM [Users]", _dm.connection);
            adapt.Fill(dataTable);
            gridUser.DataSource = dataTable;
            gridUser.Columns[1].Visible = false;
            gridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            if (_dm.connection.State == ConnectionState.Open)
            {
                _dm.connection.Close();
            }
        }

        public void ClearDataUser()
        {
            txtRegEmail.Text = "";
            txtRegPassword.Text = "";
            txtFullNam.Text = "";
            txtPhone.Text = "";
            cbbRole.SelectedIndex = 0;
        }

        public void InitCbb()
        {
            //Cbb type vehicle
            cbbTypes.Items.Add("Car");
            cbbTypes.Items.Add("Bike");
            cbbTypes.SelectedIndex = 0;
            cbbTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            //Cbb role user
            cbbRole.Items.Add("Staff");
            cbbRole.Items.Add("Admin");
            cbbRole.SelectedIndex = 0;
            cbbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void ClearData()
        {
            id = 0;
            txtName.Text = "";
            txtAddOn.Text = "";
            txtManu.Text = "";
            txtModel.Text = "";
            txtPrice.Text = "";
            txtRegis_Year.Text = "";
            cbbTypes.SelectedIndex = 0;
        }

        private void gridTransports_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(gridVehicle.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = gridVehicle.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtManu.Text = gridVehicle.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtModel.Text = gridVehicle.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRegis_Year.Text = gridVehicle.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddOn.Text = gridVehicle.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPrice.Text = gridVehicle.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (gridVehicle.Rows[e.RowIndex].Cells[7].Value.ToString().Equals("Bike"))
            {
                cbbTypes.SelectedIndex = 1;
            }
            else
            {
                cbbTypes.SelectedIndex = 0;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string manu = txtManu.Text.Trim();
            string model = txtModel.Text.Trim();
            string year = txtRegis_Year.Text.Trim();
            string addon = txtAddOn.Text.Trim();
            string price = txtPrice.Text.Trim();
            string type = (string) cbbTypes.SelectedItem;
            double test;
            if (name.Length > 255 || name.Length == 0)
            {
                MessageBox.Show(@"Name cannot be left blank or over 255 characters");
            }
            else if (manu.Length > 100 || manu.Length == 0)
            {
                MessageBox.Show(@"Manufactures cannot be left blank or over 100 characters");
            }
            else if (model.Length > 100 || model.Length == 0)
            {
                MessageBox.Show(@"Model cannot be left blank or over 100 characters");
            }
            else if (addon.Length == 0 || addon.Length > 255)
            {
                MessageBox.Show(@"Add-on cannot be left blank or over 255 characters");
            }
            else if (year.Length != 4 || !Regex.IsMatch(year, @"^\d+$"))
            {
                MessageBox.Show(@"Year must contain 4 characters and number only");
            }
            else if (!Double.TryParse(price, out test))
            {
                MessageBox.Show(@"Price must be nummerics");
            }
            else
            {
                _dm.ConnectDb();
                int success = _dm.InsertData("Vehicles",
                    new string[] {"name", "manufacturers", "model", "registration_year", "add_on", "price_hour", "type"},
                    new object[] {name, manu, model, year, addon, price, type});
                if (success > 0)
                {
                    MessageBox.Show(@"Add new vehicle successful");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show(@"Failure when adding! Please contact with technical");
                }
                if (_dm.connection.State == ConnectionState.Open)
                {
                    _dm.connection.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _dm.ConnectDb();
            adapt = null;
            gridVehicle.DataSource = null;
            DataTable dataTable = new DataTable();
            string name = txtName.Text.Trim();
            string type = (string) cbbTypes.SelectedItem;
            adapt = new SqlDataAdapter(
                "SELECT * FROM Vehicles WHERE name LIKE '%" + name + "%' AND type='" + type + "'", _dm.connection);
            adapt.Fill(dataTable);
            gridVehicle.DataSource = dataTable;
            if (_dm.connection.State == ConnectionState.Open)
            {
                _dm.connection.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
            DisplayData();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                DisplayData();
                AcceptButton = btnInsert;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                DisplayOrder();
                
            }
            else
            {
                DisplayUser();
                AcceptButton = btnRegister;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string regEmail = txtRegEmail.Text.Trim();
            string regPassword = txtRegPassword.Text.Trim();
            string fullname = txtFullNam.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string role = (string) cbbRole.SelectedItem;

            if (regEmail.Length == 0 || regEmail.Length > 255)
            {
                MessageBox.Show(@"Email cannot be left blank or over 255 characters");
            }
            else if (regPassword.Length > 255 || regPassword.Length == 0)
            {
                MessageBox.Show(@"Password cannot be left blank or over 255 characters");
            }
            else if (fullname.Length == 0 || fullname.Length > 255)
            {
                MessageBox.Show(@"Fullname cannot be left blank or over 255 characters");
            }
            else if (phone.Length == 0 || phone.Length > 20)
            {
                MessageBox.Show(@"Phone cannot be left blank or over 20 characters");
            }
            else if (!Regex.IsMatch(phone, @"^\d+$"))
            {
                MessageBox.Show(@"Phone must contain numbers only");
            }
            else if (!_login.IsValidEmail(regEmail))
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
            else if (_login.IsExisted(regEmail))
            {
                MessageBox.Show(@"Email is existed. Please choose other email");
            }
            else
            {
                _dm.ConnectDb();
                int success = _dm.InsertData("[Users]",
                    new string[] {"email", "password", "fullname", "phone", "role"},
                    new object[] {regEmail, regPassword, fullname, phone, role});
                if (success > 0)
                {
                    MessageBox.Show(@"Add new User successful");
                    DisplayUser();
                    ClearDataUser();
                }
                else
                {
                    MessageBox.Show(@"Failure when adding! Please contact with technical");
                }
                if (_dm.connection.State == ConnectionState.Open)
                {
                    _dm.connection.Close();
                }
            }
        }

        private void gridVehicle_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("Testing id vehicle is " + id);
        }

        private void gridUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            email_user = gridUser.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (email_user.Length == 0)
            {
                MessageBox.Show(@"Please choose user before reset password");
            }
            else
            {
                switch (MessageBox.Show(this,
                    "Are you sure you want to reset password of " + email_user + "?", "Closing", MessageBoxButtons.YesNo)
                )
                {
                    case DialogResult.Yes:
                        _dm.ConnectDb();
                        int success = _dm.UpdateData("[Users]",
                            new string[] {"password", "email"},
                            new object[] {123456, email_user });
                        if (success > 0)
                        {
                            MessageBox.Show(@"Reset password for " + email_user + @" successful");
                        }
                        else
                        {
                            MessageBox.Show(@"Reset password fail");
                        }
                        if (_dm.connection.State == ConnectionState.Open)
                        {
                            _dm.connection.Close();
                        }
                        break;
                }
            }
        }
    }
}