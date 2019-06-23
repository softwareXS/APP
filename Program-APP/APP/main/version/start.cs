using dictionary;
using System;
using System.Windows.Forms;
using dao;
using System.Collections.Generic;
using System.Drawing;

namespace version
{
    public partial class start : Form
    {
        private user user;
        private IDicDao idicDao = new DicDao();

        public start(user user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dic f2 = new dic(user);
            f2.TopLevel = false;
            panel1.Controls.Clear();
            Dictionary dictionary = idicDao.get(user.getLast_Word4());
            f2.groupBox1.Text = dictionary.getWord() + "(" + dictionary.getPro().Trim() + ")";
            f2.groupBox2.Text = dictionary.getMeans();
            panel1.Controls.Add(f2);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*commentView f3 = new commentView();
            f3.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(f3);
            f3.Show();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            found f4 = new found(user);
            f4.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(f4);
            f4.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new_words1 new_words1 = new new_words1(user);
            new_words1.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(new_words1);
            List<Dictionary> ls=idicDao.listAll(user.getU_id());
            new_words1.label1.Text = "生词本：";
            new_words1.label1.Text += "\n";
            foreach (Dictionary dictionary in ls)
            {
                new_words1.label1.Text += "\n";
                new_words1.label1.Text += "单词：" + dictionary.getWord() + "(" + dictionary.getPro().Trim() + ")" + "   释义：" + dictionary.getMeans();
                new_words1.label1.Text += "\n";
            }
            new_words1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            commentPart f = new commentPart(user);
            f.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            List<comment> ls = idicDao.getComment();
            f.label1.Text = "动态：";
            foreach (comment com in ls)
            {
                f.label1.Text += "\n";
                f.label1.Text += com.getName() + "发表动态(" + com.getTime() + ")：";
                f.label1.Text += "\n";
                f.label1.Text += com.getText();
                f.label1.Text += "\n";
                f.label1.Text += "\n";
            }
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }
    }
}
