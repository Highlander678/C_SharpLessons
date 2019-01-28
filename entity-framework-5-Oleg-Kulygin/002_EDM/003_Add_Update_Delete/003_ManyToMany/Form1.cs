using System;
using System.Linq;
using System.Windows.Forms;

namespace _003_ManyToMany
{
    public partial class Form1 : Form
    {
        readonly ManyToManyModelContainer context;

        public Form1()
        {
            InitializeComponent();
            context = new ManyToManyModelContainer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadCourses();

            #region Set Columns width

            dgvStudents.Columns[0].Width = 25;
            dgvStudents.Columns[1].Width = 88;
            dgvStudents.Columns[2].Width = 88;
            dgvCourses.Columns[0].Width = 25;
            dgvCourses.Columns[1].Width = 160;

            #endregion

        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = context.Students.ToList();
        }

        private void LoadCourses()
        {
            dgvCourses.DataSource = context.Courses.ToList();
        }

        //Добавление 3х новых студентов и 3 новых курса.
        private void btnRun_Click(object sender, EventArgs e)
        {
            var student1 = new Student { FirstName = "Александр", LastName = "Гофман" };
            var student2 = new Student { FirstName = "Алексей", LastName = "Иванов" };
            var student3 = new Student { FirstName = "Василий", LastName = "Петрук" };

            var course1 = new Course { Name = "WCF" };
            var course2 = new Course { Name = "WPF" };
            var course3 = new Course { Name = "JavaScript" };

            student1.Courses.Add(course1);
            student1.Courses.Add(course2);

            student2.Courses.Add(course3);
            student2.Courses.Add(course2);

            student3.Courses.Add(course1);
            student3.Courses.Add(course3);

            context.Students.Add(student1);
            context.Students.Add(student2);
            context.Students.Add(student3);

            context.SaveChanges();

            LoadCourses();
            LoadStudents();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCourses.ClearSelection();

            if (dgvStudents.CurrentRow != null)
            {
                var studentCources = ((Student)dgvStudents.CurrentRow.DataBoundItem)
                    .Courses;

                var studentCourcesRows = from DataGridViewRow row in dgvCourses.Rows
                                         let cource = row.DataBoundItem as Course
                                         where studentCources.Contains(cource)
                                         select row;

                foreach (DataGridViewRow row in studentCourcesRows)
                    row.Selected = true;
            }
        }


        //TODO Дома: Переписать без этого ужаса! (по аналогии с методом dgvStudents_CellClick
        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvStudents.ClearSelection();

            int courseId = (int)dgvCourses.CurrentRow.Cells["Id"].Value;

            var query = context.Students.Where(s => s.Courses.Any(c => c.Id == courseId));

            for (int i = 0; i < dgvStudents.Rows.Count; i++)
            {
                foreach (var item in query)
                {
                    if (dgvStudents.Rows[i].Cells[0].Value.ToString() == item.Id.ToString())
                    {
                        dgvStudents.Rows[i].Selected = true;
                    }
                }
            }
        }
    }
}
