namespace Hospital
{
    internal class Program
    {
        static void Main()
        {

            Doctor Johan = new Doctor("Johan", 40, 50000);
            Nurse berit = new Nurse("berit",30, 30000, "natt");
            Patient erik = new Patient("erik", 20);

            Johan.Print();
            berit.Print();
            erik.Print();

            Johan.SetDiagnosis(erik);

            berit.TakeBloodTest(erik);

            Johan.SetDiagnosis(erik);
            Johan.WritePerscription(erik);

            erik.Print();   
        }
    }
}