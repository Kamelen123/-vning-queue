using System.Net.Cache;

namespace Övning_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person person = new Person()
            //{
            //    Age = 20,
            //    Name = "Test",
            // Hej
            //};
            Läkare Anton = new Läkare()
            {

                Name = "Anton",
                Age = 25,
                Salary = 45000,
                ID = 123415,
                WorkTime = 45,

            };
            Sjuksköterska torbjörn = new Sjuksköterska()
            {
                Name = "Torbjörn",
                Age = 28,
                Salary = 50000,
                ID = 343253,
                WorkTime = 40
            };
            patient Anas = new patient()
            {
                Name = "Anas",
                Age = 35,
                TimeOfReg = 10,
                sjukdom = "Covid",
                VacQue = 1,
            };
            patient Alf = new patient()
            {
                Name = "Alf",
                Age = 30,
                TimeOfReg = 11,
                sjukdom = "Covid",
                VacQue = 2,
            };
            torbjörn.BlodTest();
            Anton.SkrivaRecept();            

            Queue<patient> VacQueue = new Queue<patient>();
            VacQueue.Enqueue(Anas);
            VacQueue.Enqueue(Alf);

            patient deleted = VacQueue.Dequeue();
            Console.WriteLine(deleted.Name + " Is Deleted From Que");

            patient peekPatient = VacQueue.Peek();
            Console.WriteLine(peekPatient.Name);

            Console.WriteLine("\nPersonal : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLäkare");
            Console.ResetColor();
            Console.WriteLine("Namn : " + Anton.Name + "\nÅlder : " + Anton.Age + " \nLön: " + Anton.Salary + " \nArbetstid : " + Anton.WorkTime + " \nID: " + Anton.ID);
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("\nSjuksköterska");
            Console.ResetColor();
            Console.WriteLine("Namn : " + torbjörn.Name + " \nÅlder : " + torbjörn.Age + "\nLön : " + torbjörn.Salary + " \nArbetsid : " + torbjörn.WorkTime + "\nID : " + torbjörn.ID );

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInformation om patienter");
            Console.ResetColor();
            Console.WriteLine("Namn : " + Anas.Name + " \nSjukdom : " + Anas.sjukdom + " \nRegistrerad : " + Anas.TimeOfReg + " \nVaccinnummer : " +Anas.VacQue);
            Console.WriteLine("\nNamn : " + Alf.Name  + " \nSjukdom : " + Alf.sjukdom + "  \nRegistrerad : " + Alf.TimeOfReg + " \nVaccinnummer : " + Alf.VacQue);
            Console.ReadKey();
        }
    }
}