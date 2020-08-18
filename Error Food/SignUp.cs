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
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 90);
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
        private void Bt_Exit_Click(object sender, EventArgs e)
        {
            Form_SignUp.ActiveForm.Hide();
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
        }

        private void Bt_Sign_Up_Click(object sender, EventArgs e)
        {
            if (txb_Email.Text == null || txb_Full_Name.Text == null || txb_User.Text == null || txb_Password.Text == null)
            {
                MessageBox.Show("Please enter your information", "notification");
            }    
            else
            {
                SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
                sqlcon.Open();
                string newcommand = "insert into Account values ('"+txb_User.Text+"','"+txb_Password.Text+"','"+txb_Email.Text+"',N'"+txb_Full_Name.Text+"','')";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Email : "+txb_Email.Text+"\nFull name : "+txb_Full_Name.Text+"\nUser : "+txb_User.Text+"\nPassword : "+txb_Password.Text,"Your account");
                txb_Email.Text = null;
                txb_Full_Name.Text = null;
                txb_User.Text = null;
                txb_Password.Text = null;
            }    
        }
    }
}
