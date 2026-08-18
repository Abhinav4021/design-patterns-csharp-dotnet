namespace Creational.Prototype;

// Concrete prototype implementing copy operations
public class EmployeeRecord : IPrototype<EmployeeRecord>
{
    public string Name { get; set; }
    public string Department { get; set; }
    public Address Location { get; set; }

    public EmployeeRecord(string name, string department, Address location)
    {
        Name = name;
        Department = department;
        Location = location;
    }

    // Shallow copy: Uses MemberwiseClone (copies reference to Location)
    public EmployeeRecord ShallowCopy()
    {
        return (EmployeeRecord)MemberwiseClone();
    }

    // Deep copy: Clones nested reference types independently
    public EmployeeRecord DeepCopy()
    {
        var clone = (EmployeeRecord)MemberwiseClone();
        clone.Location = Location.Clone();
        return clone;
    }

    public override string ToString()
    {
        return $"Name: {Name,-10} | Dept: {Department,-12} | Address: {Location.Street}, {Location.City}";
    }
}