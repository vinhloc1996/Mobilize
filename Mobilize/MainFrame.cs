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
        private Dm dm;
        SqlDataAdapter adapt;
        private int id = 0;
        public mainFrame()
        {
            InitializeComponent();
            dm = new Dm();
            DisplayData();
            InitCbb();
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
                
            }
        }

        public void DisplayOrder()
        {
            dm.ConnectDb();
            DataTable dataTable = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM [Order]", dm.connection);
            adapt.Fill(dataTable);
            gridOrder.DataSource = dataTable;
            gridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            if (dm.connection.State == ConnectionState.Open)
            {
                dm.connection.Close();
            }
            
        }

        public void DisplayData()
        {
            dm.ConnectDb();
            DataTable dataTable = new DataTable();

            adapt = new SqlDataAdapter("SELECT * FROM Transports", dm.connection);
            adapt.Fill(dataTable);
            gridTransports.DataSource = dataTable;
            gridTransports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            if (dm.connection.State == ConnectionState.Open)
            {
                dm.connection.Close();
            }
        }

        public void DisplayUser()
        {
            dm.ConnectDb();
            DataTable dataTable = new DataTable();
            adapt = new SqlDataAdapter("SELECT email, fullname, phone FROM [Users]", dm.connection);
            adapt.Fill(dataTable);
            gridUser.DataSource = dataTable;
            gridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            if (dm.connection.State == ConnectionState.Open)
            {
                dm.connection.Close();
            }
        }

        public void InitCbb()
        {
            cbbTypes.Items.Add("Car");
            cbbTypes.Items.Add("Bike");
            cbbTypes.SelectedIndex = 0;
            cbbTypes.DropDownStyle = ComboBoxStyle.DropDownList;
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
            id = Convert.ToInt32(gridTransports.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = gridTransports.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtManu.Text = gridTransports.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtModel.Text = gridTransports.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRegis_Year.Text = gridTransports.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddOn.Text = gridTransports.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPrice.Text = gridTransports.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (gridTransports.Rows[e.RowIndex].Cells[7].Value.ToString().Equals("Bike"))
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
            string type = (string)cbbTypes.SelectedItem;
            double test;
            if (addon.Length == 0 || addon.Length > 255)
            {
                MessageBox.Show("Add-on cannot be left blank and its length must smaller than 255 characters!");
            }
            else if (year.Length != 4 || !Regex.IsMatch(year, @"^\d+$"))
            {
                MessageBox.Show("Year must be contained 4 numbers");
            }else if (!Double.TryParse(price, out test))
            {
                MessageBox.Show("Price must be in double type");
            }else if (name.Length > 255 || name.Length == 0)
            {
                MessageBox.Show("Name cannot be left blank and its length must smaller than 255 characters!");
            }else if (manu.Length > 100 || manu.Length == 0)
            {
                MessageBox.Show("Manufactures cannot be left blank and its length must smaller than 100 characters!");
            }else if (model.Length > 100 || model.Length == 0)
            {
                MessageBox.Show("Model cannot be left blank and its length must smaller than 100 characters!");
            }
            else
            {
                dm.ConnectDb();
                int success = dm.InsertData("Transports",
                    new string[] { "name", "manufacturers", "model", "registration_year", "add_on", "price_hour", "type" },
                    new object[] { name, manu, model, year, addon, price, type });
                if (success > 0)
                {
                    MessageBox.Show("Insert Successful");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Insert Failed");
                }
                if (dm.connection.State == ConnectionState.Open)
                {
                    dm.connection.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dm.ConnectDb();
            adapt = null;
            gridTransports.DataSource = null;
            DataTable dataTable = new DataTable();
            string name = txtName.Text.Trim();
            string type = (string)cbbTypes.SelectedItem;
            adapt = new SqlDataAdapter("SELECT * FROM Transports WHERE name LIKE '%"+name+"%' AND type='"+type+"'", dm.connection);
            adapt.Fill(dataTable);
            gridTransports.DataSource = dataTable;
            if (dm.connection.State == ConnectionState.Open)
            {
                dm.connection.Close();
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
            }else if (tabControl1.SelectedIndex == 1)
            {
                DisplayOrder();
            }
            else
            {
                DisplayUser();
            }
        }
    }
}
