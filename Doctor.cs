using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital
{
    public class Doctor : Person
    {
        public Doctor(string name,int age, int salary)
            :base(name,age)
        {
            Salary = salary;
            Profession = "Doctor";
        }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public void SetDiagnosis(Patient tempPatient)
        {
            
            if (tempPatient.Symptom == "unknown")
            {
                Console.WriteLine($"\n{tempPatient.Name}'s symptom är {tempPatient.Symptom}\n" +
                    $"vi behöver ta ett blodprov\n");
            }
            else
            {
                switch (tempPatient.Symptom)
                {
                    case "feber":
                        tempPatient.Diagnosis = "Sjuk";
                        Console.WriteLine($"\n{tempPatient.Name} har {tempPatient.Symptom} och är {tempPatient.Diagnosis}\n");
                        break;
                    case "ingen feber":
                        tempPatient.Diagnosis = "Frisk";
                        Console.WriteLine($"\n{tempPatient.Name} har {tempPatient.Symptom} och är {tempPatient.Diagnosis}\n");
                        break;
                }
            }
            
        }
        public void WritePerscription(Patient tempPatient)
        {
            if (tempPatient.Diagnosis == "Sjuk")
            {
                tempPatient.Perscription = "Alvedon";
            }
            else { tempPatient.Perscription = "Inget recept"; }
            Console.WriteLine($"\n{tempPatient.Name} får recept på {tempPatient.Perscription}\n");
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
