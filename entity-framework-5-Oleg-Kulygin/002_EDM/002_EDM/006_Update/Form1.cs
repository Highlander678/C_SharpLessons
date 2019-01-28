using System;
using System.Linq;
using System.Windows.Forms;

namespace _006_Update
{
    public partial class Form1 : Form
    {
        readonly AWEntities db;

        public Form1()
        {
            InitializeComponent();
            db = new AWEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customer.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
