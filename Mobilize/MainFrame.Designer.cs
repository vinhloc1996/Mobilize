namespace Mobilize
{
    partial class mainFrame
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
            this.gridTransports = new System.Windows.Forms.DataGridView();
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
            this.label7 = new System.Windows.Forms.Label();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.gridUser = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabTransport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransports)).BeginInit();
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
            this.tabTransport.Controls.Add(this.gridTransports);
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
            this.tabTransport.Text = "Transport";
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
            // gridTransports
            // 
            this.gridTransports.AllowUserToAddRows = false;
            this.gridTransports.AllowUserToDeleteRows = false;
            this.gridTransports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransports.Location = new System.Drawing.Point(7, 194);
            this.gridTransports.Name = "gridTransports";
            this.gridTransports.ReadOnly = true;
            this.gridTransports.Size = new System.Drawing.Size(861, 192);
            this.gridTransports.TabIndex = 14;
            this.gridTransports.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridTransports_RowHeaderMouseClick);
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
            this.gridOrder.Location = new System.Drawing.Point(6, 73);
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.ReadOnly = true;
            this.gridOrder.Size = new System.Drawing.Size(861, 176);
            this.gridOrder.TabIndex = 0;
            // 
            // tabUser
            // 
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
            this.gridUser.Location = new System.Drawing.Point(6, 275);
            this.gridUser.Name = "gridUser";
            this.gridUser.ReadOnly = true;
            this.gridUser.Size = new System.Drawing.Size(862, 111);
            this.gridUser.TabIndex = 0;
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainFrame";
            this.Text = "Mobilize - Staff Frame";
            this.tabControl1.ResumeLayout(false);
            this.tabTransport.ResumeLayout(false);
            this.tabTransport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransports)).EndInit();
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
        private System.Windows.Forms.DataGridView gridTransports;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridUser;
    }
}