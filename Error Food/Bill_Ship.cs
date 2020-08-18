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
    public partial class Form_Bill_Ship : Form
    {
        SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
        public Form_Bill_Ship()
        {
            InitializeComponent();
        }

        private void Form_Bill_Ship_Load(object sender, EventArgs e)
        {
            {
                this.dgv_Bill.DefaultCellStyle.Font = new Font("Tahoma", 9);
                this.dgv_Bill.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
                this.dgv_Bill.DefaultCellStyle.SelectionForeColor = Color.Red;
                this.dgv_Bill.DefaultCellStyle.SelectionBackColor = Color.White;
                this.dgv_Bill.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                //
                this.DgvSumBill.DefaultCellStyle.Font = new Font("Tahoma", 12);
                this.DgvSumBill.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
                this.DgvSumBill.DefaultCellStyle.SelectionForeColor = Color.Red;
                this.DgvSumBill.DefaultCellStyle.SelectionBackColor = Color.White;
                this.DgvSumBill.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                //
                this.Dgv_Info.DefaultCellStyle.Font = new Font("Tahoma", 9);
                this.Dgv_Info.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 7, FontStyle.Bold);
                this.Dgv_Info.DefaultCellStyle.SelectionForeColor = Color.Red;
                this.Dgv_Info.DefaultCellStyle.SelectionBackColor = Color.White;
                this.Dgv_Info.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                this.Location = new Point(1020, 150);
                SqlConnection getcon = new SqlConnection(ConnectionString.Connection);
                getcon.Open();
                String queryDisplayFood = "select Name_Food as N'Tên món ăn',count(Name_Food) as N'Số Lượng' , sum(Price_Food) as N'Tổng món' from Bill_Ship,ShipFood_customer where Bill_Ship.Phone_Ship_Customer = '" + txb_Phone.Text + "' group by Bill_Ship.Name_Food";
                SqlDataAdapter sqlDAPdisplayFood = new SqlDataAdapter(queryDisplayFood, getcon);
                DataSet dataSetFood = new DataSet();
                sqlDAPdisplayFood.Fill(dataSetFood);
                {
                    dgv_Bill.DataSource = dataSetFood.Tables[0];
                    dgv_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string Sum = "select Sum(Price_Food) as N'Tổng tiền' from Bill_Ship where Phone_Ship_Customer = '"+txb_Phone.Text+"'";
                SqlDataAdapter sqlDA = new SqlDataAdapter(Sum, sqlcon);
                DataSet DS = new DataSet();
                sqlDA.Fill(DS);
                {
                    DgvSumBill.DataSource = DS.Tables[0];
                    DgvSumBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
                //
                sqlcon.Open();
                string infor = "select Name_ as N'Tên khách hàng',Phone_ as N'Số điện thoại', Address_ as N'Địa chỉ' from ShipFood_customer where Phone_ = '" + txb_Phone.Text + "'";
                SqlDataAdapter sqlDAinfo = new SqlDataAdapter(infor, sqlcon);
                DataSet DSinfo = new DataSet();
                sqlDAinfo.Fill(DSinfo);
                {
                    Dgv_Info.DataSource = DSinfo.Tables[0];
                    Dgv_Info.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                sqlcon.Close();
            }
        }

        private void title_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string newcommand = "delete Bill_Ship where Phone_Ship_Customer = '"+txb_Phone.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
            sqlCommand.ExecuteNonQuery();
            sqlcon.Close();
            //
            sqlcon.Open();
            string newcommanddelete = "delete ShipFood_customer where Phone_ = '" + txb_Phone.Text + "'";
            SqlCommand sqlCommanddelete = new SqlCommand(newcommanddelete, sqlcon);
            sqlCommanddelete.ExecuteNonQuery();
            sqlcon.Close();
            Bill_table_1.ActiveForm.Hide();
        }
        public void funData(TextBox textBox)
        {
            txb_Phone.Text = textBox.Text;
        }
    }
}
