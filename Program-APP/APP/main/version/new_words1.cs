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
    public partial class new_words1 : Form
    {
        private user user;

        public new_words1(user user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete d = new delete(user,label1);
            d.ShowDialog();
        }
    }
}
