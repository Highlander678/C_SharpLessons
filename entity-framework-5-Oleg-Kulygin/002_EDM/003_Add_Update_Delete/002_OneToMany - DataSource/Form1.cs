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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctx.Cars.Load();
            ctx.Models.Load();

            dgvCars.DataSource = ctx.Cars.Local.ToBindingList();
            dgvModel.DataSource = ctx.Models.Local
                .ToBindingList();
        }

        #endregion

        #region EventHandlers

        #region Car

            private void carAddButton_Click(object sender, EventArgs e)
            {
                try
                {
                    var car = new Car
                    {
                        Factory = txtFactory.Text,
                        Country = txtCountry.Text
                    };
                    ctx.Cars.Add(car);

                    ctx.SaveChanges();

                    LoadCars();
                    LoadModels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void carUpdateButton_Click(object sender, EventArgs e)
            {
                try
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

                    LoadCars();
                    LoadModels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void carDeleteButton_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dgvCars.CurrentRow != null)
                    {
                        var car = dgvCars.CurrentRow.DataBoundItem as Car;
                        ctx.Cars.Remove(car);
                    }
                    ctx.SaveChanges();
                    LoadCars();
                    LoadModels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    FillCarTextBoxes();
                    ClearTextBoxes(modelsGroupBox);
                    LoadModels();
                    dgvModel.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        #endregion

        #region Model

            private void modelAddButton_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dgvCars.CurrentRow == null) return;

                    var car = dgvCars.CurrentRow.DataBoundItem as Car;

                    if (car != null)
                    {
                        var model = new Model
                                        {
                                            Name = txtName.Text,
                                            Color = txtColor.Text,
                                            Engine = txtEngine.Text
                                        };

                        car.Models.Add(model);
                    }
                    ctx.SaveChanges();

                    LoadModels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void modelUpdateButton_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dgvModel.CurrentRow == null) return;

                    var model = dgvModel.CurrentRow.DataBoundItem as Model;

                    if (model == null) return;

                    model.Name = txtName.Text;
                    model.Color = txtColor.Text;
                    model.Engine = txtEngine.Text;

                    ctx.SaveChanges();

                    LoadModels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void modelDeleteButton_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dgvModel.CurrentRow != null)
                    {
                        var model = dgvModel.CurrentRow.DataBoundItem as Model;

                        if (model != null)
                        {
                            ctx.Models.Remove(model);
                            ctx.SaveChanges();
                            LoadModels();
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        #region LoadData

            public void LoadCars()
            {
                try
                {
                    dgvCars.DataSource = ctx.Cars.ToList();
                    FillCarTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void LoadModels()
            {
                try
                {
                    if (dgvCars.CurrentRow != null)
                    {
                        var currentCar = dgvCars.CurrentRow.DataBoundItem as Car;
                        if (currentCar != null) dgvModel.DataSource = currentCar.Models.ToList();
                    }

                    FillModelTextBoxes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        #endregion

        #region Helpers
        private void ClearTextBoxes(Control gBox)
        {
            foreach (var textBox in gBox.Controls.OfType<TextBox>())
                textBox.Clear();
        }
        private void FillModelTextBoxes()
        {
            if (dgvModel.CurrentRow == null) return;

            var currentModel = dgvModel.CurrentRow.DataBoundItem as Model;
            if (currentModel == null) return;

            txtName.Text = currentModel.Name;
            txtColor.Text = currentModel.Color;
            txtEngine.Text = currentModel.Engine;
        }

        private void FillCarTextBoxes()
        {
            if (dgvCars.CurrentRow == null) return;

            var car = dgvCars.CurrentRow.DataBoundItem as Car;

            if (car == null) return;

            txtFactory.Text = car.Factory;
            txtCountry.Text = car.Country;
        }
        #endregion


    }
}
