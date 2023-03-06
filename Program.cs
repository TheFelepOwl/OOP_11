using System;

class Program
{
    static void Main(string[] args)
    {
        

        Console.Write("Name:  ");
        string firstName = Console.ReadLine();

        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        
        Console.Write("Middel name: ");
        string middleName = Console.ReadLine();

        // Визначення довжини рядків
        int lastNameLength = lastName.Length;
        int firstNameLength = firstName.Length;
        int middleNameLength = middleName.Length;

        // Дії відповідно до варіанту завдання
        string fullName = firstName + " " + lastName + " " + middleName;
        
        
        int aCount =0;

        for(int i = 0; i < lastNameLength; i++)
            if(lastName[i]=='a'|| lastName[i] == 'A')
                aCount++;
        
     Console.WriteLine("The number of a in the surname:" + aCount);


        string encryptedName = Encrypt(fullName);
        string decryptedName = Decrypt(encryptedName);

        Console.WriteLine("Сiphertext: " + encryptedName);
        Console.WriteLine("Deciphered text: " + decryptedName);

    }

    // Метод для шифрування тексту
    static string Encrypt(string text)
    {
        string result = "";
        foreach (char c in text)
        {
            result += (char)(c + 1);
        }
        return result;
    }

    // Метод для розшифрування тексту
    static string Decrypt(string text)
    {
        string result = "";
        foreach (char c in text)
        {
            result += (char)(c - 1);
        }
        return result;
    }
}