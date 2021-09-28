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
            /*
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
            */
            string str;
           
            Fraction n = new Fraction(5);
           // Console.WriteLine(k);
            Console.WriteLine(n);
            
            Console.WriteLine("Введите знаминатель ");
            str = Console.ReadLine();
            Fraction k = new Fraction();

            k.denominator = Convert.ToInt32(str);
            
            Console.WriteLine(k);

            Console.WriteLine("----------------------------------\n");
            Console.WriteLine(" --- Дроби --- ");
            Console.WriteLine(" Введите знаминатель ");
            int Cont = 3;
            /*

           // int[] Fraction arr = new Fraction arr[Cont];

             for (int i = 0; i < fraction.Length; i++)
            {
                
                Console.Write("{0}-е дробь : ", i + 1);
                fraction[i] = (Console.ReadLine());
            }
            */






            Console.Read();
        }
    }
}
