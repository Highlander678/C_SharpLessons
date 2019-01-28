using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace _002_OneToMany
{
    public partial class Form1 : Form
    {
        readonly OneToManyModelContainer ctx;

        #region Constructors

        public Form1()
        {
            InitializeComponent();
            ctx = new OneToManyModelContainer();
            ctx.Models.Local.CollectionChanged += Local_CollectionChanged;
        }

        void Local_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RefreshModels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctx.Cars.Load();
            ctx.Models.Load();
            dgvCars.DataSource = ctx.Cars.Local.ToBindingList();
            FillCarTextBoxes();
            RefreshModels();
        }

        #endregion

        #region EventHandlers

        #region Cars

        private void carAddButton_Click(object sender, EventArgs e)
        {
            var car = new Car
            {
                Factory = txtFactory.Text,
                Country = txtCountry.Text
            };
            ctx.Cars.Add(car);
            ctx.SaveChanges();
        }

        private void carUpdateButton_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow != null)
            {
                var car = dgvCars.CurrentRow.DataBoundItem as Car;

                if (car != null)
                {
                    car.Factory = txtFactory.Text;
                    car.Country = txtCountry.Text;
                }
            }

            ctx.SaveChanges();
            dgvCars.Refresh();

        }

        private void carDeleteButton_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow != null)
            {
                var car = dgvCars.CurrentRow.DataBoundItem as Car;
                ctx.Cars.Remove(car);
            }
            ctx.SaveChanges();
            ClearTextBoxes(carsGroupBox);
        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillCarTextBoxes();
            RefreshModels();
        }

        #endregion

        #region Models

        private void modelAddButton_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow == null) return;
            var car = dgvCars.CurrentRow.DataBoundItem as Car;
            var model = new Model
                            {
                                Name = txtName.Text,
                                Color = txtColor.Text,
                                Engine = txtEngine.Text
                            };

            car.Models.Add(model);
            ctx.SaveChanges();
        }

        private void modelUpdateButton_Click(object sender, EventArgs e)
        {
            if (dgvModel.CurrentRow == null) return;

            var model = dgvModel.CurrentRow.DataBoundItem as Model;
            model.Name = txtName.Text;
            model.Color = txtColor.Text;
            model.Engine = txtEngine.Text;

            ctx.SaveChanges();
            dgvModel.Refresh();
        }

        private void modelDeleteButton_Click(object sender, EventArgs e)
        {
            if (dgvModel.CurrentRow != null)
            {
                var model = dgvModel.CurrentRow.DataBoundItem as Model;

                if (model != null)
                {
                    ctx.Models.Remove(model);
                    ctx.SaveChanges();
                }
            }
        }

        private void dgvModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillModelTextBoxes();
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(modelsGroupBox);
            ClearTextBoxes(carsGroupBox);
        }

        #endregion

        #region Helpers
        private void ClearTextBoxes(Control gBox)
        {
            foreach (var textBox in gBox.Controls.OfType<TextBox>())
                textBox.Clear();
        }

        private void RefreshModels()
        {
            if (dgvCars.CurrentRow != null)
            {
                var currentCar = dgvCars.CurrentRow.DataBoundItem as Car;
                if (currentCar != null) dgvModel.DataSource = currentCar.Models.ToList();
            }
            FillModelTextBoxes();
        }

        private void FillModelTextBoxes()
        {
            ClearTextBoxes(modelsGroupBox);
            if (dgvModel.CurrentRow == null) return;

            var currentModel = dgvModel.CurrentRow.DataBoundItem as Model;

            txtName.Text = currentModel.Name;
            txtColor.Text = currentModel.Color;
            txtEngine.Text = currentModel.Engine;
        }

        private void FillCarTextBoxes()
        {
            ClearTextBoxes(carsGroupBox);
            if (dgvCars.CurrentRow == null) return;

            var car = dgvCars.CurrentRow.DataBoundItem as Car;
            if (car == null) return;
            txtFactory.Text = car.Factory;
            txtCountry.Text = car.Country;
        }
        #endregion


    }
}
