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
    public partial class Form_FogetPassword : Form
    {
        public Form_FogetPassword()
        {
            InitializeComponent();
        }

        private void Form_FogetPassword_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 90);
            randomcaptcha();
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

        private void Bt_Submit_Click(object sender, EventArgs e)
        {
            if (txb_user.Text == null)
            {
                MessageBox.Show("Please enter usename your account");
            }    
            else
            {
                SqlConnection sqlcon = new SqlConnection(ConnectionString.Connection);
                sqlcon.Open();
                string newcommand = "select * from Account where User_ = '"+txb_user.Text+"'";
                SqlCommand sqlCommand = new SqlCommand(newcommand, sqlcon);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (txb_Captcha.Text == Lb_RandomCaptcha.Text && sqlDataReader.Read())
                {
                    MessageBox.Show("Your password :"+sqlDataReader.GetValue(1).ToString());
                    txb_user.Clear();
                    randomcaptcha();
                    txb_Captcha.Text = null;
                }
                else
                {
                    MessageBox.Show("Error captcha or error use", "notification");
                }
            }    
        }
        public string randomcaptcha()
        {
            Random random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghiklmnopqrstuvwxyz0123456789";
            return Lb_RandomCaptcha.Text = new string(chars.Select(c => chars[random.Next(chars.Length)]).Take(6).ToArray());
        }

        private void Bt_ResetCaptcha_Click(object sender, EventArgs e)
        {
            randomcaptcha();
        }
    }
}
