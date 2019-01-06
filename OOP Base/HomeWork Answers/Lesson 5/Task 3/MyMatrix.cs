using System;

namespace Task_3
{
    class MyMatrix
    {
        int[][] matrix; //Создание двумерного миссива

        public MyMatrix(int n, int m) //Пользовательский конструктор принимающий два параметра целого типа
        {
            matrix = new int[Math.Abs(n)][];
            for (int i = 0; i < Math.Abs(n); i++)
                matrix[i] = new int[Math.Abs(m)];
            Fill();
        }

        public void Fill() //Метод заполнения массива рандомными значениями
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = rand.Next(10, 90);
        }

        public void ChangeSize(int row, int col) //Метод изменения размера матрицы
        {
            if (row <= 0 || col <= 0)
            {
                Console.WriteLine("Размеры матрици не могут быть меньшими или равными нулю");
                return;
            }

            var mNew = new int[row][]; //Создание неявно типизированного зубчатого массива с указанием количества строк

            for (int i = 0; i < row; i++)
                mNew[i] = new int[col]; //Создание массивов в качестве каждого элемента зубчатого массива

            for (int i = 0; i < Math.Min(matrix.Length, row); i++) //Изменение числа строк
            {
                for (int j = 0; j < Math.Min(matrix[i].Length, col); j++) //Изменение числа столбцов
                    mNew[i][j] = matrix[i][j]; 
            }

            Random rand = new Random();
            if (row > matrix.Length) //Эсли количество строк массива matrix меньше значения переменной row
            {
                for (int i = matrix.Length; i < row; i++)
                    for (int j = 0; j < Math.Min(col, matrix[0].Length); j++)
                        mNew[i][j] = rand.Next(10, 90); //то заполняем пустые строки нового массива рандомными значениями
            }

            if (col > matrix[0].Length) //Эсли количество столбцов массива matrix меньше значения переменной col
            {
                for (int i = matrix[0].Length; i < col; i++)
                    for (int j = 0; j < row; j++)
                        mNew[j][i] = rand.Next(10, 90); //то заполняем пустые столбцы нового массива рандомными значениями
            }

            matrix = mNew; //Переменной matrix присваивается ссылка на матрицу mNew
        }

        public void ShowPartly(int startRow, int startCol, int endRow, int endCol) //Метод частичного отображения матрицы. Принимает в качестве аргументов координаты начальной и конечной точки
        {
            if (startRow < 0 || startCol < 0 || endRow > matrix.Length || endCol > matrix[0].Length) //Проверка валидности полученных аргументов
            {
                Console.WriteLine("Попытка обращения за пределы массива.");
                return;
            }

            if (startRow > endRow || startCol > endCol) //Проверка размещена ли конечная точка раньше начальной
            {
                Console.WriteLine("Неверно заданы координаты конечной точки");
                return;
            }

            for (int i = startRow; i < endRow; i++)
            {
                for (int j = startCol; j < endCol; j++)
                    Console.Write("{0}  ", matrix[i][j]); //Отображение матрицы нужного размера
                Console.Write("\n");
            }

        }

        public void Show() //Метод отображения всей матрицы matrix
        {
            ShowPartly(0, 0, matrix.Length, matrix[0].Length); //Для отображения вызывается метод ShowPartly и ему передаются 4 параметра - начала и конца матрицы.
        }

        public int this[int index1, int index2] //Индексатор для матрицы
        {
            get //Аксесор - срабатывает при попытке получить значение
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length) //Проверки вхождения индексов в границы размеров массива
                    return matrix[index1][index2];
                Console.WriteLine("Попытка обращения за пределы массива.");
                return 0;
            }

            set //Мутатор - срабатывает когда индексатору пытаются присвоить значение
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                    matrix[index1][index2] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }
    }
}
