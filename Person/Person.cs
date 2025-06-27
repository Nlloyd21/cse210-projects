using System.Security.Cryptography;

abstract class Person
{
    private string _lastName;
    private string _firstName;
    private int _age;

    //costructor default//
    public Person()
    {
        _lastName = "";
        _firstName = "";
        _age = 0;
    }
    public Person(string lastName, string firstName, int age)
    {
        _lastName = lastName;
        _firstName = firstName;
        _age = age;

    }

    public virtual string GetPersonInformation()
    {
        return $"{_firstName}, {_lastName}, Age: {_age}";
    }
    public abstract double GetSalary();
}