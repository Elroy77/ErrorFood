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

namespace Error_Food
{
    public partial class Form_Ship : Form
    {
        SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
        public Form_Ship()
        {
            InitializeComponent();
            this.DgvNameSC.DefaultCellStyle.Font = new Font("Tahoma", 14);
            this.DgvNameSC.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
            this.DgvNameSC.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.DgvNameSC.DefaultCellStyle.SelectionBackColor = Color.White;
            this.DgvNameSC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            //
            this.Dgv_ManyFoods.DefaultCellStyle.Font = new Font("Tahoma", 14);
            this.Dgv_ManyFoods.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
            this.Dgv_ManyFoods.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.Dgv_ManyFoods.DefaultCellStyle.SelectionBackColor = Color.White;
            this.Dgv_ManyFoods.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            //
            this.Dgv_Food.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.Dgv_Food.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
            this.Dgv_Food.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.Dgv_Food.DefaultCellStyle.SelectionBackColor = Color.White;
            this.Dgv_Food.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }

        private void Form_Ship_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            String newcommand = "select Name_ as N'Tên khách hàng' from ShipFood_customer";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            DgvNameSC.DataSource = dataSet.Tables[0];
            DgvNameSC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //
            SqlConnection conFood = new SqlConnection(ConnectionString.Connection);
            conFood.Open();
            String displayFood = "select Name_ as N'Tên Món Ăn',Price_ as N'Giá' from Food";
            SqlDataAdapter sqldisplayFood = new SqlDataAdapter(displayFood, conFood);
            DataSet dts = new DataSet();
            sqldisplayFood.Fill(dts);
            Dgv_ManyFoods.DataSource = dts.Tables[0];
            Dgv_ManyFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DgvNameSC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DgvNameSC.CurrentRow.Index;
            txb_Name.Text = DgvNameSC.Rows[i].Cells[0].Value.ToString();
            if (txb_Name.Text == null)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(ConnectionString.Connection);
                con.Open();
                String newcommand = "select * from ShipFood_customer where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    txb_Phone.Text = sqlDataReader.GetValue(1).ToString();
                    txb_Address.Text = sqlDataReader.GetValue(2).ToString();
                }
                sqlcon.Close();
            }
            if (txb_Name_Food.Text == null || txb_Price.Text == null)
            {

            }
            else
            {
                SqlConnection getcon = new SqlConnection(ConnectionString.Connection);
                getcon.Open();
                String queryDisplayFood = "select Name_Food as N'Tên món ăn',count(Name_Food) as N'Số Lượng', sum(Price_Food) as N'Tổng giá' from Bill_Ship where Phone_Ship_Customer = '" + txb_Phone.Text + "' group by Name_Food";
                SqlDataAdapter sqlDAPdisplayFood = new SqlDataAdapter(queryDisplayFood, getcon);
                DataSet dataSetFood = new DataSet();
                sqlDAPdisplayFood.Fill(dataSetFood);
                {
                    Dgv_Food.DataSource = dataSetFood.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }

        private void Bt_Add_Click(object sender, EventArgs e)
        {
            SqlConnection conaddcustomer = new SqlConnection(ConnectionString.Connection);
            conaddcustomer.Open();
            String queryaddcustomer = "insert into ShipFood_customer values (N'"+txb_Name.Text+"','"+txb_Phone.Text+"',N'"+txb_Address.Text+"')";
            SqlCommand sqlCommand = new SqlCommand(queryaddcustomer, sqlcon);
            sqlCommand.ExecuteNonQuery();
            sqlcon.Close();
            txb_Name.Text = null;
            txb_Phone.Text = null;
            txb_Address.Text = null;
            txb_Name_Food.Text = null;
            txb_Price.Text = null;
            sqlcon.Open();
            String newcommand = "select Name_ as N'Tên khách hàng' from ShipFood_customer";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            DgvNameSC.DataSource = dataSet.Tables[0];
            DgvNameSC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            SqlConnection conUpdate = new SqlConnection(ConnectionString.Connection);
            conUpdate.Open();
            string newcommandUpdate = "update ShipFood_customer set Address_ = N'" + txb_Address.Text + "' where Name_ = N'" + txb_Name.Text + "'";
            SqlCommand sqlCommandUpdate = new SqlCommand(newcommandUpdate, conUpdate);
            sqlCommandUpdate.ExecuteNonQuery();
            MessageBox.Show("Update success");
            sqlcon.Close();
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conDelete = new SqlConnection(ConnectionString.Connection);
            conDelete.Open();
            string newcommandDelete = "delete Bill_Ship where Name_Food = N'" + txb_Name_Food.Text + "' and Phone_Ship_Customer = '"+txb_Phone.Text+"'";
            SqlCommand sqlCommandDelete = new SqlCommand(newcommandDelete, conDelete);
            sqlCommandDelete.ExecuteNonQuery();
            if (txb_Name_Food.Text == null || txb_Price.Text == null)
            {

            }
            else
            {
                SqlConnection getcon = new SqlConnection(ConnectionString.Connection);
                getcon.Open();
                String queryDisplayFood = "select Name_Food as N'Tên món ăn',count(Name_Food) as N'Số Lượng', sum(Price_Food) as N'Tổng giá' from Bill_Ship where Phone_Ship_Customer = '" + txb_Phone.Text + "' group by Name_Food";
                SqlDataAdapter sqlDAPdisplayFood = new SqlDataAdapter(queryDisplayFood, getcon);
                DataSet dataSetFood = new DataSet();
                sqlDAPdisplayFood.Fill(dataSetFood);
                {
                    Dgv_Food.DataSource = dataSetFood.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }
        public delegate void delPassData(TextBox text);
        private void Bt_Bill_Click(object sender, EventArgs e)
        {
            Form_Bill_Ship form_Bill_Ship = new Form_Bill_Ship();
            delPassData del = new delPassData(form_Bill_Ship.funData);
            del(this.txb_Phone);
            form_Bill_Ship.Show();
        }

        private void Dgv_ManyFoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Dgv_ManyFoods.CurrentRow.Index;
            txb_Name_Food.Text = Dgv_ManyFoods.Rows[i].Cells[0].Value.ToString();
            txb_Price.Text = Dgv_ManyFoods.Rows[i].Cells[1].Value.ToString();
            if (txb_Name_Food.Text == null || txb_Price.Text == null)
            {

            }
            else
            {
                
                SqlConnection conaddFood = new SqlConnection(ConnectionString.Connection);
                conaddFood.Open();
                string queryaddFood = "insert into Bill_Ship values ('"+txb_Phone.Text+"',N'"+txb_Name_Food.Text+"','"+txb_Price.Text+"')";
                SqlCommand sqlcmdAddFood = new SqlCommand(queryaddFood, conaddFood);
                sqlcmdAddFood.ExecuteNonQuery();
                sqlcon.Close();
            }
            if (txb_Name_Food.Text == null || txb_Price.Text == null)
            {

            }
            else
            {
                SqlConnection getcon = new SqlConnection(ConnectionString.Connection);
                getcon.Open();
                String queryDisplayFood = "select Name_Food as N'Tên món ăn',count(Name_Food) as N'Số Lượng', sum(Price_Food) as N'Tổng giá' from Bill_Ship where Phone_Ship_Customer = '" + txb_Phone.Text + "' group by Name_Food";
                SqlDataAdapter sqlDAPdisplayFood = new SqlDataAdapter(queryDisplayFood, getcon);
                DataSet dataSetFood = new DataSet();
                sqlDAPdisplayFood.Fill(dataSetFood);
                {
                    Dgv_Food.DataSource = dataSetFood.Tables[0];
                    Dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }

        private void Dgv_Food_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Dgv_Food.CurrentRow.Index;
            txb_Name_Food.Text = Dgv_Food.Rows[i].Cells[0].Value.ToString();
            txb_Price.Text = Dgv_Food.Rows[i].Cells[1].Value.ToString();
        }
    }
}
