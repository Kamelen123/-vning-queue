using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_queue
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

    }
     internal class Läkare : Person
    {
        public int WorkTime { get; set; }
        public int Salary { get; set; }

        public int ID { get; set; }
        public void SkrivaRecept()
        {
            Console.WriteLine("Läkaren skriver recept");
        }

    }
    internal class Sjuksköterska : Person
    {
        public int ID { get; set; }
        public int WorkTime { get; set; }
        public int Salary { get; set; }
        public void BlodTest()
        {
            Console.WriteLine("Sjuksköterskan tar blod");
        }
    }
    internal class patient : Person
    {
        public string sjukdom { get; set; }
        public int TimeOfReg { get; set; }

        public int VacQue { get; set; }

    }
}
