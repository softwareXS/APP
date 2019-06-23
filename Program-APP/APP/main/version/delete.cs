using dictionary;
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
    public partial class delete : Form
    {
        private user user;
        private IDicDao idicDao = new DicDao();
        Label label;
        public delete(user user, Label label1)
        {
            this.user = user;
            label = label1;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "delete from new_word where u_id=" + user.getU_id() + " and n_word='" + textBox1.Text + "'";
            DialogResult dr = MessageBox.Show(
                    "是否确定删除单词"+textBox1.Text,
                    "提示",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                int n = dao.DAO.ExeSql(s);
                if (0 != n)
                {
                    MessageBox.Show("从生词本删除  " + textBox1.Text + " 成功!");
                    this.Hide();
                    List<Dictionary> ls = idicDao.listAll(user.getU_id());
                    label.Text = "生词本：";
                    label.Text += "\n";
                    foreach (Dictionary dictionary in ls)
                    {
                        label.Text += "\n";
                        label.Text += "单词：" + dictionary.getWord() + "(" + dictionary.getPro().Trim() + ")" + "   释义：" + dictionary.getMeans();
                        label.Text += "\n";
                    }
                }
                else
                {
                    MessageBox.Show("删除单词失败！");
                }
            }
        }
    }
}
