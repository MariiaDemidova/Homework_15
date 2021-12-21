using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression aProgression = new ArithProgression();
            Console.WriteLine("Введите разность прогрессии:");
            aProgression.d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество чисел прогрессии:");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое число арифметической прогрессии:");
            aProgression.setStart(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Следующее число: {0}", aProgression.getNext());
            }
            aProgression.reset();
            Console.WriteLine("Поменяйте разность:");
            aProgression.d = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Следующее число: {0}", aProgression.getNext());
            }
            GeomProgression gProgression = new GeomProgression();
            gProgression.d = aProgression.d;
            Console.WriteLine("Введите первое число геометрической прогрессии:");
            gProgression.setStart(Convert.ToInt32(Console.ReadLine()));
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Следующее число: {0}", gProgression.getNext());
            }
            gProgression.reset();
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    public class ArithProgression : ISeries
    {
        int n;
        public int d;
        int start;

        public ArithProgression ()
        {
            n = 0;
            d = 0;
            start = 0;
         }

        public void setStart(int x)
        {
            start = x;
            n = x;
        }

        public int getNext()
        {
            n += d;
            return n;
        }

        public void reset()
        {
            n = start;
            Console.WriteLine("Сброс");
        }
    }
    public class GeomProgression : ISeries
    {
        int n;
        public int d;
        int start;
        public GeomProgression()
        {
            n = 0;
            d = 0;
            start = 0;
        }

        public void setStart(int x)
        {
            start = x;
            n = x;
        }

        public int getNext()
        {
            n *= d;
            return n;
        }

        public void reset()
        {
            n = start;
            Console.WriteLine("Сброс ");
        }
    }
}
