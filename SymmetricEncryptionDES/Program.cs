using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricEncryptionDES
{
    class Program
    {
        static void Main(string[] args)
        {
            var des = new DESEncryption();
            var key = des.GenerateRandomNumbers(8);
            var iv = des.GenerateRandomNumbers(8);
            const string message = "Message to encrypt";

            var encrypted = des.Encrypt(Encoding.UTF8.GetBytes(message), key, iv);
            var decrypted = des.Decrypt(encrypted, key, iv);

            var decryptedMessage = Encoding.UTF8.GetString(decrypted);

            Console.WriteLine("DES Encryption");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Message text = {message}");
            Console.WriteLine($"Encrypted text = {Convert.ToBase64String(encrypted)}");
            Console.WriteLine($"Decrypted text = {decryptedMessage}");
        }
    }
}
