namespace Error_Food
{
    partial class Form_Ship
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
            this.DgvNameSC = new System.Windows.Forms.DataGridView();
            this.Dgv_Food = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_ManyFoods = new System.Windows.Forms.DataGridView();
            this.Bt_Delete = new System.Windows.Forms.Button();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.Bt_Add = new System.Windows.Forms.Button();
            this.Bt_Bill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_Food = new System.Windows.Forms.Label();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_Name_Food = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNameSC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ManyFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvNameSC
            // 
            this.DgvNameSC.AllowUserToAddRows = false;
            this.DgvNameSC.BackgroundColor = System.Drawing.Color.White;
            this.DgvNameSC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvNameSC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvNameSC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvNameSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNameSC.GridColor = System.Drawing.Color.White;
            this.DgvNameSC.Location = new System.Drawing.Point(0, 0);
            this.DgvNameSC.Name = "DgvNameSC";
            this.DgvNameSC.RowHeadersVisible = false;
            this.DgvNameSC.RowHeadersWidth = 51;
            this.DgvNameSC.RowTemplate.Height = 24;
            this.DgvNameSC.Size = new System.Drawing.Size(321, 866);
            this.DgvNameSC.TabIndex = 8;
            this.DgvNameSC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNameSC_CellContentClick);
            // 
            // Dgv_Food
            // 
            this.Dgv_Food.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dgv_Food.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Food.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.Dgv_Food.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_Food.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Food.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_Food.Location = new System.Drawing.Point(320, 0);
            this.Dgv_Food.Name = "Dgv_Food";
            this.Dgv_Food.RowHeadersWidth = 50;
            this.Dgv_Food.RowTemplate.Height = 24;
            this.Dgv_Food.Size = new System.Drawing.Size(755, 869);
            this.Dgv_Food.TabIndex = 9;
            this.Dgv_Food.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Food_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(1114, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 59);
            this.label1.TabIndex = 41;
            this.label1.Text = "Phone  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label6.Location = new System.Drawing.Point(1114, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 59);
            this.label6.TabIndex = 40;
            this.label6.Text = "Name : ";
            // 
            // txb_Phone
            // 
            this.txb_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Phone.Font = new System.Drawing.Font("Noto Sans", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Phone.Location = new System.Drawing.Point(1376, 131);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(368, 51);
            this.txb_Phone.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(1374, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 3);
            this.panel4.TabIndex = 38;
            // 
            // txb_Name
            // 
            this.txb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Name.Font = new System.Drawing.Font("Noto Sans", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Name.Location = new System.Drawing.Point(1376, 17);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(368, 51);
            this.txb_Name.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(1374, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 3);
            this.panel3.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(1114, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 59);
            this.label2.TabIndex = 44;
            this.label2.Text = "Address  :";
            // 
            // txb_Address
            // 
            this.txb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Address.Font = new System.Drawing.Font("Noto Sans", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Address.Location = new System.Drawing.Point(1376, 263);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(368, 51);
            this.txb_Address.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(1374, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 3);
            this.panel1.TabIndex = 42;
            // 
            // Dgv_ManyFoods
            // 
            this.Dgv_ManyFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_ManyFoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.Dgv_ManyFoods.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_ManyFoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_ManyFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ManyFoods.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_ManyFoods.Location = new System.Drawing.Point(1124, 347);
            this.Dgv_ManyFoods.Name = "Dgv_ManyFoods";
            this.Dgv_ManyFoods.RowHeadersWidth = 50;
            this.Dgv_ManyFoods.RowTemplate.Height = 24;
            this.Dgv_ManyFoods.Size = new System.Drawing.Size(622, 298);
            this.Dgv_ManyFoods.TabIndex = 45;
            this.Dgv_ManyFoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ManyFoods_CellContentClick);
            // 
            // Bt_Delete
            // 
            this.Bt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Bt_Delete.FlatAppearance.BorderSize = 0;
            this.Bt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Delete.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Delete.ForeColor = System.Drawing.Color.White;
            this.Bt_Delete.Location = new System.Drawing.Point(1577, 676);
            this.Bt_Delete.Name = "Bt_Delete";
            this.Bt_Delete.Size = new System.Drawing.Size(142, 60);
            this.Bt_Delete.TabIndex = 50;
            this.Bt_Delete.Text = "Delete";
            this.Bt_Delete.UseVisualStyleBackColor = false;
            this.Bt_Delete.Click += new System.EventHandler(this.Bt_Delete_Click);
            // 
            // Bt_Update
            // 
            this.Bt_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Bt_Update.FlatAppearance.BorderSize = 0;
            this.Bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Update.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Update.ForeColor = System.Drawing.Color.White;
            this.Bt_Update.Location = new System.Drawing.Point(1366, 676);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(142, 60);
            this.Bt_Update.TabIndex = 49;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = false;
            this.Bt_Update.Click += new System.EventHandler(this.Bt_Update_Click);
            // 
            // Bt_Add
            // 
            this.Bt_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Bt_Add.FlatAppearance.BorderSize = 0;
            this.Bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Add.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Add.ForeColor = System.Drawing.Color.White;
            this.Bt_Add.Location = new System.Drawing.Point(1155, 676);
            this.Bt_Add.Name = "Bt_Add";
            this.Bt_Add.Size = new System.Drawing.Size(142, 60);
            this.Bt_Add.TabIndex = 48;
            this.Bt_Add.Text = "Add";
            this.Bt_Add.UseVisualStyleBackColor = false;
            this.Bt_Add.Click += new System.EventHandler(this.Bt_Add_Click);
            // 
            // Bt_Bill
            // 
            this.Bt_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Bt_Bill.FlatAppearance.BorderSize = 0;
            this.Bt_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Bill.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Bill.ForeColor = System.Drawing.Color.White;
            this.Bt_Bill.Location = new System.Drawing.Point(1366, 774);
            this.Bt_Bill.Name = "Bt_Bill";
            this.Bt_Bill.Size = new System.Drawing.Size(142, 60);
            this.Bt_Bill.TabIndex = 51;
            this.Bt_Bill.Text = "Bill";
            this.Bt_Bill.UseVisualStyleBackColor = false;
            this.Bt_Bill.Click += new System.EventHandler(this.Bt_Bill_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(1145, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 59);
            this.label3.TabIndex = 57;
            this.label3.Text = "Price  :";
            // 
            // Name_Food
            // 
            this.Name_Food.AutoSize = true;
            this.Name_Food.Font = new System.Drawing.Font("Sitka Small", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Food.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Name_Food.Location = new System.Drawing.Point(1145, 417);
            this.Name_Food.Name = "Name_Food";
            this.Name_Food.Size = new System.Drawing.Size(185, 59);
            this.Name_Food.TabIndex = 56;
            this.Name_Food.Text = "Name : ";
            // 
            // txb_Price
            // 
            this.txb_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Price.Font = new System.Drawing.Font("Noto Sans", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Price.Location = new System.Drawing.Point(1346, 538);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(368, 51);
            this.txb_Price.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(1344, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 3);
            this.panel2.TabIndex = 54;
            // 
            // txb_Name_Food
            // 
            this.txb_Name_Food.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Name_Food.Font = new System.Drawing.Font("Noto Sans", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Name_Food.Location = new System.Drawing.Point(1346, 424);
            this.txb_Name_Food.Name = "txb_Name_Food";
            this.txb_Name_Food.Size = new System.Drawing.Size(368, 51);
            this.txb_Name_Food.TabIndex = 53;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(1344, 475);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(372, 3);
            this.panel5.TabIndex = 52;
            // 
            // Form_Ship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 866);
            this.Controls.Add(this.Dgv_ManyFoods);
            this.Controls.Add(this.Bt_Bill);
            this.Controls.Add(this.Bt_Delete);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.Bt_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Address);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_Phone);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Dgv_Food);
            this.Controls.Add(this.DgvNameSC);
            this.Controls.Add(this.Name_Food);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Price);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txb_Name_Food);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Ship";
            this.Text = "Ship";
            this.Load += new System.EventHandler(this.Form_Ship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNameSC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ManyFoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvNameSC;
        private System.Windows.Forms.DataGridView Dgv_Food;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_ManyFoods;
        private System.Windows.Forms.Button Bt_Delete;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.Button Bt_Add;
        private System.Windows.Forms.Button Bt_Bill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Name_Food;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txb_Name_Food;
        private System.Windows.Forms.Panel panel5;
    }
}