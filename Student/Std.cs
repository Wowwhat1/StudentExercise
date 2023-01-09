namespace Student;

public class Std:Object
{
    private int _age;
    public int Age
    {
        get => _age; 
        set {
            if (_age < 0)
            {
                Console.WriteLine("Age must be greater than 0");
                _age = 0;
            }
            else
            {
                _age = value;
            }
        }
    }
    private double _gpa;
    public double Gpa
    {
        get => _gpa; 
        set {
            if (_gpa <= 0 || _gpa >= 4)
            {
                Console.WriteLine("GPA must be greater than 0 and smaller than 4");
                _gpa = 0;
            }
            else
            {
                _gpa = value;
            }
        }
    }
    private string _name;
    public string Name { get; set; }
    
    public Std() {}

    public Std(int age, double gpa, string name)
    {
        _age = age;
        _gpa = gpa;
        _name = name;
    }

    public override string ToString()
    {
        return $"This is {_name} {_age} years old, have gpa {_gpa}.";
    }
}