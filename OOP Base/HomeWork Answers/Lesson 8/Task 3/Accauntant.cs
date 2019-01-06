
namespace Task_3
{
    enum Post //перечисление
    {
        // должность и количество отработанных за месяц часов
        Manager = 195,
        Developer = 200,
        Accountant = 192,
        Secretary = 192,
        Cleaner = 192
    }

    class Accauntant
    {
        // метод считающий выдавать сотруднику премию или нет, если сотрудник отработал более 192 часов в неделю - премию выдать
        public bool AskForBonus(Post worker, int hours) //Метод предикат - метод возвращающий значений логического типа
        {
            if ((int)worker < hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
