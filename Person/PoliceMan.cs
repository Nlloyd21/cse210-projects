// policman class inherites person class
class Policeman : Person
{
    private string _weapons;
    public Policeman(string firstName, string lastName, int age, string weapons)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
    }
}