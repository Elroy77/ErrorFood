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
    public partial class Form_Drink : Form
    {
        SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
        bool Coca_check = false;
        bool Pepsi_check = false;
        bool Peachtea_check = false;
        bool Milktea_check = false;
        bool Milk_check = false;
        bool Yogurt_check = false;
        bool Cafe_check = false;
        public Form_Drink()
        {
            InitializeComponent();
            coca_borderLeft.Visible = false;
            pepsi_borderLeft.Visible = false;
            Peachtea_borderLeft.Visible = false;
            Milktea_borderLeft.Visible = false;
            Milk_borderLeft.Visible = false;
            Yogurt_borderLeft.Visible = false;
            Cafe_borderLeft.Visible = false;
            this.Dgv_Drink.DefaultCellStyle.Font = new Font("Tahoma", 14);
            this.Dgv_Drink.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
            this.Dgv_Drink.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.Dgv_Drink.DefaultCellStyle.SelectionBackColor = Color.White;
            this.Dgv_Drink.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }
        private void Form_Drink_Load(object sender, EventArgs e)
        {
            
        }
        private void Bt_coca_Click(object sender, EventArgs e)
        {
            coca_borderLeft.Visible = true;
            pepsi_borderLeft.Visible = false;
            Peachtea_borderLeft.Visible = false;
            Milktea_borderLeft.Visible = false;
            Milk_borderLeft.Visible = false;
            Yogurt_borderLeft.Visible = false;
            Cafe_borderLeft.Visible = false;
            Coca_check = true;
            if (Coca_check == true)
            {
                Pepsi_check = false;
                Peachtea_check = false;
                Milktea_check = false;
                Milk_check = false;
                Yogurt_check = false;
                Cafe_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 8";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Drink.DataSource = dataSet.Tables[0];
                Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_pepsi_Click(object sender, EventArgs e)
        {
            coca_borderLeft.Visible = false;
            pepsi_borderLeft.Visible = true;
            Peachtea_borderLeft.Visible = false;
            Milktea_borderLeft.Visible = false;
            Milk_borderLeft.Visible = false;
            Yogurt_borderLeft.Visible = false;
            Cafe_borderLeft.Visible = false;
            Pepsi_check = true;
            if (Pepsi_check == true)
            {
                Coca_check = false;
                Peachtea_check = false;
                Milktea_check = false;
                Milk_check = false;
                Yogurt_check = false;
                Cafe_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 9";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Drink.DataSource = dataSet.Tables[0];
                Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void BT_tradao_Click(object sender, EventArgs e)
        {
            coca_borderLeft.Visible = false;
            pepsi_borderLeft.Visible = false;
            Peachtea_borderLeft.Visible = true;
            Milktea_borderLeft.Visible = false;
            Milk_borderLeft.Visible = false;
            Yogurt_borderLeft.Visible = false;
            Cafe_borderLeft.Visible = false;
            Peachtea_check = true;
            if (Peachtea_check == true)
            {
                Coca_check = false;
                Pepsi_check = false;
                Milktea_check = false;
                Milk_check = false;
                Yogurt_check = false;
                Cafe_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 10";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Drink.DataSource = dataSet.Tables[0];
                Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_trasua_Click(object sender, EventArgs e)
        {
            coca_borderLeft.Visible = false;
            pepsi_borderLeft.Visible = false;
            Peachtea_borderLeft.Visible = false;
            Milktea_borderLeft.Visible = true;
            Milk_borderLeft.Visible = false;
            Yogurt_borderLeft.Visible = false;
            Cafe_borderLeft.Visible = false;
            Milktea_check = true;
            if (Milktea_check == true)
            {
                Coca_check = false;
                Peachtea_check = false;
                Pepsi_check = false;
                Milk_check = false;
                Yogurt_check = false;
                Cafe_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 11";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Drink.DataSource = dataSet.Tables[0];
                Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void bt_suatuoi_Click(object sender, EventArgs e)
        {
            coca_borderLeft.Visible = false;
            pepsi_borderLeft.Visible = false;
            Peachtea_borderLeft.Visible = false;
            Milktea_borderLeft.Visible = false;
            Milk_borderLeft.Visible = true;
            Yogurt_borderLeft.Visible = false;
            Cafe_borderLeft.Visible = false;
            Milk_check = true;
            if (Milk_check == true)
            {
                Coca_check = false;
                Peachtea_check = false;
                Milktea_check = false;
                Pepsi_check = false;
                Yogurt_check = false;
                Cafe_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 12";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Drink.DataSource = dataSet.Tables[0];
                Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void bt_suachua_Click(object sender, EventArgs e)
        {
            coca_borderLeft.Visible = false;
            pepsi_borderLeft.Visible = false;
            Peachtea_borderLeft.Visible = false;
            Milktea_borderLeft.Visible = false;
            Milk_borderLeft.Visible = false;
            Yogurt_borderLeft.Visible = true;
            Cafe_borderLeft.Visible = false;
            Yogurt_check = true;
            if (Yogurt_check == true)
            {
                Coca_check = false;
                Peachtea_check = false;
                Milktea_check = false;
                Milk_check = false;
                Pepsi_check = false;
                Cafe_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 13";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Drink.DataSource = dataSet.Tables[0];
                Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_cafe_Click(object sender, EventArgs e)
        {
            coca_borderLeft.Visible = false;
            pepsi_borderLeft.Visible = false;
            Peachtea_borderLeft.Visible = false;
            Milktea_borderLeft.Visible = false;
            Milk_borderLeft.Visible = false;
            Yogurt_borderLeft.Visible = false;
            Cafe_borderLeft.Visible = true;
            Cafe_check = true;
            if (Cafe_check == true)
            {
                Coca_check = false;
                Peachtea_check = false;
                Milktea_check = false;
                Milk_check = false;
                Yogurt_check = false;
                Pepsi_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 14";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Drink.DataSource = dataSet.Tables[0];
                Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Add_Click(object sender, EventArgs e)
        {
            if (Coca_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','8','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 8";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Pepsi_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','9','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 9";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Peachtea_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','10','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 10";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Milktea_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','11','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 11";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Milk_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','12','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 12";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Yogurt_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','13','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 13";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Cafe_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','14','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 14";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }
        private void Dgv_Drink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Dgv_Drink.CurrentRow.Index;
            txb_Name.Text = Dgv_Drink.Rows[i].Cells[0].Value.ToString();
            txb_Price.Text = Dgv_Drink.Rows[i].Cells[1].Value.ToString();
        }
        private void Bt_Update_Click(object sender, EventArgs e)
        {
            if (Coca_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 8";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Pepsi_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 9";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Peachtea_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 10";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Milktea_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 11";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Milk_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 12";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Yogurt_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 13";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Cafe_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 14";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            if (Coca_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 8";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Pepsi_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 9";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Peachtea_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 10";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Milktea_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 11";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Milk_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 12";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Yogurt_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 13";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Cafe_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete drink \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                sqlcon.Open();
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 14";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Drink.DataSource = dataSet.Tables[0];
                    Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }

        private void Bt_Search_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food where Name_ like N'%" + txb_Search.Text + "%' or Price_ like '" + txb_Search.Text + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Drink.DataSource = dataSet.Tables[0];
                Dgv_Drink.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
    }
}
