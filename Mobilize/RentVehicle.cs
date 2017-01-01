using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Mobilize.database;

namespace Mobilize
{
    public partial class RentVehicle : Form
    {
        private readonly Dm _dm;
        private readonly int _id;
        private double _total;
        private readonly string _emails;
        private double _price;
        private readonly string _curDate = DateTime.Now.ToString("yyyy-MM-dd");

        public RentVehicle(string userEmail, int idVehicle)
        {
            InitializeComponent();
            _dm = new Dm();
            Text = @"Order Form";
            _emails = userEmail;
            _id = idVehicle;
            InfoVehicle();
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void InfoVehicle()
        {
            _dm.ConnectDb();
            SqlDataReader reader = _dm.SelectData("SELECT name, price_hour FROM Vehicles WHERE id = '" + _id + "'");
            txtVehicleName.Text = reader.GetString(0);
            _price = reader.GetDouble(1);
            txtVehiclePrice.Text = _price.ToString(CultureInfo.InvariantCulture);
            if (_dm.Connection.State == ConnectionState.Open)
            {
                _dm.Connection.Close();
            }
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
                        break;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(@"Error when closing windows " + exp.Message);
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            string cusName = txtCusName.Text.Trim();
            string cusPhone = txtCusPhone.Text.Trim();
            string time = txtTime.Text.Trim();
            if (cusName.Length == 0)
            {
                MessageBox.Show(@"Customer Name cannot be left blank");
            }
            else if (!Regex.IsMatch(cusPhone, @"^\d+$"))
            {
                MessageBox.Show(@"Phone must contain number only");
            }
            else if (cusPhone.Length == 0)
            {
                MessageBox.Show(@"Phone cannot be left blank");
            }
            else if (time.Length == 0)
            {
                MessageBox.Show(@"Please enter hour rent of vehicle");
            }
            else
            {
                switch (
                    MessageBox.Show(this, @"Are your sure you want to rent this vehicle?", @"Closing",
                        MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        _dm.ConnectDb();
                        int success = _dm.InsertData("[Orders]",
                            new[]
                            {
                                "cus_name", "cus_phone", "user_email", "vehicle_id", "rent_hour", "subtotal",
                                "create_date"
                            },
                            new object[] {cusName, cusPhone, _emails, _id, time, _total, _curDate});
                        if (success > 0)
                        {
                            MessageBox.Show(@"Rent Vehicle successful");
                            Dispose();
                        }
                        else
                        {
                            MessageBox.Show(@"Rent Vehicle Failure");
                        }
                        if (_dm.Connection.State == ConnectionState.Open)
                        {
                            _dm.Connection.Close();
                        }
                        break;
                }
            }
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            if (txtTime.Text.Length != 0)
            {
                if (!Double.TryParse(txtTime.Text.Trim(), out _total))
                {
                    MessageBox.Show(@"Price must contain number only");
                }
                else
                {
                    _total = Convert.ToDouble(txtTime.Text.Trim()) * _price;
                    txtSubTotal.Text = _total.ToString(CultureInfo.InvariantCulture);
                }
            }
            else
            {
                txtSubTotal.Text = "";
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}