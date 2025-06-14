// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Person myperson = new Person("Raj", "Patil", 53);

        Console.WriteLine(myperson.GetPersonInformation());

        Policeman myPoliceMan = new Policeman("Cooper", "Silver", 33, "Bat");
        Console.WriteLine(myPoliceMan.GetPersonInformation());

        Console.WriteLine(myPoliceMan.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 56, "Hammer");
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}
