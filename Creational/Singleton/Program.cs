using Creational.Singleton;

Console.WriteLine("=== Modern Singleton Demo (Lazy<T>) ===\n");

// Simulate multi-threaded access to prove thread safety
Parallel.Invoke(
    () => Singleton.Instance.ExecuteTask("Thread 1 - Fetch Users"),
    () => Singleton.Instance.ExecuteTask("Thread 2 - Update Inventory"),
    () => Singleton.Instance.ExecuteTask("Thread 3 - Process Payment")
);

// Verify equality
var instanceA = Singleton.Instance;
var instanceB = Singleton.Instance;

Console.WriteLine($"\nAre instanceA and instanceB the exact same object? {ReferenceEquals(instanceA, instanceB)}");