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

        private void btnRent_Click(object sender, EventArgs e)
        {
            //Get all values from input fields
            string cusName = txtCusName.Text.Trim();
            string cusPhone = txtCusPhone.Text.Trim();
            string time = txtTime.Text.Trim();
            #region Validate Form Order Vehicle
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
            #endregion
            else
            {
                switch (MessageBox.Show(this, @"Are your sure you want to rent this vehicle?", @"Closing",
                        MessageBoxButtons.YesNo))   //Ask for confirming the order
                {
                    case DialogResult.Yes:
                        _dm.ConnectDb();    //Connect DB
                        int success = _dm.InsertData("[Orders]",
                            new[] {"cus_name", "cus_phone", "user_email", "vehicle_id", "rent_hour", "subtotal", "create_date"},
                            new object[] {cusName, cusPhone, _emails, _id, time, _total, _curDate});    //Excute Create Order
                        if (success > 0)    //Check if insert is succeed
                        {
                            MessageBox.Show(@"Rent Vehicle successful");
                            Dispose();      //Close this windows if succeed
                        }
                        else
                        {
                            MessageBox.Show(@"Rent Vehicle Failure");
                        }

                        #region Close Connection
                        if (_dm.Connection.State == ConnectionState.Open)
                        {
                            _dm.Connection.Close();
                        }
                        #endregion
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