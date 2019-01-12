// Программа решает систему уравнений с помощью функций объектной
// библиотеки MS Excel
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Для подключения библиотеки объектов MS Excel в пункте меню Project
// выберем команду Add Reference. Затем в узле Assemblies выберем
// пункт Extensions, в появившемся списке отметим ссылку
// Microsoft.Office.Interop.Excel.
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ExcelСЛАУ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Escape-последовательность для переходя на новую строку:
            const String НС = "\r\n"; // Новая строка
            // Матричное уравнение AX = L решаем через
            // обратную матрицу: X = A(-1)L.
            // Здесь (-1) - "знак" обратной матрицы.
            // Решаем систему
            // X1 + X2 + X3 = 6
            // X1 + X2      = 3
            //      X2 + X3 = 5
            // Для этой системы прямая матрица будет иметь вид:
            // Массив 3 Х 3 типа Double:
            Double[,] A = {{1.0, 1,   1},
                           {1,   1,   0},
                           {0,   1,   1}};
            // Свободные члены:
            Double[] L = { 6.0, 3, 5 }; // - одномерный массив типа Double
            // Создание экземпляра класса Excel.Application:
            var XL1 = new Microsoft.Office.Interop.
                                         Excel.Application();
            // Вычисление детерминанта матрицы А
            var det_A = XL1.Application.WorksheetFunction.MDeterm(A);
            // Если det_A близок к 0, то выход из процедуры:
            if (Math.Abs(det_A) < 0.01)
            {
                label1.Text = "Система не имеет решения, поскольку" +
                                 НС + "определитель равен нулю";
                return;
            }
            // Получение обратной матрицы oA:
            var oA = XL1.Application.WorksheetFunction.MInverse(A);
            // Функция Transpose преобразует строку свободных
            // членов в вектор:
            var ВекторL = XL1.Application.WorksheetFunction.Transpose(L);
            // Умножение обратной матрицы на вектор свободных членов:
            var X = XL1.Application.WorksheetFunction.MMult(oA, ВекторL);
            // Чтобы ответ приобрел индексированные свойства,
            // преобразуем его в массив:
            var Xd = new Object[3, 1];
            Xd = X;
            // Получаем двумерный массив, индексы которого
            // начинаются с единицы:
            label1.Text = String.Format(
                         "Неизвестные равны:" + НС +
                         "X1 = {0};  X2 = {1};  X3 = {2}.",
                           Xd[1, 1], Xd[2, 1], Xd[3, 1]);
        }
    }
}
