namespace Mobilize
{
    partial class RentVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.txtVehiclePrice = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total Price";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(392, 18);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 24;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Time Rent";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(333, 102);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 28);
            this.btnRent.TabIndex = 16;
            this.btnRent.Text = "Rent Car";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(434, 102);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 28);
            this.btnCancle.TabIndex = 27;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Customer Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Vehicle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Price per hour";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(100, 22);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(154, 20);
            this.txtCusName.TabIndex = 32;
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(100, 48);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(154, 20);
            this.txtCusPhone.TabIndex = 33;
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.Location = new System.Drawing.Point(100, 74);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.ReadOnly = true;
            this.txtVehicleName.Size = new System.Drawing.Size(154, 20);
            this.txtVehicleName.TabIndex = 34;
            // 
            // txtVehiclePrice
            // 
            this.txtVehiclePrice.Location = new System.Drawing.Point(100, 102);
            this.txtVehiclePrice.Name = "txtVehiclePrice";
            this.txtVehiclePrice.ReadOnly = true;
            this.txtVehiclePrice.Size = new System.Drawing.Size(154, 20);
            this.txtVehiclePrice.TabIndex = 35;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(392, 51);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 36;
            // 
            // RentVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 158);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtVehiclePrice);
            this.Controls.Add(this.txtVehicleName);
            this.Controls.Add(this.txtCusPhone);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRent);
            this.Name = "RentVehicle";
            this.Text = "MobiLize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.TextBox txtVehiclePrice;
        private System.Windows.Forms.TextBox txtSubTotal;
    }
}