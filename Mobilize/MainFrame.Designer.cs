namespace Mobilize
{
    partial class MainFrame
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTransport = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gridVehicle = new System.Windows.Forms.DataGridView();
            this.cbbTypes = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAddOn = new System.Windows.Forms.TextBox();
            this.txtRegis_Year = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtManu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbMonthYear = new System.Windows.Forms.ComboBox();
            this.lblMonthYear = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullNam = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridUser = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabTransport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicle)).BeginInit();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTransport);
            this.tabControl1.Controls.Add(this.tabOrder);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 418);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTransport
            // 
            this.tabTransport.Controls.Add(this.btnReset);
            this.tabTransport.Controls.Add(this.btnSearch);
            this.tabTransport.Controls.Add(this.btnInsert);
            this.tabTransport.Controls.Add(this.gridVehicle);
            this.tabTransport.Controls.Add(this.cbbTypes);
            this.tabTransport.Controls.Add(this.txtPrice);
            this.tabTransport.Controls.Add(this.txtAddOn);
            this.tabTransport.Controls.Add(this.txtRegis_Year);
            this.tabTransport.Controls.Add(this.txtModel);
            this.tabTransport.Controls.Add(this.txtManu);
            this.tabTransport.Controls.Add(this.label6);
            this.tabTransport.Controls.Add(this.label5);
            this.tabTransport.Controls.Add(this.label4);
            this.tabTransport.Controls.Add(this.label3);
            this.tabTransport.Controls.Add(this.label2);
            this.tabTransport.Controls.Add(this.label1);
            this.tabTransport.Controls.Add(this.txtName);
            this.tabTransport.Controls.Add(this.name);
            this.tabTransport.Location = new System.Drawing.Point(4, 22);
            this.tabTransport.Name = "tabTransport";
            this.tabTransport.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransport.Size = new System.Drawing.Size(874, 392);
            this.tabTransport.TabIndex = 0;
            this.tabTransport.Text = "Vehicle";
            this.tabTransport.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(707, 135);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(603, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(490, 136);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gridVehicle
            // 
            this.gridVehicle.AllowUserToAddRows = false;
            this.gridVehicle.AllowUserToDeleteRows = false;
            this.gridVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVehicle.Location = new System.Drawing.Point(7, 194);
            this.gridVehicle.Name = "gridVehicle";
            this.gridVehicle.ReadOnly = true;
            this.gridVehicle.Size = new System.Drawing.Size(861, 192);
            this.gridVehicle.TabIndex = 14;
            this.gridVehicle.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridTransports_RowHeaderMouseClick);
            this.gridVehicle.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridVehicle_RowHeaderMouseDoubleClick);
            // 
            // cbbTypes
            // 
            this.cbbTypes.FormattingEnabled = true;
            this.cbbTypes.Location = new System.Drawing.Point(570, 80);
            this.cbbTypes.Name = "cbbTypes";
            this.cbbTypes.Size = new System.Drawing.Size(121, 21);
            this.cbbTypes.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(570, 47);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(179, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtAddOn
            // 
            this.txtAddOn.Location = new System.Drawing.Point(570, 15);
            this.txtAddOn.Name = "txtAddOn";
            this.txtAddOn.Size = new System.Drawing.Size(179, 20);
            this.txtAddOn.TabIndex = 11;
            // 
            // txtRegis_Year
            // 
            this.txtRegis_Year.Location = new System.Drawing.Point(166, 119);
            this.txtRegis_Year.Name = "txtRegis_Year";
            this.txtRegis_Year.Size = new System.Drawing.Size(179, 20);
            this.txtRegis_Year.TabIndex = 10;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(166, 84);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(179, 20);
            this.txtModel.TabIndex = 9;
            // 
            // txtManu
            // 
            this.txtManu.Location = new System.Drawing.Point(166, 49);
            this.txtManu.Name = "txtManu";
            this.txtManu.Size = new System.Drawing.Size(179, 20);
            this.txtManu.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price per hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add-On";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registration Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manufacturers";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(125, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.txtFilter);
            this.tabOrder.Controls.Add(this.label14);
            this.tabOrder.Controls.Add(this.cbbMonthYear);
            this.tabOrder.Controls.Add(this.lblMonthYear);
            this.tabOrder.Controls.Add(this.btnExport);
            this.tabOrder.Controls.Add(this.label7);
            this.tabOrder.Controls.Add(this.gridOrder);
            this.tabOrder.Location = new System.Drawing.Point(4, 22);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(874, 392);
            this.tabOrder.TabIndex = 1;
            this.tabOrder.Text = "Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(149, 59);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(167, 20);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Filter Customer Name";
            // 
            // cbbMonthYear
            // 
            this.cbbMonthYear.FormattingEnabled = true;
            this.cbbMonthYear.Location = new System.Drawing.Point(470, 337);
            this.cbbMonthYear.Name = "cbbMonthYear";
            this.cbbMonthYear.Size = new System.Drawing.Size(121, 21);
            this.cbbMonthYear.TabIndex = 4;
            // 
            // lblMonthYear
            // 
            this.lblMonthYear.AutoSize = true;
            this.lblMonthYear.Location = new System.Drawing.Point(378, 340);
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(64, 13);
            this.lblMonthYear.TabIndex = 3;
            this.lblMonthYear.Text = "Month/Year";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(630, 331);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(92, 31);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Report";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(318, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Vehicle Rent Activities";
            // 
            // gridOrder
            // 
            this.gridOrder.AllowUserToAddRows = false;
            this.gridOrder.AllowUserToDeleteRows = false;
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrder.Location = new System.Drawing.Point(6, 96);
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.ReadOnly = true;
            this.gridOrder.Size = new System.Drawing.Size(862, 215);
            this.gridOrder.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btnResetPass);
            this.tabUser.Controls.Add(this.cbbRole);
            this.tabUser.Controls.Add(this.label13);
            this.tabUser.Controls.Add(this.btnRegister);
            this.tabUser.Controls.Add(this.txtPhone);
            this.tabUser.Controls.Add(this.txtFullNam);
            this.tabUser.Controls.Add(this.txtRegPassword);
            this.tabUser.Controls.Add(this.txtRegEmail);
            this.tabUser.Controls.Add(this.label9);
            this.tabUser.Controls.Add(this.label10);
            this.tabUser.Controls.Add(this.label11);
            this.tabUser.Controls.Add(this.label12);
            this.tabUser.Controls.Add(this.label8);
            this.tabUser.Controls.Add(this.gridUser);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(874, 392);
            this.tabUser.TabIndex = 2;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(640, 174);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(110, 23);
            this.btnResetPass.TabIndex = 23;
            this.btnResetPass.Text = "Reset Password";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // cbbRole
            // 
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(531, 69);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(121, 21);
            this.cbbRole.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(488, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Role";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(504, 174);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(110, 23);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(193, 181);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 20);
            this.txtPhone.TabIndex = 19;
            // 
            // txtFullNam
            // 
            this.txtFullNam.Location = new System.Drawing.Point(193, 144);
            this.txtFullNam.Name = "txtFullNam";
            this.txtFullNam.Size = new System.Drawing.Size(168, 20);
            this.txtFullNam.TabIndex = 18;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(193, 107);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '*';
            this.txtRegPassword.Size = new System.Drawing.Size(168, 20);
            this.txtRegPassword.TabIndex = 17;
            this.txtRegPassword.UseSystemPasswordChar = true;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(193, 69);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(168, 20);
            this.txtRegEmail.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Full name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(351, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "User Information";
            // 
            // gridUser
            // 
            this.gridUser.AllowUserToAddRows = false;
            this.gridUser.AllowUserToDeleteRows = false;
            this.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUser.Location = new System.Drawing.Point(6, 227);
            this.gridUser.Name = "gridUser";
            this.gridUser.ReadOnly = true;
            this.gridUser.Size = new System.Drawing.Size(862, 159);
            this.gridUser.TabIndex = 0;
            this.gridUser.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridUser_RowHeaderMouseClick);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainFrame";
            this.Text = "Mobilize";
            this.tabControl1.ResumeLayout(false);
            this.tabTransport.ResumeLayout(false);
            this.tabTransport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehicle)).EndInit();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTransport;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAddOn;
        private System.Windows.Forms.TextBox txtRegis_Year;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtManu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbbTypes;
        private System.Windows.Forms.DataGridView gridVehicle;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridUser;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullNam;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cbbMonthYear;
        private System.Windows.Forms.Label lblMonthYear;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFilter;
    }
}