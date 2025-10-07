using System;
using System.Text;

class PasswordGenerator
{
    private const string CHARACTERS = 
        "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=[]{}|;:,.<>?";

    public static string GeneratePassword(int length)
    {
        Random random = new Random();
        StringBuilder password = new StringBuilder(length);

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(CHARACTERS.Length);
            password.Append(CHARACTERS[index]);
        }

        return password.ToString();
    }

    static void Main(string[] args)
    {
        int passwordLength = 12; // длина пароля
        string password = GeneratePassword(passwordLength);
        Console.WriteLine("Сгенерированный пароль: " + password);
    }
}
