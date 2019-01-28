using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace _001_OneToOne
{
    public partial class Form1 : Form
    {
        OneToOneModelContainer ctx;

        public Form1()
        {
            InitializeComponent();
            ctx = new OneToOneModelContainer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            #region Set Columns width

            dgvEmployee.Columns[0].Width = 30;
            dgvEmployee.Columns[1].Width = 78;
            dgvEmployee.Columns[2].Width = 75;

            dgvEmployee.Columns[3].Width = 78;
            dgvEmployee.Columns[4].Width = 80;
            dgvEmployee.Columns[5].Width = 100;

            #endregion
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var emp = new Employee
                          {
                              FirstName = txtFName.Text, 
                              LastName = txtLName.Text,
                              Age = txtAge.Text,
                              Gender = txtGender.Text,
                              Phone = txtPhone.Text
                          };
            ctx.Employee.Add(emp);

            ctx.SaveChanges();
        }

        private void LoadData()
        {
            ctx.Employee.Load();
            dgvEmployee.DataSource = ctx.Employee.Local.ToBindingList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var emp = dgvEmployee.CurrentRow.DataBoundItem as Employee;
            ctx.Employee.Remove(emp);
            ctx.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var emp = dgvEmployee.CurrentRow.DataBoundItem as Employee;

            emp.FirstName = txtFName.Text;
            emp.LastName = txtLName.Text;
            emp.Age = txtAge.Text;
            emp.Gender = txtGender.Text;
            emp.Phone = txtPhone.Text;

            ctx.SaveChanges();
            dgvEmployee.Refresh();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                LoadTextBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtAge.Clear();
            txtGender.Clear();
            txtPhone.Clear();
        }

        //TODO Что Вам не нравится в этом методе?
        private void LoadTextBox()
        {
            var employee = dgvEmployee.CurrentRow.DataBoundItem as Employee;
            if (employee == null)
                return;

            txtFName.Text = employee.FirstName;
            txtLName.Text = employee.LastName;
            txtAge.Text = employee.Age;
            txtGender.Text = employee.Gender;
            txtPhone.Text = employee.Phone;
        }
    }
}