using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Error_Food
{
    public partial class Form_Manager : Form
    {
        SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
        public Form_Manager()
        {
            InitializeComponent();
        }

        private void Form_Manager_Load(object sender, EventArgs e)
        {
            Choose_Picture.Enabled = false;
            txb_Name.Enabled = false;
            txb_Gender.Enabled = false;
            txb_Birthday.Enabled = false;
            txb_Phone.Enabled = false;
            txb_Address.Enabled = false;
            txb_Startday.Enabled = false;
            txb_Status.Enabled = false;
            Lb_Month.Text = DateTime.Today.ToString("MM");
            Lb_year.Text = DateTime.Today.ToString("- yyyy");
            //
            this.DgvNameEmployee.DefaultCellStyle.Font = new Font("Tahoma", 14);
            this.DgvNameEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15, FontStyle.Bold);
            this.DgvNameEmployee.DefaultCellStyle.SelectionForeColor = Color.Red;
            this.DgvNameEmployee.DefaultCellStyle.SelectionBackColor = Color.White;
            this.DgvNameEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            //
            //Cbb_Position.BackColor = Color.White;
            if (Lb_Month.Text == "01" || Lb_Month.Text == "03" || Lb_Month.Text == "05" ||
                Lb_Month.Text == "07" || Lb_Month.Text == "08" || Lb_Month.Text == "10" || Lb_Month.Text == "12")
            {
                Btn_Day31.Enabled = true;
                Btn_Day31.Visible = true;
            }
            if (Lb_Month.Text == "02" || Lb_Month.Text == "04" || Lb_Month.Text == "06" ||
                Lb_Month.Text == "09" || Lb_Month.Text == "11")
            {
                Btn_Day31.Enabled = false;
                Btn_Day31.Visible = false;
            }
        }

        private void Bt_Disable_Click(object sender, EventArgs e)
        {
            Bt_Enable.Visible = true;
            Bt_Disable.Visible = false;
            Choose_Picture.Enabled = false;
            txb_Name.Enabled = false;
            txb_Gender.Enabled = false;
            txb_Birthday.Enabled = false;
            txb_Phone.Enabled = false;
            txb_Address.Enabled = false;
            txb_Startday.Enabled = false;
            txb_Status.Enabled = false;
        }

        private void Bt_Enable_Click(object sender, EventArgs e)
        {
            Bt_Disable.Visible = true;
            Bt_Enable.Visible = false;
            Choose_Picture.Enabled = true;
            txb_Name.Enabled = true;
            txb_Gender.Enabled = true;
            txb_Birthday.Enabled = true;
            txb_Phone.Enabled = true;
            txb_Address.Enabled = true;
            txb_Startday.Enabled = true;
            txb_Status.Enabled = true;
        }

        [Obsolete]
        private void Bt_Add_Click(object sender, EventArgs e)
        {
            if ( txb_Name.Text == null || txb_Gender.Text == null || txb_Birthday.Text == null ||
                txb_Phone.Text == null || txb_Address.Text == null || txb_Startday.Text == null ||
                txb_Status.Text == null || Choose_Picture.Image == null)
            {
                MessageBox.Show("Enter full infomation", "notification");
            }    
            else
            {
                byte[] b = ImageToByteArray(Choose_Picture.Image);
                sqlcon.Open();
                string newcommand = "insert into Employee values (@Name_ , @Gender_ , @Birthday_ , @Phone_ , @Address_ , @Startday_ , @Status_ , @Position_ , @Image_)";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.Parameters.Add("@Name_", txb_Name.Text);
                sqlCommand.Parameters.Add("@Gender_", txb_Gender.Text);
                sqlCommand.Parameters.Add("@Birthday_", txb_Birthday.Text);
                sqlCommand.Parameters.Add("@Phone_", txb_Phone.Text);
                sqlCommand.Parameters.Add("@Address_", txb_Address.Text);
                sqlCommand.Parameters.Add("@Startday_", txb_Startday.Text);
                sqlCommand.Parameters.Add("@Status_", txb_Status.Text);
                sqlCommand.Parameters.Add("@Position_", Cbb_Position.Text);
                sqlCommand.Parameters.Add("@Image_", b);
                sqlCommand.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Add employee success", "notification");
                txb_Name.Text = null;
                txb_Gender.Text = null;
                txb_Birthday.Text = null;
                txb_Phone.Text = null;
                txb_Address.Text = null;
                txb_Startday.Text = null;
                txb_Status.Text = null;
                Cbb_Position.Text = null;
                Choose_Picture.Image = Properties.Resources.NoImage;
            }    
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.ToArray();
        }

        private void Bt_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conDelete = new SqlConnection(ConnectionString.Connection);
            conDelete.Open();
            string newcommandDelete = "delete Employee where Name_ = N'" + txb_Name.Text + "' and Phone_ = '" + txb_Phone.Text + "'";
            SqlCommand sqlCommandDelete = new SqlCommand(newcommandDelete, conDelete);
            sqlCommandDelete.ExecuteNonQuery();
            conDelete.Close();
            MessageBox.Show("Đelete success");

        }

        private void Choose_Picture_Click(object sender, EventArgs e)
        {
            openFileImage.ShowDialog();
            string fileImage = openFileImage.FileName;
            if (string.IsNullOrEmpty(fileImage))
                return;
            Image employeeImage = Image.FromFile(fileImage);
            Choose_Picture.Image = employeeImage;
        }

        private void DgvNameEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DgvNameEmployee.CurrentRow.Index;
            txb_Name.Text = DgvNameEmployee.Rows[i].Cells[0].Value.ToString();
            if (txb_Name.Text == null)
            {

            }
            else
            {
                SqlConnection con = new SqlConnection(ConnectionString.Connection);
                con.Open();
                String newcommand = "select * from Employee where Name_ = N'" + txb_Name.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, con);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    txb_Gender.Text = sqlDataReader.GetValue(1).ToString();
                    txb_Birthday.Text = sqlDataReader.GetValue(2).ToString();
                    txb_Phone.Text = sqlDataReader.GetValue(3).ToString();
                    txb_Address.Text = sqlDataReader.GetValue(4).ToString();
                    txb_Startday.Text = sqlDataReader.GetValue(5).ToString();
                    txb_Status.Text = sqlDataReader.GetValue(6).ToString();
                    Cbb_Position.Text = sqlDataReader.GetValue(7).ToString();
                    byte[] b = (byte[])dgvimg.Rows[i].Cells[1].Value;
                    Choose_Picture.Image = ByteArrayToImage(b);
                }
                sqlcon.Close();
            }
            sqlcon.Open();
            string d1 = "select * from Salary where Phone_ = '" + txb_Phone.Text + "'";
            SqlCommand sqld1 = new SqlCommand(d1, sqlcon);
            SqlDataReader sqldr1 = sqld1.ExecuteReader();
            if (sqldr1.Read() && Btn_Day1.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day1.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day2.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day2.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day3.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day3.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day4.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day4.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day5.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day5.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day6.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day6.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day7.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day7.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day8.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day8.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day9.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day9.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day10.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day10.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day11.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day11.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day12.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day12.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day13.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day13.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day14.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day14.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day15.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day15.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day16.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day16.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day17.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day17.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day18.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day18.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day19.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day19.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day20.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day20.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day21.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day21.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day22.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day22.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day23.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day23.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day24.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day24.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day25.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day25.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day26.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day26.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day27.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day27.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day28.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day28.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day29.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day29.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day30.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day30.BackColor = Color.DeepSkyBlue;
            }
            if (sqldr1.Read() && Btn_Day31.Text == sqldr1.GetValue(2).ToString())
            {
                Btn_Day31.BackColor = Color.DeepSkyBlue;
            }
            sqlcon.Close();
        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream memoryStream = new MemoryStream(b);
            return Image.FromStream(memoryStream);
        }
        private void Cbb_Position_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlcon.Open();
            String queryDisplayEmployee = "select Name_ as N'Tên nhân viên' from Employee where Position_ = N'" + Cbb_Position.Text + "'";
            SqlDataAdapter sqlDAPdisplayEmployee = new SqlDataAdapter(queryDisplayEmployee, sqlcon);
            DataSet dataSetEmployee = new DataSet();
            sqlDAPdisplayEmployee.Fill(dataSetEmployee);
            DgvNameEmployee.DataSource = dataSetEmployee.Tables[0];
            DgvNameEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sqlcon.Close();

            sqlcon.Open();
            String queryDisplayEmployeeimg = "select Name_ as N'Tên nhân viên', Image_ from Employee where Position_ = N'" + Cbb_Position.Text + "'";
            SqlDataAdapter sqlDAPdisplayEmployeeimg = new SqlDataAdapter(queryDisplayEmployeeimg, sqlcon);
            DataSet dataSetEmployeeimg = new DataSet();
            sqlDAPdisplayEmployeeimg.Fill(dataSetEmployeeimg);
            dgvimg.DataSource = dataSetEmployeeimg.Tables[0];
            dgvimg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sqlcon.Close();

        }

        private void Btn_Day_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DeepSkyBlue;
            LB_Work.Text = btn.Text;
            sqlcon.Open();
            string newWorkingday = "insert into Salary values ('','"+txb_Phone.Text+"','"+LB_Work.Text+"')";
            SqlCommand sqlCommandWorkingday = new SqlCommand(newWorkingday, sqlcon);
            sqlCommandWorkingday.ExecuteNonQuery();
            sqlcon.Close();
        }

        public delegate void delPassData(TextBox text);
        private void Bt_Salary_Click(object sender, EventArgs e)
        {
            Form_Salary form_Salary = new Form_Salary();
            delPassData del = new delPassData(form_Salary.funData);
            del(this.txb_Phone);
            form_Salary.Show();
        }

        [Obsolete]
        private void Bt_Update_Click(object sender, EventArgs e)
        {
            Bt_Update.Enabled = false;
            sqlcon.Open();
            string updateEmployee = "update Employee set @Gender_, @Birthday_ where @Name_ '";
            SqlCommand sqlCommandUpdate = new SqlCommand(updateEmployee, sqlcon);
            sqlCommandUpdate.Parameters.Add("@Gender_", txb_Gender.Text);
            sqlCommandUpdate.Parameters.Add("@Birthday_", txb_Birthday.Text);
            sqlCommandUpdate.Parameters.Add("@Name_", txb_Name.Text);
            sqlCommandUpdate.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
