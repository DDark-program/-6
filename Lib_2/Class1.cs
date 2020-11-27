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
        /// Операция инкремента 
        /// </summary>
        /// <returns></returns>
        public static Pair operator --(Pair firstpair)
        {
            return new Pair(--firstpair.First,--firstpair.Second);
        }

        /// <summary>
        /// Операция сложения пары чисел
        /// </summary>
        /// <param name="firstpair"></param>
        /// <param name="secondpair"></param>
        /// <returns></returns>

        public static Pair operator +(Pair firstpair, Pair secondpair)
        {
            return new Pair(firstpair.First + secondpair.First, firstpair.Second + secondpair.Second);
        }
    }
}