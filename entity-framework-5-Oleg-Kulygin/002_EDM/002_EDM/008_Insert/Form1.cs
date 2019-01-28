using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace _008_Insert
{
    public partial class Form1 : Form
    {
        DBEntities dbContext;

        public Form1()
        {
            InitializeComponent();
            dbContext = new DBEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbContext.PersonSet.Load();
            dataGridView1.DataSource = dbContext.PersonSet.Local.ToBindingList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var pn = new Person
                         {
                             FirstName = txtFName.Text,
                             LastName = txtLName.Text,
                             BirthDate = dateTimePicker1.Value
                         };

            dbContext.PersonSet.Add(pn);
            dbContext.SaveChanges();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var current = dataGridView1.CurrentRow.DataBoundItem as Person;
            dbContext.PersonSet.Remove(current);
            dbContext.SaveChanges();
        }        
    }
}
