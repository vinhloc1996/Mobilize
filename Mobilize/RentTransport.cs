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
        private string emails;
        private string name;
        private string type;
        private double price;
        public RentTransport(string email)
        {
            InitializeComponent();
            dm = new Dm();
            this.Text = "Mobilize - " + email;
            emails = email;
        }

        public int Get_Id()
        {
            return this.id_transport;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("name like '%{0}%'", txtFilter.Text.Trim());
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

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (id_transport <= 0)
            {
                MessageBox.Show(@"Emai must be followed the format");
            }else if (txtTime.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Emai must be followed the format");
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
                            new object[] {emails, id_transport, Convert.ToDouble(txtTime.Text.Trim()), Convert.ToDouble(lblToTal.Text)});
                        if (success > 0)
                        {
                            MessageBox.Show(@"Emai must be followed the format");
                            Environment.Exit(0);
                        }
                        else
                        {
                            MessageBox.Show(@"Emai must be followed the format");
                        }
                        if (dm.connection.State == ConnectionState.Open)
                        {
                            dm.connection.Close();
                        }
                        break;
                }
            }
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            if (id_transport > 0)
            {
                double total;
                if (!Double.TryParse(txtTime.Text.Trim(), out total))
                {
                    MessageBox.Show(@"Emai must be followed the format");
                }
                else
                {
                    total = Convert.ToDouble(txtTime.Text.Trim()) * Convert.ToDouble(lblPrice.Text);
                    lblToTal.Text = total.ToString();
                }
            }
            else
            {
                MessageBox.Show(@"Emai must be followed the format");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {

        }
    }
}
