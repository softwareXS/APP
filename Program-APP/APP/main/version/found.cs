using dictionary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace version
{
    public partial class found : Form
    {
        private IDicDao idicDao = new DicDao();
        private user user;


        public found(user user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            List<Dictionary> ls = idicDao.foundByEnglish(word);
            groupBox1.Text = "";
            groupBox1.Text += "查询结果：";
            foreach (Dictionary dictionary in ls)
            {
                groupBox1.Text += "\n"+ "单词：" + dictionary.getWord()+"("+dictionary.getPro().Trim()+")"+"            释义："+dictionary.getMeans();
            }
        }
    }
}
