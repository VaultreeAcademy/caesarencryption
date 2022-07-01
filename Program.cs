using System;
namespace CesarEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int encryption = 0, decryption = 0, key = 10;
            string userSendsText = "", encryptedText = "", decryptDecision = "", decryptText = "";


            Console.WriteLine("Write the word to be encrypted: ");
            userSendsText = Console.ReadLine();

            for (int i = 0; i < userSendsText.Length; i++)
            {
                int txtUser = (int)userSendsText[i];
                encryption = txtUser + key; //Read the text and displacement the numbers of positions based the key
                encryptedText += Char.ConvertFromUtf32(encryption);
            }

            Console.WriteLine($"Encrypted Text: {encryptedText}");

            Console.WriteLine("Would you like decrypted the text? (Y/N)");
            decryptDecision = Console.ReadLine();

            if (decryptDecision == "n" || decryptDecision == "N")
            {
                Console.WriteLine("Thanks to use!");
            }

            else if(decryptDecision == "y" || decryptDecision == "Y")
            {
                for (int i = 0; i < encryptedText.Length; i++)
                {
                    int encrypted = (int)encryptedText[i];
                    decryption = encrypted - key;
                    decryptText += Char.ConvertFromUtf32(decryption);

                }

                Console.WriteLine($"Decrypt Text: {decryptText}");
            }

            else
            {
                Console.WriteLine("Sorry, I don't understand!");
            }

        }
    }
}