// Программа для решения системы линейных уравнений. Ввод коэффициентов
// предусмотрен через DataGridView
using System;
using System.Data; // - для DataGridView
using System.Windows.Forms;
// Добавим директиву Globalization:
using System.Globalization;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ГауссGrid
{
    public partial class Form1 : Form
    {
        // Данные переменные объявляем вне всех процедур, чтобы
        // они были видны из любой из процедур:
        int n; // - размерность СЛАУ
        DataTable Таблица;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Решение системы уравнений";
            // Чтобы при старте программы фокус находился в текстовом поле:
            textBox1.TabIndex = 0;
            dataGridView1.Visible = false; // сетку данных пока не видно
            label1.Text = "Ведите количество неизвестных:";
            button1.Text = "Ввести"; // - первоначальная надпись на кнопке
            Таблица = new DataTable();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            // Матрица коэффициентов линейных уравнений:
            Double[,] A;
            // Вектор свободных членов:
            Double[] L;
            // Признак ввода числовых данных:
            var Число_ли = false;
            var tmp = "временная рабочая переменная";
            if (button1.Text == "Ввести")
                for (; ; )
                {
                    // Бесконечный цикл, пока пользователь не введет
                    // именно число:
                    Число_ли = int.TryParse(textBox1.Text,
                                            NumberStyles.Integer,
                                            NumberFormatInfo.CurrentInfo,
                                            out n);
                    if (Число_ли == false) return;
                    // Задаем другую надпись на кнопке:
                    button1.Text = "Решить";
                    // Теперь уже текстовое поле недоступно:
                    textBox1.Enabled = false;
                    // Теперь уже сетку данных видно:
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = Таблица;
                    // Создаем "шапку" таблицы
                    for (i = 1; i <= n; i++)
                    {
                        tmp = "X" + Convert.ToString(i);
                        Таблица.Columns.Add(new DataColumn(tmp));
                    }
                    // Колонка правой части системы:
                    Таблица.Columns.Add(new DataColumn("L"));
                    return;
                } // - конец тела вечного цикла
            else  // - button1.Text = "Решить"
            {   // Нажали кнопку "Решить"
                // Таблица.Rows.Count - количество рядов
                if (Таблица.Rows.Count != n)
                {
                    MessageBox.Show(
                        "Количество строк не равно количеству колонок");
                    return;
                }
                // Теперь можем определиться с размерностью массивов:
                // Матрица коэффициентов линейных уравнений:
                A = new Double[n, n];
                // Вектор свободных членов:
                L = new Double[n];
                // Заполнение матрицы коэффициентов системы A[j, i]
                for (j = 0; j <= n - 1; j++)
                {
                    for (i = 0; i <= n - 1; i++)
                    {
                        A[j, i] = ВернутьЧисло(j, i, ref Число_ли);
                        if (Число_ли == false) return;
                    } // - конец тела внутреннего цикла по i
                    // Правая часть системы B[j, 0]
                    L[j] = ВернутьЧисло(j, i, ref Число_ли);
                    if (Число_ли == false) return;
                } // - конец тела внешнего цикла по j
            } // - button1.Text = "Решить"
            // ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ 
            // Решение системы A*x = L методом Гаусса:
            gauss(n, A, ref L);
            // L - вектор свободных членов системы, сюда
            // же возвращается решение x
            var s = "Неизвестные равны:\n";
            for (j = 1; j <= n; j++)
            {
                tmp = L[j - 1].ToString();
                s = s + "X" + j.ToString() + " = " + tmp + ";\n";
            } // - конец цикла по j
            MessageBox.Show(s);
        }
        Double ВернутьЧисло(int j, int i,
                                   ref Boolean Число_ли)
        {
            // j - номер строки, i - номер столбца
            // Передаем аргумент Число_ли по ссылке
            Double rab; // - рабочая переменная
            var tmp = Таблица.Rows[j][i].ToString();
            Число_ли = Double.TryParse(tmp,
                       NumberStyles.Number,
                       NumberFormatInfo.CurrentInfo,
                       out rab);
            if (Число_ли == false)
            {
                tmp = String.Format("Номер строки {0}, номер столбца " +
                    "{1}," + "\n в данном поле - не число", j + 1, i + 1);
                MessageBox.Show(tmp);
            }
            return rab;
        }
        void gauss(int n, double[,] A, ref double[] LL)
        {
            // n  - размер матрицы
            // A  - матрица коэффициентов линейных уравнений
            // LL - правая часть, сюда же возвращаются значения неизвестных
            int i, j, l = 0;
            Double c1, c2, c3;
            for (i = 0; i <= n - 1; i++) // Цикл по элементам строки
            {
                c1 = 0;
                for (j = i; j <= n - 1; j++)
                {
                    c2 = A[j, i];
                    if (Math.Abs(c2) > Math.Abs(c1))
                    {
                        l = j; c1 = c2;
                    }
                }

                for (j = i; j <= n - 1; j++)
                {
                    c3 = A[l, j] / c1;
                    A[l, j] = A[i, j]; A[i, j] = c3;
                } // j

                c3 = LL[l] / c1; LL[l] = LL[i]; LL[i] = c3;

                for (j = 0; j <= n - 1; j++)
                {
                    if (j == i) continue;
                    for (l = i + 1; l <= n - 1; l++)
                    {
                        A[j, l] = A[j, l] - A[i, l] * A[j, i];
                    } // l
                    LL[j] = LL[j] - LL[i] * A[j, i];
                } // j
            } // i
        }
    }
}
