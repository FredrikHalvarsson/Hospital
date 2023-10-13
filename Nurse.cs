using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Nurse : Person 
    {
        public Nurse(string name,int age, int salary =0, string shift="Dag")
            :base(name, age)
        {
            Profession = "Nurse";
            Salary = salary;
            Shift = shift;
        }
        public string Profession { get; set; }
        public int Salary { get; set; }
        public string Shift { get; set; }

        public void TakeBloodTest(Patient tempPatient)
        {
            Random rand = new Random();
            int x = rand.Next(0, 2);
            switch (x)
            {
                case 0:
                    tempPatient.Symptom = "feber";
                    break;
                case 1:
                    tempPatient.Symptom = "ingen feber";
                    break;
            }
            Console.WriteLine($"\n{tempPatient.Name}s blodprov gav resultatet {tempPatient.Symptom}\n");

        }
        public override void Print()
        {
            Console.WriteLine($"Namn: {Name}" +
                $"\nÅlder: {Age}" +
                $"\nYrke: {Profession}" +
                $"\nLön: {Salary}\n");
        }
    }
}
