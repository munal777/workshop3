using System;
class NullOperations
{
    public static void PerformNullChecks()
    {
        String userName = null;
        Console.WriteLine(userName == null ? "User Name is Not Available" : userName);
        Console.WriteLine(userName ?? "User Name is Not Available");
        userName ??= "Default User";
        Console.WriteLine(userName);


    }
}