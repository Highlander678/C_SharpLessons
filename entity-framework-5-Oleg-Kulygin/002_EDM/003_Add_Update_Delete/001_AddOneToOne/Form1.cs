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

            dgvEmployeeInf.Columns[0].Width = 30;
            dgvEmployeeInf.Columns[1].Width = 78;
            dgvEmployeeInf.Columns[2].Width = 80;
            dgvEmployeeInf.Columns[3].Width = 100;

            #endregion
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var emp = new Employee
                          {
                              FirstName = txtFName.Text, 
                              LastName = txtLName.Text,
                          };

            var empInf = new EmployeeInf
                             {
                                 Age = txtAge.Text, 
                                 Gender = txtGender.Text, 
                                 Phone = txtPhone.Text
                             };

            emp.EmployeeInf = empInf;
            ctx.Employee.Add(emp);

            ctx.SaveChanges();
        }

        private void LoadData()
        {
            ctx.Employee.Load();
            ctx.EmployeeInf.Load();

            dgvEmployee.DataSource = ctx.Employee.Local.ToBindingList();
            dgvEmployeeInf.DataSource = ctx.EmployeeInf.Local.ToBindingList();
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

            EmployeeInf empInf = emp.EmployeeInf;

            empInf.Age = txtAge.Text;
            empInf.Gender = txtGender.Text;
            empInf.Phone = txtPhone.Text;

            ctx.SaveChanges();
            dgvEmployee.Refresh();
            dgvEmployeeInf.Refresh();

        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvEmployeeInf.ClearSelection();
                dgvEmployeeInf.Rows[dgvEmployee.CurrentRow.Index].Selected = true;
                dgvEmployeeInf.CurrentCell = dgvEmployeeInf.SelectedRows[0].Cells[0];
        
                LoadTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmployeeInf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEmployee.ClearSelection();
            dgvEmployee.Rows[dgvEmployeeInf.CurrentRow.Index].Selected = true;
            dgvEmployee.CurrentCell = dgvEmployee.SelectedRows[0].Cells[0];

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
            txtFName.Text = dgvEmployee.CurrentRow.Cells["FirstName"].Value.ToString();
            txtLName.Text = dgvEmployee.CurrentRow.Cells["LastName"].Value.ToString();
            txtAge.Text = dgvEmployeeInf.CurrentRow.Cells["Age"].Value.ToString();
            txtGender.Text = dgvEmployeeInf.CurrentRow.Cells["Gender"].Value.ToString();
            txtPhone.Text = dgvEmployeeInf.CurrentRow.Cells["Phone"].Value.ToString();
        }
    }
}