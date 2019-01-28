using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace _002_EDM
{
    public partial class Form1 : Form
    {
        private readonly AWEntities context;

        public Form1()
        {
            InitializeComponent();
            context = new AWEntities();
            context.Product.Load();
            dataGridView1.DataSource = context.Product.Local.ToBindingList();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            context.Dispose();
        }
    }
}
