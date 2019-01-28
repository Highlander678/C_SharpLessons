using System;
using System.Linq;
using System.Windows.Forms;

namespace _004_EDM_SP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AWEntities())
            {

                dataGridView1.DataSource = db.GetCustomers().ToList();
            }
        }
    }
}
