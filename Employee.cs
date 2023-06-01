
internal class Employee
{


    private string _fullName;
    private int _department;
    private double _salary;
    public int _id;
        static public int counter = 0;

   
    public Employee(string fullName, int department, double salary)
    {
        _fullName = fullName;
        _department = department;
        _salary = salary;

        _id = ++counter;
    }
    
    public string FullName
    {
        get => _fullName;
        set => _fullName = value;
    }
    public int Department
    {
        get => _department;
        set => _department = value;
    }
    public double Salary
    {
        get => _salary; 
        set => _salary = value;
    }
}
          

