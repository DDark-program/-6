using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_2
{
    public class Pair
    {
        /// <summary>
        /// Поля данных
        /// </summary>
        private int _firstNumber;
        private int _secondNumber;

        /// <summary>
        /// Присваивание значения полям
        /// </summary>
        /// <param name="oneNumber">Первое число</param>
        /// <param name="twoNumber">Второе число</param>

        public Pair(int oneNumber, int twoNumber)
        {
            _firstNumber = oneNumber;
            _secondNumber = twoNumber;
        }

        /// <summary>
        /// Свойства первого числа
        /// </summary>

        public int First
        {
            get => _firstNumber;
            set => _firstNumber = value;
        }

        /// <summary>
        /// Свойства второго числа
        /// </summary>

        public int Second
        {
            get => _secondNumber;
            set => _secondNumber = value;
        }

        /// <summary>
        /// Метод класса Pair "Сложение полей чисел"
        /// </summary>
        /// <returns>Вывод суммы первого числа со вторым</returns>

        public int Sum(int part)
        {
            return _firstNumber + _secondNumber - part;
        }

        /// <summary>
        /// Метод класса Pair "Сложение пар чисел"
        /// </summary>
        /// <param name="firstPair">Первая пара чисел</param>
        /// <param name="secondPair">Вторая пара чисел</param>
        /// <returns>Вывод суммы 1 числа 1 пары с 1 числом 2 пары и 2 числа 1 пары со 2 числом 2 пары</returns>

        public static Pair SumPair(Pair firstPair, Pair secondPair)
        {
            return new Pair(firstPair.First + secondPair.First, firstPair.Second + secondPair.Second);
        }
    }
}