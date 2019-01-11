using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerialDataBase
{
    public partial class MainForm : Form
    {
        List<Car> cars = null;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();

            // ��������� ��������� �������� Car � ������
            cars = new List<Car>()
                       {
                           new Car("Siddhartha", "BMW", "Silver"),
                           new Car("Chucky", "Caravan", "Green"),
                           new Car("Fred", "Audi TT", "Red")
                       };

            // ��������� DataGrid
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            if (cars != null)
            {
                // ������� ������� DataTable � ������ Inventory
                var table = new DataTable("Inventory");

                // ������� ������� DataColumn
                var make = new DataColumn("Make");
                var name = new DataColumn("Name");
                var color = new DataColumn("Color");

                // ��������� ������� DataColumn � DataTable
                table.Columns.Add(name);
                table.Columns.Add(make);
                table.Columns.Add(color);

                // ��� ������� �������� ������� ������ � �������
                foreach (Car car in cars)
                {
                    DataRow row = table.NewRow();
                    row["Name"] = car.name;
                    row["Make"] = car.make;
                    row["Color"] = car.color;
                    table.Rows.Add(row);
                }

                // ������ DataTable � dataGridView 
                dataGridView.DataSource = table;
            }
        }

        private void makeNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FormDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                cars.Add(dialog.car);
                UpdateGrid();
            }
        }

        private void saveCarFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ����������� �������� ����������� ���� ��� ���������� ������ 
            // SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = ".";
            saveFileDialog.Filter = "car files (*.car)|*.car|All files(*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "carDoc";

            // ��������� ������� �����������
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = saveFileDialog.OpenFile();

                var serializer = new BinaryFormatter();
                serializer.Serialize(myStream, cars);
                myStream.Close();

            }
        }

        private void openCarFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ����������� �������� ����������� ���� ��� �������� ������ 		
            openFileDialog.InitialDirectory = ".";
            openFileDialog.Filter = "car files (*.car)|*.car|All files(*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            // ��������������� ������� �����������
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // ������� ������� ������
                cars.Clear();

                Stream stream = openFileDialog.OpenFile();
                var deserializer = new BinaryFormatter();
                cars = deserializer.Deserialize(stream) as List<Car>;
                stream.Close();
                UpdateGrid();

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearAllCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cars.Clear();
            UpdateGrid();
        }
    }
}