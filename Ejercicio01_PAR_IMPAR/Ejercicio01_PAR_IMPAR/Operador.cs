using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_PAR_IMPAR
{
    public class Operador
    {
        public Operador()
        {
            Console.WriteLine("Enter a num1: ");
            string number = Console.ReadLine();
            int.TryParse(number, out int num);

            num = CheckNum(num);
      
        }

        private int CheckNum(int num)
        {
            if (num <= 1)
            {
                throw new numexception("invalid num");
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("the fucking number " + num + " is even");
                return num;
            }
            else
            {
                Console.WriteLine("the fucking number " + num + " is uneven");
                return num;
            }

        }

    }
}
