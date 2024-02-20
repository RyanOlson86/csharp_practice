namespace GettingStarted;

class Mouse
{
    public string? Name {get; set;}
    public string NickName = "Micky";

    //Static means the value is held in the class, not the instance
    public static int? SecretCode = 12345;

    // Method to get secret code
    public void GetSecretCode()
    {
        Console.WriteLine($"Secret code is {SecretCode}");
    }
}
