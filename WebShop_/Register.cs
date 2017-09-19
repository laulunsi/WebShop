using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebShop_
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_registerCheck_MouseEnter(object sender, EventArgs e)
        {
            btn_registerCheck.BackgroundImage = Properties.Resources.sure_2;
        }

        private void btn_registerCheck_MouseLeave(object sender, EventArgs e)
        {
            btn_registerCheck.BackgroundImage = Properties.Resources.sure_1;
        }

        private void btn_registerBack_MouseEnter(object sender, EventArgs e)
        {
            btn_registerBack.BackgroundImage = Properties.Resources.cancel_2;
        }

        private void btn_registerBack_MouseLeave(object sender, EventArgs e)
        {
            btn_registerBack.BackgroundImage = Properties.Resources.cancel_1;
        }

        private void btn_registerCheck_Click(object sender, EventArgs e)
        {
            String u = tb_nameR.Text.Trim();
            String p1 = tb_pwd1R.Text.Trim();
            String p2 = tb_pwd2R.Text.Trim();

            if(u=="")
            {
                MessageBox.Show("用户名不能为空！");
                tb_nameR.Focus();
            }
            else if(p1==""||p2=="")
            {
                MessageBox.Show("密码不能为空！");
            }
            else if(p1!=p2)
            {
                MessageBox.Show("两次密码不同！");
                tb_pwd2R.Focus();
            }
            else
            {
                String SQLinsert = "insert into tb_User values('" + u + "','" + p1 + "')";
                int i = DB.executeUpdate(SQLinsert);
                if(i==1)
                {
                    MessageBox.Show("注册成功，请登录！");
                    Login l = new Login();
                    this.Hide();
                    l.Show();
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
            }
           

        }
    }
}
