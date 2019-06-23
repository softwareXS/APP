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
    public partial class commentPart : Form
    {
        private user user;
        private IDicDao idicDao = new DicDao();

        public commentPart(user user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString();
            comment c = new comment(textBox1.Text,user.getU_id(), currentTime, user.getName());
            int n = idicDao.saveComment(c);
            if (n == 0)
            {
                MessageBox.Show("分享失败！");
            }
            else
            {
                List<comment> ls = idicDao.getComment();
                label1.Text = "";
                label1.Text = "动态：";
                foreach (comment com in ls)
                {
                    label1.Text += "\n";
                    label1.Text += com.getName() + "发表动态(" + com.getTime() + ")：";
                    label1.Text += "\n";
                    label1.Text += com.getText();
                    label1.Text += "\n";
                    label1.Text += "\n";
                    textBox1.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
