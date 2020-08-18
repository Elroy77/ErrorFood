using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Security;

namespace Error_Food
{
    public partial class Form_Food : Form
    {
        SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
        bool Noodles_check = false;
        bool Soup_check = false;
        bool Seafood_check = false;
        bool Hotpot_check = false;
        bool Barbecua_check = false;
        bool Fastfood_check = false;
        bool Extrafood_check = false;
        public Form_Food()
        {
            InitializeComponent();
            Noodles_borderLeft.Visible = false;
            Soup_borderLeft.Visible = false;
            Seafood_borderLeft.Visible = false;
            Hotpot_borderLeft.Visible = false;
            Barbecua_borderLeft.Visible = false;
            Fastfood_borderLeft.Visible = false;
            Extrafood_borderLeft.Visible = false;
            this.Dgv_Food.DefaultCellStyle.Font = new Font("Tahoma", 14);
            this.Dgv_Food.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
            this.Dgv_Food.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.Dgv_Food.DefaultCellStyle.SelectionBackColor = Color.White;
            this.Dgv_Food.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }

        private void Bt_Noodles_Click(object sender, EventArgs e)
        {
            Noodles_borderLeft.Visible = true;
            Soup_borderLeft.Visible = false;
            Seafood_borderLeft.Visible = false;
            Hotpot_borderLeft.Visible = false;
            Barbecua_borderLeft.Visible = false;
            Fastfood_borderLeft.Visible = false;
            Extrafood_borderLeft.Visible = false;
            Noodles_check = true;
            if (Noodles_check == true)
            {
                Soup_check = false;
                Seafood_check = false;
                Hotpot_check = false;
                Barbecua_check = false;
                Fastfood_check = false;
                Extrafood_check = false;
            }    
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Food.DataSource = dataSet.Tables[0];
                Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Soup_Click(object sender, EventArgs e)
        {
            Noodles_borderLeft.Visible = false;
            Soup_borderLeft.Visible = true;
            Seafood_borderLeft.Visible = false;
            Hotpot_borderLeft.Visible = false;
            Barbecua_borderLeft.Visible = false;
            Fastfood_borderLeft.Visible = false;
            Extrafood_borderLeft.Visible = false;
            Soup_check = true;
            if (Soup_check == true)
            {
                Noodles_check = false;
                Seafood_check = false;
                Hotpot_check = false;
                Barbecua_check = false;
                Fastfood_check = false;
                Extrafood_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 2";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Food.DataSource = dataSet.Tables[0];
                Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void BT_Seafood_Click(object sender, EventArgs e)
        {
            Noodles_borderLeft.Visible = false;
            Soup_borderLeft.Visible = false;
            Seafood_borderLeft.Visible = true;
            Hotpot_borderLeft.Visible = false;
            Barbecua_borderLeft.Visible = false;
            Fastfood_borderLeft.Visible = false;
            Extrafood_borderLeft.Visible = false;
            Seafood_check = true;
            if (Seafood_check == true)
            {
                Soup_check = false;
                Noodles_check = false;
                Hotpot_check = false;
                Barbecua_check = false;
                Fastfood_check = false;
                Extrafood_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 3";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Food.DataSource = dataSet.Tables[0];
                Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Hot_Pot_Click(object sender, EventArgs e)
        {
            Noodles_borderLeft.Visible = false;
            Soup_borderLeft.Visible = false;
            Seafood_borderLeft.Visible = false;
            Hotpot_borderLeft.Visible = true;
            Barbecua_borderLeft.Visible = false;
            Fastfood_borderLeft.Visible = false;
            Extrafood_borderLeft.Visible = false;
            Hotpot_check = true;
            if (Hotpot_check == true)
            {
                Soup_check = false;
                Seafood_check = false;
                Noodles_check = false;
                Barbecua_check = false;
                Fastfood_check = false;
                Extrafood_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 4";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Food.DataSource = dataSet.Tables[0];
                Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void bt_Barbecue_Click(object sender, EventArgs e)
        {
            Noodles_borderLeft.Visible = false;
            Soup_borderLeft.Visible = false;
            Seafood_borderLeft.Visible = false;
            Hotpot_borderLeft.Visible = false;
            Barbecua_borderLeft.Visible = true;
            Fastfood_borderLeft.Visible = false;
            Extrafood_borderLeft.Visible = false;
            Barbecua_check = true;
            if (Barbecua_check == true)
            {
                Soup_check = false;
                Seafood_check = false;
                Hotpot_check = false;
                Noodles_check = false;
                Fastfood_check = false;
                Extrafood_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 5";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Food.DataSource = dataSet.Tables[0];
                Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        private void bt_FastFood_Click(object sender, EventArgs e)
        {
            Noodles_borderLeft.Visible = false;
            Soup_borderLeft.Visible = false;
            Seafood_borderLeft.Visible = false;
            Hotpot_borderLeft.Visible = false;
            Barbecua_borderLeft.Visible = false;
            Fastfood_borderLeft.Visible = true;
            Extrafood_borderLeft.Visible = false;
            Fastfood_check = true;
            if (Fastfood_check == true)
            {
                Soup_check = false;
                Seafood_check = false;
                Hotpot_check = false;
                Barbecua_check = false;
                Noodles_check = false;
                Extrafood_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 6";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
            Dgv_Food.DataSource = dataSet.Tables[0];
            Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Extrafood_Click(object sender, EventArgs e)
        {
            Noodles_borderLeft.Visible = false;
            Soup_borderLeft.Visible = false;
            Seafood_borderLeft.Visible = false;
            Hotpot_borderLeft.Visible = false;
            Barbecua_borderLeft.Visible = false;
            Fastfood_borderLeft.Visible = false;
            Extrafood_borderLeft.Visible = true;
            Extrafood_check = true;
            if (Extrafood_check == true)
            {
                Soup_check = false;
                Seafood_check = false;
                Hotpot_check = false;
                Barbecua_check = false;
                Fastfood_check = false;
                Noodles_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 7";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Food.DataSource = dataSet.Tables[0];
                Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Add_Click(object sender, EventArgs e)
        {
            if (Noodles_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','1','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 1";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Soup_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','2','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 2";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }

            if (Seafood_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','3','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 3";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Hotpot_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','4','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 4";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Barbecua_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','5','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 5";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Fastfood_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','6','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 6";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Extrafood_check == true)
            {
                sqlcon.Open();
                string newcommand = "insert into Food values (N'" + txb_Name.Text + "','7','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 7";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }
        private void Dgv_Food_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Dgv_Food.CurrentRow.Index;
            txb_Name.Text = Dgv_Food.Rows[i].Cells[0].Value.ToString();
            txb_Price.Text = Dgv_Food.Rows[i].Cells[1].Value.ToString();
        }
        private void Bt_Update_Click(object sender, EventArgs e)
        {
            if (Noodles_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 1";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Soup_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 2";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Seafood_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 3";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Hotpot_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 4";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Barbecua_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 5";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Fastfood_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 6";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Extrafood_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 7";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            if (Noodles_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 1";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Soup_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 2";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Seafood_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 3";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Hotpot_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 4";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Barbecua_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 5";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Fastfood_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 6";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Extrafood_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 7";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Food.DataSource = dataSet.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                Dgv_Food.DataSource = dataSet.Tables[0];
                Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
    }

}
