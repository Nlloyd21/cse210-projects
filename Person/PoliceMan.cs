// policman class inherites person class
class Policeman : Person
{
    private string _weapons;
    private int _hoursWorked;
    private double _hourlyWage;
    public Policeman(string firstName, string lastName, int age, string weapons, int hours, double hourlyWage)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
        _hoursWorked = hours;
        _hourlyWage = hourlyWage;

    }
    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} : : {GetPersonInformation()}";
    }
    public override string GetPersonInformation()
    {
        return $"Weapons : {_weapons} : : {base.GetPersonInformation()}";
    }
    public override double GetSalary()
    {
        double pay = _hoursWorked * _hourlyWage;
        if (_hoursWorked > 40)
        {
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }
        return pay;
    } 

}