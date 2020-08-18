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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        private void BT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 90);
        }
        private void Cb_Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Show_Password.Checked == true)
            {
                txb_password.UseSystemPasswordChar = false;
            }
            else
                txb_password.UseSystemPasswordChar = true;
        }

        private void Bt_Login_Click(object sender, EventArgs e)
        {
            if (txb_user.Text == "" || txb_password.Text == "")
            {
                MessageBox.Show("Please enter your information", "notification");
            }  
            else
            {
                SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
                sqlcon.Open();
                string newcommand = "select * from Account where User_ = '" + txb_user.Text + "' and Password_ = '" + txb_password.Text + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(newcommand,sqlcon);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                DataTable dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    Form_Login.ActiveForm.Hide();
                    Form_Menu form_Menu = new Form_Menu(dataTable.Rows[0][0].ToString(), dataTable.Rows[0][1].ToString(), dataTable.Rows[0][2].ToString(), dataTable.Rows[0][3].ToString(), dataTable.Rows[0][4].ToString());
                    form_Menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Don't have an account or Incorrect information", "notification");
                    MessageBox.Show("Do you want to create an account?", "notification");
                }
            }
        }

        private void Bt_Create_Account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Login.ActiveForm.Hide();
            Form_SignUp signUp = new Form_SignUp();
            signUp.Show();
        }

        private void Bt_Forget_Password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Login.ActiveForm.Hide();
            Form_FogetPassword form_FogetPassword = new Form_FogetPassword();
            form_FogetPassword.Show();
        }
    }
}
