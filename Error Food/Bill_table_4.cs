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
    public partial class Bill_table_4 : Form
    {
        SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
        public Bill_table_4()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string newcommand = "delete OrderTable where IDTable_ = '4'";
            SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
            sqlCommand.ExecuteNonQuery();
            sqlcon.Close();
            Bill_table_1.ActiveForm.Hide();
        }

        private void Bill_table_4_Load(object sender, EventArgs e)
        {
            this.dgv_Bill.DefaultCellStyle.Font = new Font("Tahoma", 10);
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
            this.Location = new Point(1020, 150);
            sqlcon.Open();
            string newcommand = "select NameFood_ as N'Tên món ăn', Count(NameFood_) as N'Số lượng', Sum(PriceFood_) as N'Tổng tiền món' from OrderTable where Name_ = N'Bàn số 4' group by NameFood_";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand, sqlcon);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            {
                dgv_Bill.DataSource = dataSet.Tables[0];
                dgv_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            string Sum = "select Sum(PriceFood_) as N'Tổng tiền' from OrderTable,TableuCount where OrderTable.IDTable_ = TableuCount.ID_ and TableuCount.ID_ = '4'";
            SqlDataAdapter sqlDA = new SqlDataAdapter(Sum, sqlcon);
            DataSet DS = new DataSet();
            sqlDA.Fill(DS);
            {
                DgvSumBill.DataSource = DS.Tables[0];
                DgvSumBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
    }
}
