namespace Creational.Prototype;

// Nested reference type to illustrate the difference between shallow and deep copy
public class Address
{
    public string City { get; set; }
    public string Street { get; set; }

    public Address(string street, string city)
    {
        Street = street;
        City = city;
    }

    public Address Clone() => new(Street, City);
}