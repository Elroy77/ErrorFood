using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Food
{
    public partial class Form_Order : Form
    {
        SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
        bool Table_1_check = false;
        bool Table_2_check = false;
        bool Table_3_check = false;
        bool Table_4_check = false;
        bool Table_5_check = false;
        bool Table_6_check = false;
        bool Table_7_check = false;
        bool Table_8_check = false;
        bool Table_9_check = false;
        bool Table_10_check = false;
        bool Table_11_check = false;
        public Form_Order()
        {
            InitializeComponent();
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = false;
            //
            this.Dgv_ManyFoods.DefaultCellStyle.Font = new Font("Tahoma", 14);
            this.Dgv_ManyFoods.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
            this.Dgv_ManyFoods.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.Dgv_ManyFoods.DefaultCellStyle.SelectionBackColor = Color.White;
            this.Dgv_ManyFoods.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            //
            this.Dgv_Order.DefaultCellStyle.Font = new Font("Tahoma", 14);
            this.Dgv_Order.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
            this.Dgv_Order.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.Dgv_Order.DefaultCellStyle.SelectionBackColor = Color.White;
            this.Dgv_Order.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }

        private void Form_Order_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_ManyFoods.DataSource = dataSet.Tables[0];
                Dgv_ManyFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_1 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 1'";
            SqlDataAdapter sqldap_table_1 = new SqlDataAdapter(color_table_1, sqlcon);
            DataSet dts_table_1 = new DataSet();
            sqldap_table_1.Fill(dts_table_1);
            DataTable dataTable_1 = dts_table_1.Tables[0];
            if (dataTable_1.Rows.Count > 0)
            {
                Bt_Table_1.BackColor = Color.DeepSkyBlue;
            }    
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_2 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 2'";
            SqlDataAdapter sqldap_table_2 = new SqlDataAdapter(color_table_2, sqlcon);
            DataSet dts_table_2 = new DataSet();
            sqldap_table_2.Fill(dts_table_2);
            DataTable dataTable_2 = dts_table_2.Tables[0];
            if (dataTable_2.Rows.Count > 0)
            {
                Bt_Table_2.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_3 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 3'";
            SqlDataAdapter sqldap_table_3 = new SqlDataAdapter(color_table_3, sqlcon);
            DataSet dts_table_3 = new DataSet();
            sqldap_table_3.Fill(dts_table_3);
            DataTable dataTable_3 = dts_table_3.Tables[0];
            if (dataTable_3.Rows.Count > 0)
            {
                BT_Table_3.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_4 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 4'";
            SqlDataAdapter sqldap_table_4 = new SqlDataAdapter(color_table_4, sqlcon);
            DataSet dts_table_4 = new DataSet();
            sqldap_table_4.Fill(dts_table_4);
            DataTable dataTable_4 = dts_table_4.Tables[0];
            if (dataTable_4.Rows.Count > 0)
            {
                Bt_Table_4.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_5 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 5'";
            SqlDataAdapter sqldap_table_5 = new SqlDataAdapter(color_table_5, sqlcon);
            DataSet dts_table_5 = new DataSet();
            sqldap_table_5.Fill(dts_table_5);
            DataTable dataTable_5 = dts_table_5.Tables[0];
            if (dataTable_5.Rows.Count > 0)
            {
                Bt_Table_5.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_6 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 6'";
            SqlDataAdapter sqldap_table_6 = new SqlDataAdapter(color_table_6, sqlcon);
            DataSet dts_table_6 = new DataSet();
            sqldap_table_6.Fill(dts_table_6);
            DataTable dataTable_6 = dts_table_6.Tables[0];
            if (dataTable_6.Rows.Count > 0)
            {
                BT_Table_6.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_7 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 7'";
            SqlDataAdapter sqldap_table_7 = new SqlDataAdapter(color_table_7, sqlcon);
            DataSet dts_table_7 = new DataSet();
            sqldap_table_7.Fill(dts_table_7);
            DataTable dataTable_7 = dts_table_7.Tables[0];
            if (dataTable_7.Rows.Count > 0)
            {
                Bt_Table_7.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_8 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 8'";
            SqlDataAdapter sqldap_table_8 = new SqlDataAdapter(color_table_8, sqlcon);
            DataSet dts_table_8 = new DataSet();
            sqldap_table_8.Fill(dts_table_8);
            DataTable dataTable_8 = dts_table_8.Tables[0];
            if (dataTable_8.Rows.Count > 0)
            {
                Bt_Table_8.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_9 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 9'";
            SqlDataAdapter sqldap_table_9 = new SqlDataAdapter(color_table_9, sqlcon);
            DataSet dts_table_9 = new DataSet();
            sqldap_table_9.Fill(dts_table_9);
            DataTable dataTable_9 = dts_table_9.Tables[0];
            if (dataTable_9.Rows.Count > 0)
            {
                Bt_Table_9.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_10 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 10'";
            SqlDataAdapter sqldap_table_10 = new SqlDataAdapter(color_table_10, sqlcon);
            DataSet dts_table_10 = new DataSet();
            sqldap_table_10.Fill(dts_table_10);
            DataTable dataTable_10 = dts_table_10.Tables[0];
            if (dataTable_10.Rows.Count > 0)
            {
                Bt_Table_10.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string color_table_11 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 11'";
            SqlDataAdapter sqldap_table_11 = new SqlDataAdapter(color_table_11, sqlcon);
            DataSet dts_table_11 = new DataSet();
            sqldap_table_11.Fill(dts_table_11);
            DataTable dataTable_11 = dts_table_11.Tables[0];
            if (dataTable_11.Rows.Count > 0)
            {
                Bt_Table_11.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
        }
        private void Bt_Table_1_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = true;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = false;
            //
            Table_1_check = true;
            if (Table_1_check == true)
            {
                Table_2_check = false;
                Table_3_check = false;
                Table_4_check = false;
                Table_5_check = false;
                Table_6_check = false;
                Table_7_check = false;
                Table_8_check = false;
                Table_9_check = false;
                Table_10_check = false;
                Table_11_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 1' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void Bt_Table_2_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = true;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = false;
            //
            Table_2_check = true;
            if (Table_2_check == true)
            {
                Table_1_check = false;
                Table_3_check = false;
                Table_4_check = false;
                Table_5_check = false;
                Table_6_check = false;
                Table_7_check = false;
                Table_8_check = false;
                Table_9_check = false;
                Table_10_check = false;
                Table_11_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 2' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void BT_Table_3_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = true;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = false;
            //
            Table_3_check = true;
            if (Table_3_check == true)
            {
                Table_1_check = false;
                Table_2_check = false;
                Table_4_check = false;
                Table_5_check = false;
                Table_6_check = false;
                Table_7_check = false;
                Table_8_check = false;
                Table_9_check = false;
                Table_10_check = false;
                Table_11_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 3' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void Bt_Table_4_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = true;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = false;
            //
            Table_4_check = true;
            if (Table_4_check == true)
            {
                Table_1_check = false;
                Table_2_check = false;
                Table_3_check = false;
                Table_5_check = false;
                Table_6_check = false;
                Table_7_check = false;
                Table_8_check = false;
                Table_9_check = false;
                Table_10_check = false;
                Table_11_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 4' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void Bt_Table_5_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = true;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = false;
            //
            Table_5_check = true;
            if (Table_5_check == true)
            {
                Table_1_check = false;
                Table_2_check = false;
                Table_3_check = false;
                Table_4_check = false;
                Table_6_check = false;
                Table_7_check = false;
                Table_8_check = false;
                Table_9_check = false;
                Table_10_check = false;
                Table_11_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 5' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void BT_Table_6_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = true;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = false;
            //
            Table_6_check = true;
            if (Table_6_check == true)
            {
                Table_1_check = false;
                Table_2_check = false;
                Table_3_check = false;
                Table_4_check = false;
                Table_5_check = false;
                Table_7_check = false;
                Table_8_check = false;
                Table_9_check = false;
                Table_10_check = false;
                Table_11_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 6' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void Bt_Table_7_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = true;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = false;
            //
            Table_7_check = true;
            if (Table_7_check == true)
            {
                Table_1_check = false;
                Table_2_check = false;
                Table_3_check = false;
                Table_4_check = false;
                Table_5_check = false;
                Table_6_check = false;
                Table_8_check = false;
                Table_9_check = false;
                Table_10_check = false;
                Table_11_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 7' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void Bt_Table_8_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = true;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = false;
            //
            Table_8_check = true;
            if (Table_8_check == true)
            {
                Table_1_check = false;
                Table_2_check = false;
                Table_3_check = false;
                Table_4_check = false;
                Table_5_check = false;
                Table_6_check = false;
                Table_7_check = false;
                Table_9_check = false;
                Table_10_check = false;
                Table_11_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 8' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void Bt_Table_9_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = true;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = false;
            //
            Table_9_check = true;
            if (Table_9_check == true)
            {
                Table_1_check = false;
                Table_2_check = false;
                Table_3_check = false;
                Table_4_check = false;
                Table_5_check = false;
                Table_6_check = false;
                Table_7_check = false;
                Table_8_check = false;
                Table_10_check = false;
                Table_11_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 9' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void Bt_Table_10_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = true;
            table_11_borderLeft.Visible = false;
            //
            Table_10_check = true;
            if (Table_10_check == true)
            {
                Table_1_check = false;
                Table_2_check = false;
                Table_3_check = false;
                Table_4_check = false;
                Table_5_check = false;
                Table_6_check = false;
                Table_7_check = false;
                Table_8_check = false;
                Table_9_check = false;
                Table_11_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 10' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void Bt_Table_11_Click(object sender, EventArgs e)
        {
            table_1_borderLeft.Visible = false;
            table_2_borderLeft.Visible = false;
            table_3_borderLeft.Visible = false;
            table_4_borderLeft.Visible = false;
            table_5_borderLeft.Visible = false;
            table_6_borderLeft.Visible = false;
            table_7_borderLeft.Visible = false;
            table_8_borderLeft.Visible = false;
            table_9_borderLeft.Visible = false;
            table_10_borderLeft.Visible = false;
            table_11_borderLeft.Visible = true;
            //
            Table_11_check = true;
            if (Table_11_check == true)
            {
                Table_1_check = false;
                Table_2_check = false;
                Table_3_check = false;
                Table_4_check = false;
                Table_5_check = false;
                Table_6_check = false;
                Table_7_check = false;
                Table_8_check = false;
                Table_9_check = false;
                Table_10_check = false;
            }
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 11' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Order.DataSource = dataSet.Tables[0];
                Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void Bt_Add_Click(object sender, EventArgs e)
        {
            if (Table_1_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 1',N'" + txb_Name.Text + "','" + txb_Price.Text + "','1')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 1' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_1 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 1'";
                SqlDataAdapter sqldap_table_1 = new SqlDataAdapter(color_table_1, sqlcon);
                DataSet dts_table_1 = new DataSet();
                sqldap_table_1.Fill(dts_table_1);
                DataTable dataTable_1 = dts_table_1.Tables[0];
                if (dataTable_1.Rows.Count > 0)
                {
                    Bt_Table_1.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
            if (Table_2_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 2',N'" + txb_Name.Text + "','" + txb_Price.Text + "','2')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 2' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_2 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 2'";
                SqlDataAdapter sqldap_table_2 = new SqlDataAdapter(color_table_2, sqlcon);
                DataSet dts_table_2 = new DataSet();
                sqldap_table_2.Fill(dts_table_2);
                DataTable dataTable_2 = dts_table_2.Tables[0];
                if (dataTable_2.Rows.Count > 0)
                {
                    Bt_Table_2.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
            if (Table_3_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 3',N'" + txb_Name.Text + "','" + txb_Price.Text + "','3')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 3' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_3 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 3'";
                SqlDataAdapter sqldap_table_3 = new SqlDataAdapter(color_table_3, sqlcon);
                DataSet dts_table_3 = new DataSet();
                sqldap_table_3.Fill(dts_table_3);
                DataTable dataTable_3 = dts_table_3.Tables[0];
                if (dataTable_3.Rows.Count > 0)
                {
                    BT_Table_3.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
            if (Table_4_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 4',N'" + txb_Name.Text + "','" + txb_Price.Text + "','4')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 4' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_4 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 4'";
                SqlDataAdapter sqldap_table_4 = new SqlDataAdapter(color_table_4, sqlcon);
                DataSet dts_table_4 = new DataSet();
                sqldap_table_4.Fill(dts_table_4);
                DataTable dataTable_4 = dts_table_4.Tables[0];
                if (dataTable_4.Rows.Count > 0)
                {
                    Bt_Table_4.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
            if (Table_5_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 5',N'" + txb_Name.Text + "','" + txb_Price.Text + "','5')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 5' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_5 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 5'";
                SqlDataAdapter sqldap_table_5 = new SqlDataAdapter(color_table_5, sqlcon);
                DataSet dts_table_5 = new DataSet();
                sqldap_table_5.Fill(dts_table_5);
                DataTable dataTable_5 = dts_table_5.Tables[0];
                if (dataTable_5.Rows.Count > 0)
                {
                    Bt_Table_5.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
            if (Table_6_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 6',N'" + txb_Name.Text + "','" + txb_Price.Text + "','6')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 6' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_6 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 6'";
                SqlDataAdapter sqldap_table_6 = new SqlDataAdapter(color_table_6, sqlcon);
                DataSet dts_table_6 = new DataSet();
                sqldap_table_6.Fill(dts_table_6);
                DataTable dataTable_6 = dts_table_6.Tables[0];
                if (dataTable_6.Rows.Count > 0)
                {
                    BT_Table_6.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
            if (Table_7_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 7',N'" + txb_Name.Text + "','" + txb_Price.Text + "','7')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 7' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_7 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 7'";
                SqlDataAdapter sqldap_table_7 = new SqlDataAdapter(color_table_7, sqlcon);
                DataSet dts_table_7 = new DataSet();
                sqldap_table_7.Fill(dts_table_7);
                DataTable dataTable_7 = dts_table_7.Tables[0];
                if (dataTable_7.Rows.Count > 0)
                {
                    Bt_Table_7.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
            if (Table_8_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 8',N'" + txb_Name.Text + "','" + txb_Price.Text + "','8')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 8' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_8 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 8'";
                SqlDataAdapter sqldap_table_8 = new SqlDataAdapter(color_table_8, sqlcon);
                DataSet dts_table_8 = new DataSet();
                sqldap_table_8.Fill(dts_table_8);
                DataTable dataTable_8 = dts_table_8.Tables[0];
                if (dataTable_8.Rows.Count > 0)
                {
                    Bt_Table_8.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
            if (Table_9_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 9',N'" + txb_Name.Text + "','" + txb_Price.Text + "','9')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 9' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_9 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 9'";
                SqlDataAdapter sqldap_table_9 = new SqlDataAdapter(color_table_9, sqlcon);
                DataSet dts_table_9 = new DataSet();
                sqldap_table_9.Fill(dts_table_9);
                DataTable dataTable_9 = dts_table_9.Tables[0];
                if (dataTable_9.Rows.Count > 0)
                {
                    Bt_Table_9.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
            if (Table_10_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 10',N'" + txb_Name.Text + "','" + txb_Price.Text + "','10')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 10' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_10 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 10'";
                SqlDataAdapter sqldap_table_10 = new SqlDataAdapter(color_table_10, sqlcon);
                DataSet dts_table_10 = new DataSet();
                sqldap_table_10.Fill(dts_table_10);
                DataTable dataTable_10 = dts_table_10.Tables[0];
                if (dataTable_10.Rows.Count > 0)
                {
                    Bt_Table_10.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
            if (Table_11_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into OrderTable values (N'Bàn số 11',N'" + txb_Name.Text + "','" + txb_Price.Text + "','11')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 11' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_11 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 11'";
                SqlDataAdapter sqldap_table_11 = new SqlDataAdapter(color_table_11, sqlcon);
                DataSet dts_table_11 = new DataSet();
                sqldap_table_11.Fill(dts_table_11);
                DataTable dataTable_11 = dts_table_11.Tables[0];
                if (dataTable_11.Rows.Count > 0)
                {
                    Bt_Table_11.BackColor = Color.DeepSkyBlue;
                }
                sqlcon.Close();
            }
        }
        private void Dgv_ManyFoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Dgv_ManyFoods.CurrentRow.Index;
            txb_Name.Text = Dgv_ManyFoods.Rows[i].Cells[0].Value.ToString();
            txb_Price.Text = Dgv_ManyFoods.Rows[i].Cells[1].Value.ToString();
        }
        private void Dgv_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Dgv_Order.CurrentRow.Index;
            txb_Name.Text = Dgv_Order.Rows[i].Cells[0].Value.ToString();
            txb_Price.Text = Dgv_Order.Rows[i].Cells[1].Value.ToString();
        }
        private void Bt_Update_Click(object sender, EventArgs e)
        {

        }
        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            if (Table_1_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '1'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 1' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_1 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 1'";
                SqlDataAdapter sqldap_table_1 = new SqlDataAdapter(color_table_1, sqlcon);
                DataSet dts_table_1 = new DataSet();
                sqldap_table_1.Fill(dts_table_1);
                DataTable dataTable_1 = dts_table_1.Tables[0];
                if (dataTable_1.Rows.Count == 0)
                {
                    Bt_Table_1.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
            if (Table_2_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '2'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 2' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_2 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 2'";
                SqlDataAdapter sqldap_table_2 = new SqlDataAdapter(color_table_2, sqlcon);
                DataSet dts_table_2 = new DataSet();
                sqldap_table_2.Fill(dts_table_2);
                DataTable dataTable_2 = dts_table_2.Tables[0];
                if (dataTable_2.Rows.Count == 0)
                {
                    Bt_Table_2.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
            if (Table_3_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '3'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 3' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_3 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 3'";
                SqlDataAdapter sqldap_table_3 = new SqlDataAdapter(color_table_3, sqlcon);
                DataSet dts_table_3 = new DataSet();
                sqldap_table_3.Fill(dts_table_3);
                DataTable dataTable_3 = dts_table_3.Tables[0];
                if (dataTable_3.Rows.Count == 0)
                {
                    BT_Table_3.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
            if (Table_4_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '4'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 4' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_4 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 4'";
                SqlDataAdapter sqldap_table_4 = new SqlDataAdapter(color_table_4, sqlcon);
                DataSet dts_table_4 = new DataSet();
                sqldap_table_4.Fill(dts_table_4);
                DataTable dataTable_4 = dts_table_4.Tables[0];
                if (dataTable_4.Rows.Count == 0)
                {
                    Bt_Table_4.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
            if (Table_5_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '5'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 5' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_5 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 5'";
                SqlDataAdapter sqldap_table_5 = new SqlDataAdapter(color_table_5, sqlcon);
                DataSet dts_table_5 = new DataSet();
                sqldap_table_5.Fill(dts_table_5);
                DataTable dataTable_5 = dts_table_5.Tables[0];
                if (dataTable_5.Rows.Count == 0)
                {
                    Bt_Table_5.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
            if (Table_6_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '6'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 6' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_6 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 6'";
                SqlDataAdapter sqldap_table_6 = new SqlDataAdapter(color_table_6, sqlcon);
                DataSet dts_table_6 = new DataSet();
                sqldap_table_6.Fill(dts_table_6);
                DataTable dataTable_6 = dts_table_6.Tables[0];
                if (dataTable_6.Rows.Count == 0)
                {
                    BT_Table_6.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
            if (Table_7_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '7'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 7' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_7 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 7'";
                SqlDataAdapter sqldap_table_7 = new SqlDataAdapter(color_table_7, sqlcon);
                DataSet dts_table_7 = new DataSet();
                sqldap_table_7.Fill(dts_table_7);
                DataTable dataTable_7 = dts_table_7.Tables[0];
                if (dataTable_7.Rows.Count == 0)
                {
                    Bt_Table_7.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
            if (Table_8_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '8'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 8' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_8 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 8'";
                SqlDataAdapter sqldap_table_8 = new SqlDataAdapter(color_table_8, sqlcon);
                DataSet dts_table_8 = new DataSet();
                sqldap_table_8.Fill(dts_table_8);
                DataTable dataTable_8 = dts_table_8.Tables[0];
                if (dataTable_8.Rows.Count == 0)
                {
                    Bt_Table_8.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
            if (Table_9_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '9'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 9' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_9 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 9'";
                SqlDataAdapter sqldap_table_9 = new SqlDataAdapter(color_table_9, sqlcon);
                DataSet dts_table_9 = new DataSet();
                sqldap_table_9.Fill(dts_table_9);
                DataTable dataTable_9 = dts_table_9.Tables[0];
                if (dataTable_9.Rows.Count == 0)
                {
                    Bt_Table_9.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
            if (Table_10_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '10'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 10' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_10 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 10'";
                SqlDataAdapter sqldap_table_10 = new SqlDataAdapter(color_table_10, sqlcon);
                DataSet dts_table_10 = new DataSet();
                sqldap_table_10.Fill(dts_table_10);
                DataTable dataTable_10 = dts_table_10.Tables[0];
                if (dataTable_10.Rows.Count == 0)
                {
                    Bt_Table_10.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
            if (Table_11_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete OrderTable where NameFood_ = N'" + txb_Name.Text + "' and IDTable_ = '11'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 11' group by NameFood_";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Order.DataSource = dataSet.Tables[0];
                    Dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string color_table_11 = "select NameFood_ from OrderTable where Name_ = N'Bàn số 11'";
                SqlDataAdapter sqldap_table_11 = new SqlDataAdapter(color_table_11, sqlcon);
                DataSet dts_table_11 = new DataSet();
                sqldap_table_11.Fill(dts_table_11);
                DataTable dataTable_11 = dts_table_11.Tables[0];
                if (dataTable_11.Rows.Count == 0)
                {
                    Bt_Table_11.BackColor = Color.FromArgb(52, 52, 52);
                }
                sqlcon.Close();
            }
        }
        private void Bt_Search_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food where Name_ like N'" + txb_Search.Text + "%' or Price_ like '" + txb_Search.Text + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_ManyFoods.DataSource = dataSet.Tables[0];
                Dgv_ManyFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void Bt_Pay_Click(object sender, EventArgs e)
        {
            if (Table_1_check == true)
            {
                Bill_table_1 bill_Table_1 = new Bill_table_1();
                bill_Table_1.Show();
            }    

            if (Table_2_check == true)
            {
                Bill_table_2 bill_Table_2 = new Bill_table_2();
                bill_Table_2.Show();
            }
            if (Table_3_check == true)
            {
                Bill_table_3 bill_Table_3 = new Bill_table_3();
                bill_Table_3.Show();
            }
            if (Table_4_check == true)
            {
                Bill_table_4 bill_Table_4 = new Bill_table_4();
                bill_Table_4.Show();
            }
            if (Table_5_check == true)
            {
                Bill_table_5 bill_Table_5 = new Bill_table_5();
                bill_Table_5.Show();
            }
            if (Table_6_check == true)
            {
                Bill_table_6 bill_Table_6 = new Bill_table_6();
                bill_Table_6.Show();
            }
            if (Table_7_check == true)
            {
                Bill_table_7 bill_Table_7 = new Bill_table_7();
                bill_Table_7.Show();
            }
            if (Table_8_check == true)
            {
                Bill_table_8 bill_Table_8 = new Bill_table_8();
                bill_Table_8.Show();
            }
            if (Table_9_check == true)
            {
                Bill_table_9 bill_Table_9 = new Bill_table_9();
                bill_Table_9.Show();
            }
            if (Table_10_check == true)
            {
                Bill_table_10 bill_Table_10 = new Bill_table_10();
                bill_Table_10.Show();
            }
            if (Table_11_check == true)
            {
                Bill_table_11 bill_Table_11 = new Bill_table_11();
                bill_Table_11.Show();
            }
        }
    }
}
