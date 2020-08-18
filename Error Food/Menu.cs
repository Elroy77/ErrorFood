using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Food
{
    public partial class Form_Menu : Form
    {
        string user = "", password = "", email = "", fullname = "",permission ="";
        public Form_Menu()
        {
            InitializeComponent();

        }
        public Form_Menu(string user,string password,string email,string fullname,string permission)
        {
            InitializeComponent();
            home_red.Visible = true;
            Food_red.Visible = false;
            drink_red.Visible = false;
            combo_red.Visible = false;
            order_red.Visible = false;
            ship_red.Visible = false;
            employee_red.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Border_Right.Left = 1190;
            //
            this.user = user;
            this.password = password;
            this.email = email;
            this.fullname = fullname;
            this.permission = permission;
            if (user == "Admin" || user == "NVM.Error")
            {
                Bt_Employee.Enabled = true;
                Lb_permission.Text = "  -Quyền- \n   Admin";
            }    
            else
            {
                Bt_Employee.Enabled = false;
                Lb_permission.Text = "   -Quyền- \n Employee";
            }    
      
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 90);   

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Lb_timer.Text = DateTime.Now.ToString("hh:mm:ss");

        }
        private void run_tilte_Tick(object sender, EventArgs e)
        {
            Lb_title.Left += 1;
            if (Lb_title.Bounds.IntersectsWith(Border_Right.Bounds))
            {
                Lb_title.Left = -400;
            }    
        }
        private void moveForm(object FormError)
        {
            if (this.Pn_ChildForm.Controls.Count > 0)
                this.Pn_ChildForm.Controls.RemoveAt(0);
            Form fm = FormError as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.Pn_ChildForm.Controls.Add(fm);
            fm.Show();
        }
        // di chuyển form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wMsg, int wParam, int lParam);
        private void Pn_title_MouseDown(object sender, MouseEventArgs e)
        {
            Form_Food form_Food = new Form_Food();
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            Pn_ChildForm.Size = new Size(1340, 900);
            Lb_timer.Left = 480;
            Lb_timer.Top = 200;
            Lb_timer.Size = new Size(300, 700);
        }
        private void Pn_title_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        // Ẩn ứng dụng bằng icon Taskbar windows
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
        private void Bt_Home_Click(object sender, EventArgs e)
        {
            //
            home_red.Visible = true;
            Food_red.Visible = false;
            drink_red.Visible = false;
            combo_red.Visible = false;
            order_red.Visible = false;
            ship_red.Visible = false;
            employee_red.Visible = false;
            //
            moveForm(new Form_Home());
        }

        private void BT_Food_Click(object sender, EventArgs e)
        {
            //
            home_red.Visible = false;
            Food_red.Visible = true;
            drink_red.Visible = false;
            combo_red.Visible = false;
            order_red.Visible = false;
            ship_red.Visible = false;
            employee_red.Visible = false;
            //
            moveForm(new Form_Food());
        }

        private void Bt_Drink_Click(object sender, EventArgs e)
        {
            //
            home_red.Visible = false;
            Food_red.Visible = false;
            drink_red.Visible = true;
            combo_red.Visible = false;
            order_red.Visible = false;
            ship_red.Visible = false;
            employee_red.Visible = false;
            //
            moveForm(new Form_Drink());
        }

        private void Bt_Combo_Click(object sender, EventArgs e)
        {
            //
            home_red.Visible = false;
            Food_red.Visible = false;
            drink_red.Visible = false;
            combo_red.Visible = true;
            order_red.Visible = false;
            ship_red.Visible = false;
            employee_red.Visible = false;
            //
            moveForm(new Form_Combo());
        }

        private void Bt_order_Click(object sender, EventArgs e)
        {
            //
            home_red.Visible = false;
            Food_red.Visible = false;
            drink_red.Visible = false;
            combo_red.Visible = false;
            order_red.Visible = true;
            ship_red.Visible = false;
            employee_red.Visible = false;
            //
            moveForm(new Form_Order());
        }

        private void Bt_Ship_Click(object sender, EventArgs e)
        {
            //
            home_red.Visible = false;
            Food_red.Visible = false;
            drink_red.Visible = false;
            combo_red.Visible = false;
            order_red.Visible = false;
            ship_red.Visible = true;
            employee_red.Visible = false;
            //
            moveForm(new Form_Ship());
        }

        private void Bt_Employee_Click(object sender, EventArgs e)
        {
            //
            home_red.Visible = false;
            Food_red.Visible = false;
            drink_red.Visible = false;
            combo_red.Visible = false;
            order_red.Visible = false;
            ship_red.Visible = false;
            employee_red.Visible = true;
            //
            moveForm(new Form_Manager());
        }
        private void Bt_Exit_Click(object sender, EventArgs e)
        {
            Form_Menu.ActiveForm.Hide();
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
        }
    }
}
