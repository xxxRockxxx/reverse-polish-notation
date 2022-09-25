using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_polish_notation
{
    class Сalculator:Setings
    {
        public void Work()
        {
            string sample = Console.ReadLine();
            string Answer=FindNumbers(sample);
            Console.WriteLine(Answer);
        }
    }
}
