using Creational.Prototype;

Console.WriteLine("=== Prototype Pattern: Shallow vs Deep Copy Demo ===\n");

// 1. Original prototype instance
var originalEmployee = new EmployeeRecord(
    "Alice",
    "Engineering",
    new Address("100 Innovation Way", "Bengaluru")
);

Console.WriteLine("[Original Before Modification]");
Console.WriteLine($"Original: {originalEmployee}\n");

// 2. Perform Shallow Copy and modify nested address
var shallowClone = originalEmployee.ShallowCopy();
shallowClone.Name = "Bob";
shallowClone.Location.City = "Hyderabad"; // Modifying nested address impacts the original!

Console.WriteLine("[After Shallow Copy Modified ('Bob' changed city to 'Hyderabad')]");
Console.WriteLine($"Original:     {originalEmployee}");
Console.WriteLine($"ShallowClone: {shallowClone}");
Console.WriteLine($"ReferenceEquals Address: {ReferenceEquals(originalEmployee.Location, shallowClone.Location)}");
Console.WriteLine(new string('-', 75));

// 3. Perform Deep Copy and modify nested address
var deepClone = originalEmployee.DeepCopy();
deepClone.Name = "Charlie";
deepClone.Location.City = "Pune"; // Modifying nested address does NOT impact the original

Console.WriteLine("\n[After Deep Copy Modified ('Charlie' changed city to 'Pune')]");
Console.WriteLine($"Original:   {originalEmployee}");
Console.WriteLine($"DeepClone:  {deepClone}");
Console.WriteLine($"ReferenceEquals Address: {ReferenceEquals(originalEmployee.Location, deepClone.Location)}");