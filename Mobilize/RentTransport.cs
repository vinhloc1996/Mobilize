using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Mobilize.database;

namespace Mobilize
{
    public partial class RentTransport : Form
    {
        private Dm dm;
        private int id_transport = 0;
        private string name;
        private string type;
        private double price;
        public RentTransport(string email)
        {
            InitializeComponent();
            dm = new Dm();
            DisplayData();
//            lblEmail.Text = email;
            this.Text = "Mobilize - " + email;
        }

        public int Get_Id()
        {
            return this.id_transport;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("name like '%{0}%'", txtFilter.Text.Trim());
        }

        public void DisplayData()
        {
            dm.ConnectDb();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Transports", dm.connection);
            adapt.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            if (dm.connection.State == ConnectionState.Open)
            {
                dm.connection.Close();
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

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_transport = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            type = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            price = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());

            lblPrice.Text = price.ToString();
            label3.Text = name;
            lblType.Text = type;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            string email = lblEmail.Text;
            if (id_transport <= 0)
            {
                MessageBox.Show("Please select transport before rent");
            }else if (txtTime.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter hour you rent the transport");
            }
            else
            {
                switch (
                    MessageBox.Show(this, "Are your sure you want to rent this transport?", "Closing",
                        MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        dm.ConnectDb();
                        int success = dm.InsertData("[Order]", 
                            new string[] {"user_email", "transport_id", "rent_hour", "subtotal"}, 
                            new object[] {email, id_transport, Convert.ToDouble(txtTime.Text.Trim()), Convert.ToDouble(lblToTal.Text)});
                        if (success > 0)
                        {
                            MessageBox.Show("Order successful!\nPleases wait for our contacts");
                            Environment.Exit(0);
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                        if (dm.connection.State == ConnectionState.Open)
                        {
                            dm.connection.Close();
                        }
                        break;
                }
            }
        }
    }
}
