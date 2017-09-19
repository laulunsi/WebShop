using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebShop_.manage
{
    public partial class buyer : Form
    {
        public buyer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String add_buyer = textBox1.Text.Trim();
            String SQLselect = "select * from tb_buyer where t_buyer='" + add_buyer + "'";
            DataSet s = DB.executeQuerry(SQLselect);
            if(s.Tables[0].Rows.Count!=0)
            {
                MessageBox.Show("此客户已存在不需要多次添加！");
                textBox1.Text = "";
            }
            else
            {
                String SQLinsert = "insert into tb_buyer values('" + add_buyer + "')";
                int i = DB.executeUpdate(SQLinsert);
                if(i==1)
                {
                    MessageBox.Show("添加成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.markChange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.mark;
        }
    }
}
