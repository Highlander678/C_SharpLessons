// Программа строит диаграмму (график) используя объекты
// компонентной библиотеки MS Excel
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Для подключения библиотеки объектов MS Excel в пункте меню Project
// выберем команду Add Reference. Затем в узле Assemblies выберем
// пункт Extensions, в появившемся списке отметим ссылку
// Microsoft.Office.Interop.Excel.
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Чтобы обеспечить более компактные выражения в программном
// коде вставим вставим следующую директиву:
using Microsoft.Office.Interop.Excel;
namespace ExcelГрафик
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Excel.Application:
            var XL1 = new Application();
            XL1.Visible = true;
            // Задаем параметр "по умолчанию" для его дальнейшего
            // использования в соответствующих методах:
            var t = Type.Missing;
            // Создаем новую книгу MS Excel:
            var Книга = XL1.Workbooks.Add(t);
            // Объявляем листы в книге: 
            var Листы = Книга.Worksheets;
            // Выбираем первый лист:
            Worksheet Лист = Листы.Item[1];
            // Записываем данные по продажам в соответствующих ячейках:
            Лист.Range["A1", t].Value2 = "Месяцы";
            Лист.Range["A2", t].Value2 = "Март";
            Лист.Range["A3", t].Value2 = "Апр";
            Лист.Range["A4", t].Value2 = "Май";
            Лист.Range["A5", t].Value2 = "Июнь";
            Лист.Range["A6", t].Value2 = "Июль";
            Лист.Range["B1", t].Value2 = "Продажи";
            Лист.Range["B2", t].Value2 = 138;
            Лист.Range["B3", t].Value2 = 85;
            Лист.Range["B4", t].Value2 = 107;
            Лист.Range["B5", t].Value2 = 56;
            Лист.Range["B6", t].Value2 = 34;
            // Заказываем построение диаграммы (графика) с 
            // умалчиваемыми параметрами
            Chart График = XL1.Charts.Add(t, t, t, t);
            // Задаем диапазон значений для построения графика:
            График.SetSourceData(Лист.Range["A2", "B6"], 
                                           XlRowCol.xlColumns);
            // Задаем тип графика "столбиковая диаграмма" (гистограмма):
            График.ChartType = XlChartType.xlColumnClustered;
            // Отключаем легенду графика:
            График.HasLegend = false;
            // График имеет заголовок:
            График.HasTitle = true;
            График.ChartTitle.Caption = "ПРОДАЖИ ЗА ПЯТЬ МЕСЯЦЕВ";
            // Подпись оси X:
            Axis ГоризонтальнаяОсь = График.Axes(
                         XlAxisType.xlCategory, XlAxisGroup.xlPrimary);
            ГоризонтальнаяОсь.HasTitle = true;
            ГоризонтальнаяОсь.AxisTitle.Text = "Месяцы";
            // Подпись оси Y:
            Axis ВертикальнаяОсь = График.Axes(
                            XlAxisType.xlValue, XlAxisGroup.xlPrimary);
            ВертикальнаяОсь.HasTitle = true;
            ВертикальнаяОсь.AxisTitle.Text = "Уровни продаж";
            // Сохранение графика в растровом файле:
            // XL1.ActiveChart.Export(@"D:\ExcelГрафик.jpg", t, t);
        }
    }
}
