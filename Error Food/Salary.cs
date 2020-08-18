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
    public partial class Form_Salary : Form
    {
        SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
        public Form_Salary()
        {
            InitializeComponent();
        }

        private void Form_Salary_Load(object sender, EventArgs e)
        {
            this.Location = new Point(990, 150);
            this.dgv_detail.DefaultCellStyle.Font = new Font("Tahoma", 14);
            this.dgv_detail.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 16, FontStyle.Bold);
            this.dgv_detail.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.dgv_detail.DefaultCellStyle.SelectionBackColor = Color.White;
            this.dgv_detail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            //
            this.dgvNameEmployee.DefaultCellStyle.Font = new Font("Tahoma", 16);
            this.dgvNameEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 1, FontStyle.Bold);
            this.dgvNameEmployee.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.dgvNameEmployee.DefaultCellStyle.SelectionBackColor = Color.White;
            this.dgvNameEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            Lb_Month.Text = DateTime.Today.ToString("MM");
            Lb_year.Text = DateTime.Today.ToString("- yyyy");
            //
            sqlcon.Open();
            String queryDisplayinfor = "select  DISTINCT Salary.Phone_ as N'Số điện thoại',count(Salary.working_day) as N'Số ngày làm' from Salary where Salary.Phone_ = '"+txb_Phone.Text+"' group by (Salary.Phone_)  ";
            SqlDataAdapter sqlDAPdisplayinfor = new SqlDataAdapter(queryDisplayinfor, sqlcon);
            DataSet dataSetinfor = new DataSet();
            sqlDAPdisplayinfor.Fill(dataSetinfor);
            {
                dgv_detail.DataSource = dataSetinfor.Tables[0];
                dgv_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
            //
            sqlcon.Open();
            String queryDisplayinforNameEmployee = "select  DISTINCT Employee.Name_ as N'Tên nhân viên'from Employee where Phone_ = '"+txb_Phone.Text+"'";
            SqlDataAdapter sqlDAPdisplayinforNameEmployee = new SqlDataAdapter(queryDisplayinforNameEmployee, sqlcon);
            DataSet dataSetinforNameEmployee = new DataSet();
            sqlDAPdisplayinforNameEmployee.Fill(dataSetinforNameEmployee);
            {
                dgvNameEmployee.DataSource = dataSetinforNameEmployee.Tables[0];
                dgvNameEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            sqlcon.Close();
        }
        public void funData(TextBox textBox)
        {
            txb_Phone.Text = textBox.Text;
        }

        private void Bt_Exit_Click(object sender, EventArgs e)
        {
            SqlConnection conDelete = new SqlConnection(ConnectionString.Connection);
            conDelete.Open();
            string newcommandDelete = "delete Salary where Phone_ = N'" + txb_Phone.Text + "'";
            SqlCommand sqlCommandDelete = new SqlCommand(newcommandDelete, conDelete);
            sqlCommandDelete.ExecuteNonQuery();
            conDelete.Close();
            this.Close();
        }
    }
}
