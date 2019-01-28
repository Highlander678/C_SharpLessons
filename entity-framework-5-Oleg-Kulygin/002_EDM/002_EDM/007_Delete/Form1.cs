using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace _007_Delete
{
    public partial class Form1 : Form
    {
        readonly AWEntities context;

        public Form1()
        {
            InitializeComponent();
            context = new AWEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Customer.Load();
            UpdateDataGridView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var customer = dataGridView1.SelectedRows[0].DataBoundItem as Customer;
          
            context.Customer.Remove(customer);
            context.SaveChanges();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = context.Customer.Local.ToBindingList();
        }
    }
}
