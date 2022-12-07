using Students2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students2.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainManager.Instance.Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entities.MainManager.Instance.Cstmrs.LoadCustomers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entities.MainManager.Instance.Cstmrs.insertNewCustomer(textBox1.Text,textBox2.Text, Convert.ToInt32(textBox3.Text));

            Entities.MainManager.Instance.Cstmrs.LoadCustomers();
        }
    }
}
