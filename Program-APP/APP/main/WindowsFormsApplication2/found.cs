using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class found : Form
    {
        public found()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            found2 f5 = new found2();
            f5.TopLevel = false;
            panel1.Controls.Add(f5);
            f5.Show();
        }
    }
}
