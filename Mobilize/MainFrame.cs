using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ExportToExcel;
using Mobilize.database;

namespace Mobilize
{
    public partial class MainFrame : Form
    {
        private readonly Dm _dm;
        private readonly LoginForm _login;
        SqlDataAdapter _adapt;
        private int _id;
        private readonly string _curEmail;
        private string _emailUser = "";

        public MainFrame(string email, string role)
        {
            InitializeComponent();
            Text = @"Mobilize - " + email + @" (" + role + @")";
            _curEmail = email;
            _dm = new Dm();
            _login = new LoginForm();
            DisplayData();
            AcceptButton = btnInsert;
            InitCbb();
            if (role.Equals("Staff"))
            {
                tabControl1.TabPages.Remove(tabUser);
                lblMonthYear.Visible = false;
                cbbMonthYear.Visible = false;
                btnExport.Visible = false;
            }
            else
            {
                InitYearMonthCombobox();
            }
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                base.OnFormClosing(e);

                if (e.CloseReason == CloseReason.WindowsShutDown) return;

                // Confirm user wants to close
                switch (MessageBox.Show(this, @"Are you sure you want to close?", @"Closing", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        Dispose();
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(@"Error when closing windows " + exp.Message);
            }
        }

        public void DisplayOrder()
        {
            _dm.ConnectDb();
            DataTable dataTable = new DataTable();
            _adapt = new SqlDataAdapter("SELECT * FROM [Orders]", _dm.Connection);
            _adapt.Fill(dataTable);
            gridOrder.DataSource = dataTable;
            gridOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (_dm.Connection.State == ConnectionState.Open)
            {
                _dm.Connection.Close();
            }
        }

        public void DisplayData()
        {
            _dm.ConnectDb();
            DataTable dataTable = new DataTable();

            _adapt = new SqlDataAdapter("SELECT * FROM Vehicles", _dm.Connection);
            _adapt.Fill(dataTable);
            gridVehicle.DataSource = dataTable;
            gridVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (_dm.Connection.State == ConnectionState.Open)
            {
                _dm.Connection.Close();
            }
        }

        public void DisplayUser()
        {
            _dm.ConnectDb();
            DataTable dataTable = new DataTable();
            _adapt = new SqlDataAdapter("SELECT * FROM [Users]", _dm.Connection);
            _adapt.Fill(dataTable);
            gridUser.DataSource = dataTable;
            gridUser.Columns[1].Visible = false;
            gridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (_dm.Connection.State == ConnectionState.Open)
            {
                _dm.Connection.Close();
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
            _id = 0;
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
            _id = Convert.ToInt32(gridVehicle.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = gridVehicle.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtManu.Text = gridVehicle.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtModel.Text = gridVehicle.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRegis_Year.Text = gridVehicle.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddOn.Text = gridVehicle.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPrice.Text = gridVehicle.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbbTypes.SelectedIndex = gridVehicle.Rows[e.RowIndex].Cells[7].Value.ToString().Equals("Bike") ? 1 : 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string nameVehicle = txtName.Text.Trim();
            string manu = txtManu.Text.Trim();
            string model = txtModel.Text.Trim();
            string year = txtRegis_Year.Text.Trim();
            string addon = txtAddOn.Text.Trim();
            string price = txtPrice.Text.Trim();
            string type = (string) cbbTypes.SelectedItem;
            double test;
            if (nameVehicle.Length > 255 || nameVehicle.Length == 0)
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
                    new[] {"name", "manufacturers", "model", "registration_year", "add_on", "price_hour", "type"},
                    new object[] {nameVehicle, manu, model, year, addon, price, type});
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
                if (_dm.Connection.State == ConnectionState.Open)
                {
                    _dm.Connection.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _dm.ConnectDb();
            _adapt = null;
            gridVehicle.DataSource = null;
            DataTable dataTable = new DataTable();
            string nameVehicle = txtName.Text.Trim();
            string type = (string) cbbTypes.SelectedItem;
            _adapt = new SqlDataAdapter(
                "SELECT * FROM Vehicles WHERE name LIKE '%" + nameVehicle + "%' AND type='" + type + "'", _dm.Connection);
            _adapt.Fill(dataTable);
            gridVehicle.DataSource = dataTable;
            if (_dm.Connection.State == ConnectionState.Open)
            {
                _dm.Connection.Close();
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
                    new[] {"email", "password", "fullname", "phone", "role"},
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
                if (_dm.Connection.State == ConnectionState.Open)
                {
                    _dm.Connection.Close();
                }
            }
        }

        private void gridVehicle_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RentVehicle rent = new RentVehicle(_curEmail, _id);
            rent.ShowDialog();
        }

        private void gridUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _emailUser = gridUser.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (_emailUser.Length == 0)
            {
                MessageBox.Show(@"Please choose user before reset password");
            }
            else
            {
                switch (MessageBox.Show(this,
                    @"Are you sure you want to reset password of " + _emailUser + @"?", @"Closing",
                    MessageBoxButtons.YesNo)
                )
                {
                    case DialogResult.Yes:
                        _dm.ConnectDb();
                        int success = _dm.UpdateData("[Users]",
                            new[] {"password", "email"},
                            new object[] {123456, _emailUser});
                        if (success > 0)
                        {
                            MessageBox.Show(@"Reset password for " + _emailUser + @" successful");
                        }
                        else
                        {
                            MessageBox.Show(@"Reset password fail");
                        }
                        if (_dm.Connection.State == ConnectionState.Open)
                        {
                            _dm.Connection.Close();
                        }
                        break;
                }
            }
        }

        public void InitYearMonthCombobox()
        {
            _dm.ConnectDb();
            string query = "SELECT DISTINCT MONTH(create_date), YEAR(create_date) FROM [Orders]";
            SqlDataReader reader = _dm.SelectData(query);
            if (reader != null)
            {
                cbbMonthYear.Items.Add(reader.GetInt32(0) + "/" + reader.GetInt32(1));
                while (reader.Read())
                {
                    cbbMonthYear.Items.Add(reader.GetInt32(0) + "/" + reader.GetInt32(1));
                }
            }
            cbbMonthYear.SelectedIndex = 0;
            cbbMonthYear.DropDownStyle = ComboBoxStyle.DropDownList;
            if (_dm.Connection.State == ConnectionState.Open)
            {
                _dm.Connection.Close();
            }
        }

        public DataSet GetDataOrders(string[] monthYear)
        {
            _dm.ConnectDb();
            DataTable dataTable = new DataTable(monthYear[0] + "-" + monthYear[1]);
            _adapt =
                new SqlDataAdapter(
                    "SELECT * FROM [Orders] WHERE create_date BETWEEN '" + monthYear[1] + "-" + monthYear[0] + "-" + 1 +
                    "' " +
                    "AND '" + monthYear[1] + "-" + monthYear[0] + "-" + 31 + "'", _dm.Connection);
            _adapt.Fill(dataTable);
            DataSet ds = new DataSet();
            ds.Tables.Add(dataTable);
            if (_dm.Connection.State == ConnectionState.Open)
            {
                _dm.Connection.Close();
            }
            return ds;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string monthYear = (string) cbbMonthYear.SelectedItem;
            string[] abc = monthYear.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            saveFileDialog1.FileName = "Report Orders " + abc[0] + "-" + abc[1] + ".xlsx";
            saveFileDialog1.Filter = @"Excel 2007 files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.OverwritePrompt = false;
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string targetFilename = saveFileDialog1.FileName;
            DataSet ds = GetDataOrders(abc);
            try
            {
                CreateExcelFile.CreateExcelDocument(ds, targetFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Couldn't create Excel file.\r\nException: " + ex.Message);
                return;
            }
            Process p = new Process {StartInfo = new ProcessStartInfo(targetFilename)};
            p.Start();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            ((DataTable) gridOrder.DataSource).DefaultView.RowFilter = $"cus_name like '%{txtFilter.Text.Trim()}%'";
        }
    }
}