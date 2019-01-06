using System;

namespace Lessons_16
{
    class Calculator
    {
        //Методы возвращающие результаты арифлетических операций
        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public int Sub(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        public int Mul(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        public int? Div(int operand1, int operand2) //Возвращаемое знеачение может быть пустим по этому в типе возвращаемого знаначения указано int?
        {
            try //Выделаем опасный код в блок try
            {
                return operand1 / operand2;
            }
            catch (Exception e) //Обработка исключений которые могут быть сгенерированы в блоке try
            {
                Console.WriteLine("Обработка исключения.");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
