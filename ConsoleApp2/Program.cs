using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, string> PolybiusSquare = new Dictionary<char, string>
    {
        { 'A', "11" }, { 'B', "12" }, { 'C', "13" }, { 'D', "14" }, { 'E', "15" },
        { 'F', "21" }, { 'G', "22" }, { 'H', "23" }, { 'I', "24" }, { 'J', "24" },
        { 'K', "25" }, { 'L', "31" }, { 'M', "32" }, { 'N', "33" }, { 'O', "34" },
        { 'P', "35" }, { 'Q', "41" }, { 'R', "42" }, { 'S', "43" }, { 'T', "44" },
        { 'U', "45" }, { 'V', "51" }, { 'W', "52" }, { 'X', "53" }, { 'Y', "54" },
        { 'Z', "55" }
    };

    static Dictionary<string, char> ReversePolybiusSquare = new Dictionary<string, char>();

    static void Main()
    {
        foreach (var pair in PolybiusSquare)
        {
            ReversePolybiusSquare[pair.Value] = pair.Key;
        }

        Console.WriteLine("Выберите действие: 1 - Зашифровать текст, 2 - Расшифровать текст из файла");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Введите текст для шифрования:");
            string text = Console.ReadLine();
            string encryptedText = EncryptText(text);
            Console.WriteLine("Зашифрованный текст: " + encryptedText);
            SaveToFile(encryptedText, "C:\\Users\\edu-msk22-805s\\Desktop\\11\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net6.0\\12.txt");
        }
        else if (choice == 2)
        {
            string encryptedTextFromFile = File.ReadAllText("C:\\Users\\edu-msk22-805s\\Desktop\\11\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net6.0\\12.txt");
            string decryptedText = DecryptText(encryptedTextFromFile);
            Console.WriteLine("Расшифрованный текст: " + decryptedText);
        }
    }

    static string EncryptText(string text)
    {
        text = text.ToUpper();
        string encryptedText = "";
        foreach (char c in text)
        {
            if (c == ' ')
            {
                encryptedText += " ";
            }
            else if (PolybiusSquare.ContainsKey(c))
            {
                encryptedText += PolybiusSquare[c] + ",";
            }
        }
        return encryptedText.Trim(',');
    }

    static string DecryptText(string encryptedText)
    {
        string[] codes = encryptedText.Split(',', StringSplitOptions.RemoveEmptyEntries);
        string decryptedText = "";
        foreach (string code in codes)
        {
            if (ReversePolybiusSquare.ContainsKey(code))
            {
                decryptedText += ReversePolybiusSquare[code];
            }
            else if (code == " ")
            {
                decryptedText += " ";
            }
        }
        return decryptedText;
    }

    static void SaveToFile(string text, string fileName)
    {
        File.WriteAllText(fileName, text);
        Console.WriteLine($"Текст сохранен в файле {fileName}");
    }
}
