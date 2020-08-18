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
    public partial class Form_Combo : Form
    {
        SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
        bool Combo_1_check = false;
        bool Combo_2_check = false;
        bool Combo_3_check = false;
        bool Combo_4_check = false;
        bool Combo_5_check = false;
        bool Combo_6_check = false;
        bool Combo_7_check = false;

        public Form_Combo()
        {
            InitializeComponent();
            Cb1_borderLeft.Visible = false;
            Cb2_borderLeft.Visible = false;
            Cb3_borderLeft.Visible = false;
            Cb4_borderLeft.Visible = false;
            Cb5_borderLeft.Visible = false;
            Cb6_borderLeft.Visible = false;
            Cb7_borderLeft.Visible = false;
            this.Dgv_Combo.DefaultCellStyle.Font = new Font("Tahoma", 14);
            this.Dgv_Combo.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
            this.Dgv_Combo.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.Dgv_Combo.DefaultCellStyle.SelectionBackColor = Color.White;
            this.Dgv_Combo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }

        private void Bt_Combo_1_Click(object sender, EventArgs e)
        {
            Cb1_borderLeft.Visible = true;
            Cb2_borderLeft.Visible = false;
            Cb3_borderLeft.Visible = false;
            Cb4_borderLeft.Visible = false;
            Cb5_borderLeft.Visible = false;
            Cb6_borderLeft.Visible = false;
            Cb7_borderLeft.Visible = false;
            Combo_1_check = true;
            if (Combo_1_check == true)
            {
                Combo_2_check = false;
                Combo_3_check = false;
                Combo_4_check = false;
                Combo_5_check = false;
                Combo_6_check = false;
                Combo_7_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 15";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Combo.DataSource = dataSet.Tables[0];
                Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Combo_2_Click(object sender, EventArgs e)
        {
            Cb1_borderLeft.Visible = false;
            Cb2_borderLeft.Visible = true;
            Cb3_borderLeft.Visible = false;
            Cb4_borderLeft.Visible = false;
            Cb5_borderLeft.Visible = false;
            Cb6_borderLeft.Visible = false;
            Cb7_borderLeft.Visible = false;
            Combo_2_check = true;
            if (Combo_2_check == true)
            {
                Combo_1_check = false;
                Combo_3_check = false;
                Combo_4_check = false;
                Combo_5_check = false;
                Combo_6_check = false;
                Combo_7_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 16";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Combo.DataSource = dataSet.Tables[0];
                Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Combo_3_Click(object sender, EventArgs e)
        {
            Cb1_borderLeft.Visible = false;
            Cb2_borderLeft.Visible = false;
            Cb3_borderLeft.Visible = true;
            Cb4_borderLeft.Visible = false;
            Cb5_borderLeft.Visible = false;
            Cb6_borderLeft.Visible = false;
            Cb7_borderLeft.Visible = false;
            Combo_3_check = true;
            if (Combo_3_check == true)
            {
                Combo_1_check = false;
                Combo_2_check = false;
                Combo_4_check = false;
                Combo_5_check = false;
                Combo_6_check = false;
                Combo_7_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 17";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Combo.DataSource = dataSet.Tables[0];
                Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Combo_4_Click(object sender, EventArgs e)
        {
            Cb1_borderLeft.Visible = false;
            Cb2_borderLeft.Visible = false;
            Cb3_borderLeft.Visible = false;
            Cb4_borderLeft.Visible = true;
            Cb5_borderLeft.Visible = false;
            Cb6_borderLeft.Visible = false;
            Cb7_borderLeft.Visible = false;
            Combo_4_check = true;
            if (Combo_4_check == true)
            {
                Combo_1_check = false;
                Combo_2_check = false;
                Combo_3_check = false;
                Combo_5_check = false;
                Combo_6_check = false;
                Combo_7_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 18";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Combo.DataSource = dataSet.Tables[0];
                Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Combo_5_Click(object sender, EventArgs e)
        {
            Cb1_borderLeft.Visible = false;
            Cb2_borderLeft.Visible = false;
            Cb3_borderLeft.Visible = false;
            Cb4_borderLeft.Visible = false;
            Cb5_borderLeft.Visible = true;
            Cb6_borderLeft.Visible = false;
            Cb7_borderLeft.Visible = false;
            Combo_5_check = true;
            if (Combo_5_check == true)
            {
                Combo_1_check = false;
                Combo_2_check = false;
                Combo_3_check = false;
                Combo_4_check = false;
                Combo_6_check = false;
                Combo_7_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 19";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Combo.DataSource = dataSet.Tables[0];
                Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Combo_6_Click(object sender, EventArgs e)
        {
            Cb1_borderLeft.Visible = false;
            Cb2_borderLeft.Visible = false;
            Cb3_borderLeft.Visible = false;
            Cb4_borderLeft.Visible = false;
            Cb5_borderLeft.Visible = false;
            Cb6_borderLeft.Visible = true;
            Cb7_borderLeft.Visible = false;
            Combo_6_check = true;
            if (Combo_6_check == true)
            {
                Combo_1_check = false;
                Combo_2_check = false;
                Combo_3_check = false;
                Combo_4_check = false;
                Combo_5_check = false;
                Combo_7_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 20";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Combo.DataSource = dataSet.Tables[0];
                Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Combo_7_Click(object sender, EventArgs e)
        {
            Cb1_borderLeft.Visible = false;
            Cb2_borderLeft.Visible = false;
            Cb3_borderLeft.Visible = false;
            Cb4_borderLeft.Visible = false;
            Cb5_borderLeft.Visible = false;
            Cb6_borderLeft.Visible = false;
            Cb7_borderLeft.Visible = true;
            Combo_7_check = true;
            if (Combo_7_check == true)
            {
                Combo_1_check = false;
                Combo_2_check = false;
                Combo_3_check = false;
                Combo_4_check = false;
                Combo_5_check = false;
                Combo_6_check = false;
            }
            sqlcon.Open();
            string newcommand = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 21";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                Dgv_Combo.DataSource = dataSet.Tables[0];
                Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Bt_Add_Click(object sender, EventArgs e)
        {
            if (Combo_1_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','15','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 15";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_2_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','16','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 16";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_3_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','17','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 17";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_4_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','18','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 18";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_5_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','19','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 19";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_6_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','20','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 20";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_7_check == true)
            {
                sqlcon.Open();
                String newcommand = "insert into Food values (N'" + txb_Name.Text + "','21','" + txb_Price.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Add food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 21";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            if (Combo_1_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 15";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_2_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 16";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_3_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 17";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_4_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 18";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_5_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 19";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_6_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 20";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_7_check == true)
            {
                sqlcon.Open();
                string newcommand = "update Food set Price_ = '" + txb_Price.Text + "' where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Update food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 21";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            if (Combo_1_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 15";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_2_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 16";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_3_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 17";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_4_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 18";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_5_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 19";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_6_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 20";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
            if (Combo_7_check == true)
            {
                sqlcon.Open();
                string newcommand = "delete Food where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show(txb_Name.Text + " with " + txb_Price.Text + " VNĐ", "      Delete food \n");
                txb_Name.Text = null;
                txb_Price.Text = null;
                string cmd = "select Food.Name_ as N'Tên món ăn',Food.Price_ as N'Giá' from Food,FoodCategory where Food.IDCategory_ = FoodCategory.ID_ and FoodCategory.ID_ = 21";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                {
                    Dgv_Combo.DataSource = dataSet.Tables[0];
                    Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                Dgv_Combo.DataSource = dataSet.Tables[0];
                Dgv_Combo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }

        private void Dgv_Combo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Dgv_Combo.CurrentRow.Index;
            txb_Name.Text = Dgv_Combo.Rows[i].Cells[0].Value.ToString();
            txb_Price.Text = Dgv_Combo.Rows[i].Cells[1].Value.ToString();
        }
    }
}
