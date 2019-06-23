using System;
using System.Data;
using System.Windows.Forms;
using dao;
using dictionary;

namespace version
{
    public partial class login : Form
    {
        private IDicDao idicDao = new DicDao();
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u = username.Text;
            string p = password.Text;
            string sql = "select * from users where username='" + u + "' and password='" + p+"'";
            DataSet ds = DAO.Qurry(sql);
            DataTable dbl = ds.Tables[0];
            if (ds.Tables.Count == 1 && ds.Tables[0].Rows.Count == 0)
            { 
                MessageBox.Show("输入的用户名或密码错误！");
            }
            else
            {
                DataRow dr = dbl.Rows[0];
                user user = new user();
                user.setU_id(long.Parse(dr["u_id"].ToString()));
                user.setName(dr["name"].ToString());
                user.setLast_Word4(long.Parse(dr["last_word4"].ToString()));
                if (dr["last_word6"].ToString() !="")
                {
                    user.setLast_Word6(long.Parse(dr["last_word6"].ToString()));
                }
                else
                {
                    user.setLast_Word6(1);
                }
                if (dr["last_word4"].ToString() != "")
                {
                    user.setLast_Word4(long.Parse(dr["last_word4"].ToString()));
                }
                else
                {
                    user.setLast_Word4(1);
                }
                this.Hide();
                start s = new start(user);
                s.label2.Text = user.getName();
                dic f2 = new dic(user);
                f2.TopLevel = false;
                s.panel1.Controls.Clear();
                Dictionary dictionary = idicDao.get(user.getLast_Word4());
                f2.groupBox1.Text = dictionary.getWord() + "(" + dictionary.getPro().Trim() + ")";
                f2.groupBox2.Text = dictionary.getMeans();
                s.panel1.Controls.Add(f2);
                f2.Show();
                s.ShowDialog();
                //MessageBox.Show(user.tostring());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.ShowDialog();
        }
    }
}
