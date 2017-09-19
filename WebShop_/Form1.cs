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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 窗体加载

        //窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“webShop1DataSet9.tb_buyer”中。您可以根据需要移动或删除它。
            this.tb_buyerTableAdapter1.Fill(this.webShop1DataSet9.tb_buyer);
            // TODO:  这行代码将数据加载到表“webShop1DataSet8.tb_buyer”中。您可以根据需要移动或删除它。
            this.tb_buyerTableAdapter.Fill(this.webShop1DataSet8.tb_buyer);
            // TODO:  这行代码将数据加载到表“webShop1DataSet7.tb_Buy”中。您可以根据需要移动或删除它。
            this.tb_BuyTableAdapter.Fill(this.webShop1DataSet7.tb_Buy);
            // TODO:  这行代码将数据加载到表“webShop1DataSet6.tb_goods”中。您可以根据需要移动或删除它。
            this.tb_goodsTableAdapter.Fill(this.webShop1DataSet6.tb_goods);
            // TODO:  这行代码将数据加载到表“webShop1DataSet3.tb_Sup”中。您可以根据需要移动或删除它。
            this.tb_SupTableAdapter.Fill(this.webShop1DataSet3.tb_Sup);
            // TODO:  这行代码将数据加载到表“webShop1DataSet2.tb_danwei”中。您可以根据需要移动或删除它。
            this.tb_danweiTableAdapter.Fill(this.webShop1DataSet2.tb_danwei);
            // TODO:  这行代码将数据加载到表“webShop1DataSet1.tb_StoreHao”中。您可以根据需要移动或删除它。
            this.tb_StoreHaoTableAdapter.Fill(this.webShop1DataSet1.tb_StoreHao);
            // TODO:  这行代码将数据加载到表“webShop1DataSet.tb_type”中。您可以根据需要移动或删除它。
            this.tb_typeTableAdapter.Fill(this.webShop1DataSet.tb_type);

            tabControl1.TabPages.Clear();//清除所有选项卡
            tabP_first.Parent = tabControl1;//显示首页
            tabControl1.SelectedTab = tabP_first;
        }
        //窗体加载结束
        #endregion

        #region 上边栏

        //上边栏
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xgmm xgmm_ = new xgmm();
            xgmm_.ShowDialog();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabP_buytable.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_buytable;
            //打开前先清空所有数据
            c_Name.Text = "";
            c_Id.Text = "";
            c_Type.Text = "";
            c_StoreNum.Text = "";
            c_Getprice.Text = "";
            c_Number.Text = "";
            c_Sup.Text = "";
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tabP_Bselect.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_Bselect;
            //打开后先显示全部
            String SQLselect2 = "select * from tb_goods , tb_Buy";
            DataSet rs2 = DB.executeQuerry(SQLselect2);
            //定义表格标题
            rs2.Tables[0].Columns[0].ColumnName = "商品编号";
            rs2.Tables[0].Columns["c_Name"].ColumnName = "商品名称";
            rs2.Tables[0].Columns["t_Type"].ColumnName = "商品类型";
            rs2.Tables[0].Columns["c_StoreNum"].ColumnName = "仓库";
            rs2.Tables[0].Columns["c_GetPrice"].ColumnName = "商品进价";
            rs2.Tables[0].Columns["c_Number"].ColumnName = "购入数量";
            rs2.Tables[0].Columns["t_Sup"].ColumnName = "供应商";
            rs2.Tables[0].Columns["c_GetTime"].ColumnName = "购入时间";
            rs2.Tables[0].Columns[4].ColumnName = "!!!!";

            //MessageBox.Show(rs2.Tables[0].Columns[4].ToString());
            rs2.Tables[0].Columns["!!!!"].ColumnMapping = MappingType.Hidden;
            //将数据填充到datagridview
            dgv_Buy.DataSource = rs2.Tables[0];
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tabP_sell.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_sell;
            //先清空所有
            text_SName.Text = "";
            text_Sid.Text = "";
            cbB_Stype.Text = "";
            cbB_Scangku.Text = "";
            text_Smoney.Text = "";
            text_SNum.Text = "";
            cbB_Sbuyer.Text = "";
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            tabP_SC.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_SC;
            //显示全部
            String SQLselect = "select * from tb_goods,tb_Sell";
            DataSet s = DB.executeQuerry(SQLselect);
            //定义表格标题
            s.Tables[0].Columns[0].ColumnName = "商品编号";
            s.Tables[0].Columns["c_Name"].ColumnName = "商品名称";
            s.Tables[0].Columns["t_Type"].ColumnName = "商品类型";
            s.Tables[0].Columns["c_StoreNum"].ColumnName = "仓库";
            s.Tables[0].Columns["s_PutPrice"].ColumnName = "商品售价";
            s.Tables[0].Columns["s_Number"].ColumnName = "售出数量";
            s.Tables[0].Columns["t_buyer"].ColumnName = "客户";
            s.Tables[0].Columns["s_PutTime"].ColumnName = "售出时间";
            s.Tables[0].Columns[8].ColumnName = "!!!!";
            //隐藏多余的c_Id列
            s.Tables[0].Columns["!!!!"].ColumnMapping = MappingType.Hidden;

            dgv_sell.DataSource = s.Tables[0];
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            tabP_cangku.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_cangku;
            comboBox1.Text = "";
        }
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            tabP_buyer.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_buyer;
            String s = "select * from tb_buyer";
            DataSet s1 = DB.executeQuerry(s);
            dataGridView1.DataSource = s1.Tables[0];
        }
        private void 打印购货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabP_Bselect.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_Bselect;
            //打开后先显示全部
            String SQLselect2 = "select * from tb_goods ,tb_Buy where tb_goods.c_Id=tb_Buy.c_Id";
            DataSet rs2 = DB.executeQuerry(SQLselect2);
            //定义表格标题
            rs2.Tables[0].Columns[0].ColumnName = "商品编号";
            rs2.Tables[0].Columns["c_Name"].ColumnName = "商品名称";
            rs2.Tables[0].Columns["t_Type"].ColumnName = "商品类型";
            rs2.Tables[0].Columns["c_StoreNum"].ColumnName = "仓库";
            rs2.Tables[0].Columns["c_GetPrice"].ColumnName = "商品进价";
            rs2.Tables[0].Columns["c_Number"].ColumnName = "购入数量";
            rs2.Tables[0].Columns["t_Sup"].ColumnName = "供应商";
            rs2.Tables[0].Columns["c_GetTime"].ColumnName = "购入时间";
            rs2.Tables[0].Columns[4].ColumnName = "!!!!";

            //MessageBox.Show(rs2.Tables[0].Columns[4].ToString());
            rs2.Tables[0].Columns["!!!!"].ColumnMapping = MappingType.Hidden;
            //将数据填充到datagridview
            dgv_Buy.DataSource = rs2.Tables[0];
        }

        //上边栏结束
        #endregion

        #region 左侧栏

        //左侧栏
        private void 购货订单ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tabP_buytable.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_buytable;
            //打开前先清空所有数据
            c_Name.Text = "";
            c_Id.Text = "";
            c_Type.Text = "";
            c_StoreNum.Text = "";
            c_Getprice.Text = "";
            c_Number.Text = "";
            c_Sup.Text = "";

        }
        private void 购货查询ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tabP_Bselect.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_Bselect;
            //打开后先显示全部
            String SQLselect2 = "select * from tb_goods ,tb_Buy where tb_goods.c_Id=tb_Buy.c_Id";
            DataSet rs2 = DB.executeQuerry(SQLselect2);
            //定义表格标题
            rs2.Tables[0].Columns[0].ColumnName = "商品编号";
            rs2.Tables[0].Columns["c_Name"].ColumnName = "商品名称";
            rs2.Tables[0].Columns["t_Type"].ColumnName = "商品类型";
            rs2.Tables[0].Columns["c_StoreNum"].ColumnName = "仓库";
            rs2.Tables[0].Columns["c_GetPrice"].ColumnName = "商品进价";
            rs2.Tables[0].Columns["c_Number"].ColumnName = "购入数量";
            rs2.Tables[0].Columns["t_Sup"].ColumnName = "供应商";
            rs2.Tables[0].Columns["c_GetTime"].ColumnName = "购入时间";
            rs2.Tables[0].Columns[4].ColumnName = "!!!!";

            //MessageBox.Show(rs2.Tables[0].Columns[4].ToString());
            rs2.Tables[0].Columns["!!!!"].ColumnMapping = MappingType.Hidden;
            //将数据填充到datagridview
            dgv_Buy.DataSource = rs2.Tables[0];
        }
        private void 售货订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabP_sell.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_sell;
            //先清空所有
            text_SName.Text = "";
            text_Sid.Text = "";
            cbB_Stype.Text = "";
            cbB_Scangku.Text = "";
            text_Smoney.Text = "";
            text_SNum.Text = "";
            cbB_Sbuyer.Text = "";
        }
        private void 售货查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabP_SC.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_SC;
            //显示全部
            String SQLselect = "select * from tb_goods,tb_Sell";
            DataSet s = DB.executeQuerry(SQLselect);
            //定义表格标题
            s.Tables[0].Columns[0].ColumnName = "商品编号";
            s.Tables[0].Columns["c_Name"].ColumnName = "商品名称";
            s.Tables[0].Columns["t_Type"].ColumnName = "商品类型";
            s.Tables[0].Columns["c_StoreNum"].ColumnName = "仓库";
            s.Tables[0].Columns["s_PutPrice"].ColumnName = "商品售价";
            s.Tables[0].Columns["s_Number"].ColumnName = "售出数量";
            s.Tables[0].Columns["t_buyer"].ColumnName = "客户";
            s.Tables[0].Columns["s_PutTime"].ColumnName = "售出时间";
            s.Tables[0].Columns[8].ColumnName = "!!!!";
            //隐藏多余的c_Id列
            s.Tables[0].Columns["!!!!"].ColumnMapping = MappingType.Hidden;

            dgv_sell.DataSource = s.Tables[0];
        }

        private void 客户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabP_buyer.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_buyer;
            String s = "select * from tb_buyer";
            DataSet s1 = DB.executeQuerry(s);
            dataGridView1.DataSource = s1.Tables[0];
        }
        private void 仓库查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabP_cangku.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_cangku;
            comboBox1.Text = "";
        }
        //左侧栏结束
        #endregion

        #region 购货订单tabpage

        // 购货订单tabpage
        private void button2_Click(object sender, EventArgs e)
        {
            String kucun = "";//仓库表中库存数量
            String Sqlc_Name = c_Name.Text.Trim();
            String Sqlc_Id = c_Id.Text.Trim();
            String Sqlc_Type = c_Type.Text.Trim();
            String Sqlc_StoreNum = c_StoreNum.Text.Trim();
            String Sqlprice = c_Getprice.Text.Trim();
            String SqlNumber = c_Number.Text.Trim() + c_danwei.Text.Trim();
            DateTime Sqltime = dateTimePicker1.Value;
            String Sqlsup = c_Sup.Text.Trim();

            //判断是否有库存
            String s1 = "select * from tb_Store where c_Id=" + Sqlc_Id;
            //SqlDataReader rs1 = DB.executeQuerry1(s1);
            DataSet rs1 = DB.executeQuerry(s1);

            String SQLinsert1 = "";
            int i1 = 0;
            int i3 = 0;

            if(rs1.Tables[0].Rows.Count!=0)
            {
                String s2 = "select * from tb_goods where c_Id=" + Sqlc_Id;
                DataSet rs2 = DB.executeQuerry(s2);
                String StoreNum=rs2.Tables[0].Rows[0]["c_StoreNum"].ToString();
                if(!StoreNum.Equals(Sqlc_StoreNum))
                {
                    MessageBox.Show("仓库中有相同商品，在" + StoreNum + "中保存，请将新购商品也保存在此仓库中！");
                    c_StoreNum.Text = StoreNum;
                }

                //库存等于购买的数量加上库存数量
                String Num = rs1.Tables[0].Rows[0]["t_Number"].ToString();
                kucun = c_Number.Text.Trim() + Num;
                //更改库存表
                String SQLupdata = "update tb_Store set t_Number=" + kucun;
                i3 = DB.executeUpdate(SQLupdata);
                //MessageBox.Show(SQLupdata);

                i1 = 1;
            }
            else
            {
                //库存等于购买数量
                kucun = c_Number.Text.Trim();
                //判断是否有商品记录//如果没有商品记录
                //商品表添加
                SQLinsert1 = "insert into tb_goods values ('"
                    + Sqlc_Id + "','" + Sqlc_Name + "','" + Sqlc_Type + "','" + Sqlc_StoreNum + "')";
                i1 = DB.executeUpdate(SQLinsert1);
                //库存表添加
                String SQLinsert3 = "insert into tb_Store values ('"
                    + kucun + "','" + Sqlc_Id + "')";
                i3 = DB.executeUpdate(SQLinsert3);
               // MessageBox.Show(SQLinsert3);
            }
            //购货表添加
            String SQLinsert2 = "insert into tb_Buy values('"
                + Sqlc_Id + "','" + Sqlprice + "','" + SqlNumber + "','" + Sqlsup + "','" + Sqltime + "')";
            int i2 = DB.executeUpdate(SQLinsert2);

            //MessageBox.Show("SQLinsert1:" + SQLinsert1 + "\nSQLinsert2:" + SQLinsert2 + "\n");

            if (i1 == 1 && i2 == 1 && i3 == 1)
            {
                MessageBox.Show("购买成功！");
                //界面清空
                c_Name.Text = "";
                c_Id.Text = "";
                c_Type.Text = "";
                c_StoreNum.Text = "";
                c_Getprice.Text = "";
                c_Number.Text = "";
                c_Sup.Text = "";
            }
            else
            {
                MessageBox.Show("购买失败！");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            tabP_buytable.Parent = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabP_buytable.Parent = null;
        }
        //购货订单页面结束
        #endregion

        #region 购货查询tabpage

        //购货查询tabpage
        private void button5_Click(object sender, EventArgs e)
        {
            tabP_Bselect.Parent = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String S_fangshi = "";//查询属性列
            //String cx="";//判断查那个表
            Boolean cx = true;
            //查询方式
            String S_tiaojian = chaxunfangshi.Text.Trim();
            //查询内容
            String S_neirong = chaxun.Text.Trim();
            if (S_tiaojian.Equals("商品编号"))
            {
                S_fangshi = "c_Id";
                //cx = "tb_goods";
                cx = false;
            }   
            else if (S_tiaojian.Equals("商品名称"))
            {
                S_fangshi = "c_Name";
                //cx = "tb_goods";
            }    
            else if (S_tiaojian.Equals("商品类型"))
            {
                S_fangshi = "t_Type";
                //cx = "tb_goods";
            }     
            else if (S_tiaojian.Equals("仓库号"))
            {
                S_fangshi = "c_StoreNum";
                //cx = "tb_goods";
            }   
            else if (S_tiaojian.Equals("供应商"))
            {
                S_fangshi = "t_Sup";
                //cx = "tb_Buy";
            }
            DateTime time1=dtp_1.Value;
            DateTime time2=dtp_2.Value;
            if(cx)
            {
                String SQLselect1 = "select * from tb_goods,tb_Buy where "
                + S_fangshi + "='" + S_neirong + "'and c_GetTime > '" + time1 + "' and c_GetTime < '" + time2 + "'";
                //MessageBox.Show(SQLselect1);
                DataSet rs1 = DB.executeQuerry(SQLselect1);
                //定义表格标题
                rs1.Tables[0].Columns[0].ColumnName = "商品编号";
                rs1.Tables[0].Columns["c_Name"].ColumnName = "商品名称";
                rs1.Tables[0].Columns["t_Type"].ColumnName = "商品类型";
                rs1.Tables[0].Columns["c_StoreNum"].ColumnName = "仓库";
                rs1.Tables[0].Columns[4].ColumnName = "!!!!";
                rs1.Tables[0].Columns["c_GetPrice"].ColumnName = "商品进价";
                rs1.Tables[0].Columns["c_Number"].ColumnName = "购入数量";
                rs1.Tables[0].Columns["t_Sup"].ColumnName = "供应商";
                rs1.Tables[0].Columns["c_GetTime"].ColumnName = "购入时间";
                //隐藏多余的c_Id列
                rs1.Tables[0].Columns["!!!!"].ColumnMapping = MappingType.Hidden;

                //String c_Id1 = rs1.Tables[0].Columns[4].ToString();
                //rs1.Tables[0].Columns[c_Id1].ColumnMapping = MappingType.Hidden;

                //填充
                dgv_Buy.DataSource = rs1.Tables[0];
            }
            else
            {
                String SQLselect1 = "select * from tb_goods,tb_Buy where tb_goods.c_Id ='" 
                    + S_neirong + "'and c_GetTime > '" + time1 + "' and c_GetTime < '" + time2 + "'";
                //MessageBox.Show(SQLselect1);
                DataSet rs1 = DB.executeQuerry(SQLselect1);
                //定义表格标题
                rs1.Tables[0].Columns[0].ColumnName = "商品编号";
                rs1.Tables[0].Columns["c_Name"].ColumnName = "商品名称";
                rs1.Tables[0].Columns["t_Type"].ColumnName = "商品类型";
                rs1.Tables[0].Columns["c_StoreNum"].ColumnName = "仓库";
                rs1.Tables[0].Columns[4].ColumnName = "!!!!";
                rs1.Tables[0].Columns["c_GetPrice"].ColumnName = "商品进价";
                rs1.Tables[0].Columns["c_Number"].ColumnName = "购入数量";
                rs1.Tables[0].Columns["t_Sup"].ColumnName = "供应商";
                rs1.Tables[0].Columns["c_GetTime"].ColumnName = "购入时间";
                //隐藏多余的c_Id列
                rs1.Tables[0].Columns["!!!!"].ColumnMapping = MappingType.Hidden;
                //填充
                dgv_Buy.DataSource = rs1.Tables[0];
            }
            
        }

        private void dgv_Buy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //购货查询页面结束
        #endregion

        #region 售货订单tabpage
        //售货tabpage
        private void button7_Click(object sender, EventArgs e)
        {
            String c_Name = text_SName.Text.Trim();
            String c_Id = text_Sid.Text.Trim();
            String t_Type = cbB_Stype.Text.Trim();
            String c_StoreNum = cbB_Scangku.Text.Trim();
            String s_PutPrice = text_Smoney.Text.Trim();
            String s_Number = text_SNum.Text.Trim();
            String t_buyer = cbB_Sbuyer.Text.Trim();
            DateTime s_PutTime = dateTime_S.Value;

            //查询库存，判断数量是否足够出售
            String SQLselect1 = "select * from tb_Store where c_Id='" + c_Id + "'";
            DataSet rs1 = DB.executeQuerry(SQLselect1);
            if(rs1.Tables[0].Rows.Count==0)
            {
                MessageBox.Show("仓库中没有此商品！");
                text_SName.Text="";
            }
            else
            {
                String KC=rs1.Tables[0].Rows[0]["t_Number"].ToString();//将查询后的库存数量取出来定义为KC
                int kucun,sellnum;//定义两个整形变量
                int.TryParse(s_Number,out sellnum);
                int.TryParse(KC,out kucun);//将String类型转换为int类型
                if(sellnum>kucun)
                {
                    //提示库存不足，清空售出数量，并将焦点定位在售出数量
                    MessageBox.Show("库存不足，无法售出！");
                    text_SNum.Text = KC;
                    text_SNum.Focus();
                }
                else
                {
                    //插入售货表
                    String SQLinsert1 = "insert into tb_Sell values('"
                        + s_PutPrice + "','" + s_Number + "','" + t_buyer + "','" + s_PutTime + "','" + c_Id + "')";
                    int i1 = DB.executeUpdate(SQLinsert1);

                    //更改库存表
                    kucun = kucun - sellnum;
                    KC = kucun.ToString();
                    String SQLupdate1 = "update tb_Store set t_Number='" + KC + "'";
                    int u1 = DB.executeUpdate(SQLupdate1);

                    if(i1==1&&u1==1)
                    {
                        MessageBox.Show("售出成功！");
                        text_SName.Text = "";
                        text_Sid.Text = "";
                        cbB_Stype.Text = "";
                        cbB_Scangku.Text = "";
                        text_Smoney.Text = "";
                        text_SNum.Text = "";
                        cbB_Sbuyer.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("售出失败！");
                    }

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabP_sell.Parent = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabP_sell.Parent = null;
        }

       
        //售货订单页面结束
        #endregion

        #region 售货查询tabpage
        //售货查询tabpage

        private void button9_Click(object sender, EventArgs e)
        {
            tabP_SC.Parent = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String S_fangshi = "";//查询属性列
            //String cx="";//判断查那个表
            //查询方式
            String S_tiaojian = cbB_SCfangshi.Text.Trim();
            //查询内容
            String S_neirong = text_SCneirong.Text.Trim();
            Boolean cx = true;
            if (S_tiaojian.Equals("商品编号"))
            {
                S_fangshi = "c_Id";
                cx = false;
            }
            else if (S_tiaojian.Equals("商品名称"))
                S_fangshi = "c_Name";
            else if (S_tiaojian.Equals("商品类型"))
                S_fangshi = "t_Type";
            else if (S_tiaojian.Equals("仓库号"))
                S_fangshi = "c_StoreNum";
            else if (S_tiaojian.Equals("客户"))
                S_fangshi = "t_buyer";
            DateTime time1 = dateTime_SC1.Value;
            DateTime time2 = dateTime_SC2.Value;
            if (cx)
            {
                String SQLselect1 = "select * from tb_goods,tb_Sell where "
                + S_fangshi + "='" + S_neirong + "'and s_PutTime > '" + time1 + "' and s_PutTime < '" + time2 + "'";
                MessageBox.Show(SQLselect1);
                DataSet rs1 = DB.executeQuerry(SQLselect1);
                //定义表格标题
                rs1.Tables[0].Columns[0].ColumnName = "商品编号";
                rs1.Tables[0].Columns["c_Name"].ColumnName = "商品名称";
                rs1.Tables[0].Columns["t_Type"].ColumnName = "商品类型";
                rs1.Tables[0].Columns["c_StoreNum"].ColumnName = "仓库";
                rs1.Tables[0].Columns["s_PutPrice"].ColumnName = "商品售价";
                rs1.Tables[0].Columns["s_Number"].ColumnName = "售出数量";
                rs1.Tables[0].Columns["t_buyer"].ColumnName = "客户";
                rs1.Tables[0].Columns["s_PutTime"].ColumnName = "售出时间";
                rs1.Tables[0].Columns[8].ColumnName = "!!!!";
                //隐藏多余的c_Id列
                rs1.Tables[0].Columns["!!!!"].ColumnMapping = MappingType.Hidden;

                //String c_Id1 = rs1.Tables[0].Columns[4].ToString();
                //rs1.Tables[0].Columns[c_Id1].ColumnMapping = MappingType.Hidden;

                //填充
                dgv_sell.DataSource = rs1.Tables[0];
            }
            else
            {
                String SQLselect1 = "select * from tb_goods,tb_Sell where tb_goods.c_Id ='"
                    + S_neirong + "'and s_PutTime > '" + time1 + "' and s_PutTime < '" + time2 + "'";
                MessageBox.Show(SQLselect1);
                DataSet rs1 = DB.executeQuerry(SQLselect1);
                //定义表格标题
                rs1.Tables[0].Columns[0].ColumnName = "商品编号";
                rs1.Tables[0].Columns["c_Name"].ColumnName = "商品名称";
                rs1.Tables[0].Columns["t_Type"].ColumnName = "商品类型";
                rs1.Tables[0].Columns["c_StoreNum"].ColumnName = "仓库";
                rs1.Tables[0].Columns["s_PutPrice"].ColumnName = "商品售价";
                rs1.Tables[0].Columns["s_Number"].ColumnName = "售出数量";
                rs1.Tables[0].Columns["t_buyer"].ColumnName = "客户";
                rs1.Tables[0].Columns["s_PutTime"].ColumnName = "售出时间";
                rs1.Tables[0].Columns[8].ColumnName = "!!!!";
                //隐藏多余的c_Id列
                rs1.Tables[0].Columns["!!!!"].ColumnMapping = MappingType.Hidden;
                //填充
                dgv_sell.DataSource = rs1.Tables[0];
            }
 
        }
        //售货查询页面结束
        #endregion

        #region 添加客户tabpage

        //添加客户tabpage
        private void button11_Click(object sender, EventArgs e)
        {
            manage.buyer buyerN = new manage.buyer();
            buyerN.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;//这行语句也可以不要，如果已经创建了dgv，详见航道系统的代码。
            //如果是"Button"列，按钮被点击
            if (dgv.Columns[e.ColumnIndex].Name == "Column2")//此处索引列可以使name、也可以使headertext，看具体的设置。
            {
                DialogResult dr;
                dr = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    int a = e.RowIndex;
                    //MessageBox.Show(dataGridView1.Rows[a].Cells[2].Value.ToString());
                    String buyer = dataGridView1.Rows[a].Cells[2].Value.ToString();
                    String SQLdelete = "delete from tb_buyer where t_buyer='" + buyer + "'";
                    MessageBox.Show(SQLdelete);
                    int d = DB.executeUpdate(SQLdelete);
                    if(d==1)
                    {
                        MessageBox.Show("删除成功！");
                        String SQLselect = "select * from tb_buyer";
                        DataSet s = DB.executeQuerry(SQLselect);
                        dgv.DataSource = s.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
            if (dgv.Columns[e.ColumnIndex].Name == "Column1")//此处索引列可以使name、也可以使headertext，看具体的设置。
            {
                DialogResult dr;
                dr = MessageBox.Show("确定修改？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    int a = e.RowIndex;
                    //MessageBox.Show(dataGridView1.Rows[a].Cells[2].Value.ToString());
                    //取出数据库中的值
                    String SQLselect = "select * from tb_buyer";
                    DataSet s = DB.executeQuerry(SQLselect);
                    String t_buyer = s.Tables[0].Rows[a][0].ToString();
                    //MessageBox.Show(t_buyer);
                    //将在datagridview中更改的数据更改到数据库中
                    String buyer = dataGridView1.Rows[a].Cells[2].Value.ToString();
                    String SQLupdate = "update tb_buyer set t_buyer='" + buyer + "'where t_buyer='" + t_buyer + "'";
                    int u = DB.executeUpdate(SQLupdate);
                    if(u==1)
                    {
                        MessageBox.Show("修改成功！");
                        String SQLselect1 = "select * from tb_buyer";
                        DataSet s1 = DB.executeQuerry(SQLselect1);
                        dgv.DataSource = s1.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabP_buyer.Parent = null;
        }
        //添加客户页面结束
        #endregion

        #region 仓库tabpage

        //仓库tabpage
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cangku = comboBox1.Text.Trim();
            String SQLselect = "select * from tb_goods,tb_Store where c_StoreNum='"+cangku+"'";
            DataSet s = DB.executeQuerry(SQLselect);
            if(s.Tables[0].Rows.Count==0)
            {
                dgv_cangku.DataSource = null;
            }
            else
            {
                s.Tables[0].Columns["c_Id"].ColumnName = "商品编号";
                s.Tables[0].Columns["c_Name"].ColumnName = "商品名称";
                s.Tables[0].Columns["t_Type"].ColumnName = "商品类型";
                s.Tables[0].Columns["c_StoreNum"].ColumnName = "仓库";
                s.Tables[0].Columns["t_Number"].ColumnName = "库存";
                s.Tables[0].Columns[5].ColumnName = "!";
                s.Tables[0].Columns["!"].ColumnMapping = MappingType.Hidden;
                dgv_cangku.DataSource = s.Tables[0];
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //tabP_cangku.Parent = tabControl1;
            //tabControl1.SelectedTab = tabP_cangku;
            tabP_cangku.Parent = null;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.searchChange;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.search;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.deteteChange;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.detete;
        }
        //仓库页面结束
        #endregion

        #region 首页tabpage

        //首页tabpage
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabP_buytable.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_buytable;
            //打开前先清空所有数据
            c_Name.Text = "";
            c_Id.Text = "";
            c_Type.Text = "";
            c_StoreNum.Text = "";
            c_Getprice.Text = "";
            c_Number.Text = "";
            c_Sup.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabP_sell.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_sell;
            //先清空所有
            text_SName.Text = "";
            text_Sid.Text = "";
            cbB_Stype.Text = "";
            cbB_Scangku.Text = "";
            text_Smoney.Text = "";
            text_SNum.Text = "";
            cbB_Sbuyer.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabP_cangku.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_cangku;
            comboBox1.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tabP_buyer.Parent = tabControl1;
            tabControl1.SelectedTab = tabP_buyer;
        }

        private void dgv_cangku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        //首页结束
        #endregion

    }
}
