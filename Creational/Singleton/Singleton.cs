namespace Creational.Singleton;

// 'sealed' prevents inheritance, which is crucial for a strict Singleton
public sealed class Singleton
{
    // Lazy<T> ensures thread-safe, deferred instantiation by default
    private static readonly Lazy<Singleton> _instance =
        new(() => new Singleton());

    // Public property provides access to the instance, replacing the GetInstance() method
    public static Singleton Instance => _instance.Value;

    public Guid SessionId { get; }

    // Private constructor prevents external instantiation
    private Singleton()
    {
        SessionId = Guid.NewGuid();
        Console.WriteLine($"[Singleton] Initialized with Session ID: {SessionId}");
    }

    public void ExecuteTask(string taskName)
    {
        Console.WriteLine($"[Singleton] Executing '{taskName}' on Session: {SessionId}");
    }
}