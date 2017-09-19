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

namespace WebShop_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_MouseEnter(object sender, EventArgs e)
        {
            btn_login.BackgroundImage = Properties.Resources.login_2;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackgroundImage = Properties.Resources.login_1;
        }

        private void btn_register_MouseEnter(object sender, EventArgs e)
        {
            btn_register.BackgroundImage = Properties.Resources.register_2;
        }

        private void btn_register_MouseLeave(object sender, EventArgs e)
        {
            btn_register.BackgroundImage = Properties.Resources.register_1;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = u_Username.Text.Trim();
            String password = u_Password.Text.Trim();
            if(username=="")
            {
                MessageBox.Show("用户名不能为空！");
                u_Username.Focus();
            }
            else if(password=="")
            {
                MessageBox.Show("密码不能为空！");
                u_Password.Focus();
            }
            else
            {
                String SQLselect = "select * from tb_User where u_UserName='" + username + "'";
                SqlDataReader s = DB.executeQuerry1(SQLselect);
                if(s.Read())
                {
                    if(s.GetValue(1).Equals(password))
                    {
                        Form1 form = new Form1();
                        this.Hide();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("密码输入错误");
                        u_Password.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("没有此用户！");
                    u_Username.Focus();
                }
                
            }
            
        }
    }
}
