using System;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
             /*
             Разработать класс Fraction, представляющий простую
              дробь.в классе предусмотреть два поля: числитель
              и знаменатель дроби. Выполнить перегрузку следу -
              ющих операторов: +,-,*,/,==,!=,<,>, true и false.
            */
            Console.WriteLine("\n DZ-4 --------------------------- ");
            Console.WriteLine("   класс Fraction ");
            Fraction a = new Fraction(3);
            Fraction a2 = new Fraction(3);

            Fraction a3 = a * a2;
            Fraction a4 = a / a2;
            Console.WriteLine(" Fraction a3 =  " + a3);
            Console.WriteLine(" Fraction a4 =  " + a4);
           
            bool result = a != a2;
            Console.WriteLine(result);



            Console.Read();
        }
    }
}
