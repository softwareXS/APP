using System;
using System.Windows.Forms;
using dictionary;
using dao;
namespace version
{
    public partial class dic : Form
    {
        private user user;
        private Dictionary dictionary;
        private IDicDao idicDao = new DicDao();
        public dic()
        {
            InitializeComponent();
        }

        public dic(user user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                user.last_word4Add();
                dictionary = idicDao.get(user.getLast_Word4());
                groupBox1.Text = dictionary.getWord() + "(" + dictionary.getPro().Trim() + ")";
                groupBox2.Text = dictionary.getMeans();
            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dictionary = idicDao.get(user.getLast_Word4());
            //groupBox1.Text = "insert into new_word (n_word,n_mean,n_pro,u_id) values('" + dictionary.getWord() + "','" + dictionary.getMeans() + "','" + dictionary.getPro() + "'," + user.getU_id() + ")";
            if (0 != DAO.ExeSql("insert into new_word (n_word,n_mean,n_pro,u_id) values('" + dictionary.getWord() + "','" + dictionary.getMeans() + "','" + dictionary.getPro() + "'," + user.getU_id() + ")"))
            {
                MessageBox.Show("成功添加进生词本！");
            }
            else
            {
                MessageBox.Show("该单词已被添加进生词本，不能重复添加！");
            }
            //MessageBox.Show("insert into new_word (n_word,n_mean,n_pro,u_id) values('" + dictionary.getWord() + "','" + dictionary.getMeans() + "','" + dictionary.getPro() + "'," + user.getU_id() + "))");
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.getLast_Word4() > 1)
                {
                    user.last_word4Sub();
                    dictionary = idicDao.get(user.getLast_Word4());
                    groupBox1.Text = dictionary.getWord() + "(" + dictionary.getPro().Trim() + ")";
                    groupBox2.Text = dictionary.getMeans();
                }
            }
            catch
            {

            }
            
        }
    }
}

