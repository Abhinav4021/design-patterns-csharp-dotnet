namespace SOLID.DependencyInversion;

public record Order(string OrderId, string CustomerEmail, decimal TotalAmount);