using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_değişken_örnekleri1120
{
    public partial class Form1 : Form
    {
        //bakiye değiskenler globaldır
       
        Double bakiye = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
        bakiye = bakiye + 50;
            MessageBox.Show(bakiye.ToString());
            lblBakiye.Text = "bakiye : " + bakiye.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = "bakiye:" + bakiye.ToString();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            bakiye -= 8;
            lblBakiye.Text = "ode:" + bakiye.ToString();

        }
    }
}
