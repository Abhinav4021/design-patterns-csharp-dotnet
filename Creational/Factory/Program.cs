using Creational.Factory.Creators;

Console.WriteLine("========================================");
Console.WriteLine("         FACTORY METHOD PATTERN");
Console.WriteLine("========================================");


// --------------------------------------------------
// EMAIL NOTIFICATION
// --------------------------------------------------

Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine("       EMAIL NOTIFICATION CREATOR");
Console.WriteLine("========================================");

// The client works with the Creator abstraction.
//
// It does not directly create EmailNotification.
NotificationCreator emailCreator = new EmailNotificationCreator();

emailCreator.SendNotification(
    "Your order has been successfully placed."
);


// --------------------------------------------------
// SMS NOTIFICATION
// --------------------------------------------------

Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine("        SMS NOTIFICATION CREATOR");
Console.WriteLine("========================================");

// We can switch to another Concrete Creator.
//
// The client code remains the same because
// SendNotification() is defined in the base Creator.
NotificationCreator smsCreator = new SmsNotificationCreator();

smsCreator.SendNotification(
    "Your order has been shipped."
);


// --------------------------------------------------
// END
// --------------------------------------------------

Console.WriteLine();
Console.WriteLine("========================================");
Console.WriteLine("       FACTORY METHOD COMPLETE");
Console.WriteLine("========================================");