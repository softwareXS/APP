using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace version
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;
            if (name == "" || username == "" || password == "")
            {
                MessageBox.Show("填入完整信息才可以完成注册！");
            }
            else
            {
                string sql = "insert into users(name,username,password,last_word4,last_word6) values('" + name + "','" + username + "','" + password + "',1,1)";
                if (0 != dao.DAO.ExeSql(sql))
                {
                    MessageBox.Show("注册成功！");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
                //MessageBox.Show(sql);
            }
        }
    }
}
