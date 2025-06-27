// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        // Person myperson = new Person("Raj", "Patil", 53);

        // Console.WriteLine(myperson.GetPersonInformation());

        Policeman myPoliceMan = new Policeman("Cooper", "Silver", 33, "Bat", 56, 87);
        // Console.WriteLine(myPoliceMan.GetPersonInformation());

        // Console.WriteLine(myPoliceMan.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 56, "Hammer", 450000);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myperson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceMan);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }

    private static void DisplayPersonInformation(Person person)
    {
        
        Console.WriteLine(person.GetPersonInformation());
        Console.Write($"    Salary: {person.GetSalary()}");
    }
}
