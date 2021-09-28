using System;

namespace Lesson_05
{
     class Fraction
    {

        private int numerator = 1;              // Числитель
        public int denominator;			        // Знаменатель

        public Fraction( int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("В знаменателе не может быть нуля");
            }
            else
            {
               // this.numerator = numerator;
                this.denominator = denominator;
            }
        }

        public Fraction()
        {
        }

        public override string ToString()
        {
            return this.numerator + "/" + this.denominator;
        }

        // Перегрузка оператора "+" для случая сложения двух дробей
        public static Fraction operator + (Fraction a, Fraction b)
        {
            return new Fraction()
            {
                denominator = a.denominator + b.denominator,
               
            };
        }
        // Перегрузка оператора "+" для случая сложения числа с дробью
        public static Fraction operator + (int a, Fraction b)
        {
            return new Fraction()
            {
                denominator = a + b.denominator,

            };
        }
        // Перегрузка оператора "-" для случая вычитания двух дробей
        public static Fraction operator - (Fraction a, Fraction b)
        {
            return new Fraction()
            {
                denominator = a.denominator - b.denominator,

            };
        }
        // Перегрузка оператора "-" для случая вычитания числа с дробью
        public static Fraction operator - (Fraction b, int a)
        {
            return new Fraction()
            {
                denominator =  b.denominator - a,

            };
        }
        // Перегрузка оператора "*" для случая умножения двух дробей
        public static Fraction operator * (Fraction a, Fraction b)
        {
            return new Fraction()
            {
                denominator = a.denominator * b.denominator,

            };
        }
        // Перегрузка оператора "*" для случая умножения числа с дробью
        public static Fraction operator * (Fraction b, int a)
        {
            return new Fraction()
            {
                denominator = b.denominator * a,

            };
        }
        // Перегрузка оператора "/" для случая деления двух дробей
        public static Fraction operator / (Fraction a, Fraction b)
        {
            return new Fraction()
            {
                denominator = a.denominator / b.denominator,

            };
        }
        // Перегрузка оператора "/" для случая деления числа с дробью
        public static Fraction operator / (Fraction b, int a)
        {
            return new Fraction()
            {
                denominator = b.denominator / a,

            };
        }
        // переопределить операторы (==)  (!=).
        public static bool operator == (Fraction c1, Fraction c2)
        {
            return c1.denominator == c2.denominator;
        }
        public static bool operator != (Fraction c1, Fraction c2)
        {
            return c1.denominator != c2.denominator;
        }



        //перегрузка логических операторов " > ", " < ".
        public static bool operator > (Fraction p1, Fraction p2)
        {
            return p1.denominator > p2.denominator;
        }
        public static bool operator < (Fraction p1, Fraction p2)
        {
            return !(p1.denominator < p2.denominator);
        }
        // переопределить операторы true и false.
        public static bool operator true(Fraction c1)
        {
            return c1.denominator != 0;
        }
        public static bool operator false(Fraction c1)
        {
            return c1.denominator == 0;
        }



    }
}