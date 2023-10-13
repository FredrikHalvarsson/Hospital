using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hospital
{
    public class Patient : Person
    {
        public Patient(string name="Inget Namn", int age=0)
            :base(name,age)
        {
            Symptom = "unknown";
        }
        public string Symptom { get; set; }
        public string Diagnosis { get; set; }
        public string Perscription { get; set; }
        public override void Print()
        {
            Console.WriteLine($"Namn: {Name}" +
                $"\nÅlder: {Age}" +
                $"\nSymptom: {Symptom}" +
                $"\nDiagnos {Diagnosis}" +
                $"\nRecept {Perscription}\n");
        }
    }
}
