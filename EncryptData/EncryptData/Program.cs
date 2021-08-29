using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


namespace EncryptData
{
    class Program
    {
        static void Main(string[] args)
        {
           

           // Decryption(symAlgo);
            KeyContainer();

        }

        static void EncryptData(string plainText , RijndaelManaged algo)
        {
            byte[] plainDataArray = ASCIIEncoding.ASCII.GetBytes(plainText);
            ICryptoTransform transform = algo.CreateEncryptor();
            using (var fileStream = new FileStream("C:\\Encoder\\Cypher.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (var cryptoStream = new CryptoStream(fileStream, transform,CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainDataArray , 0 , plainDataArray.GetLength(0));
                    Console.WriteLine("Encrypted data written to:C:\\Encoder\\Cypher.txt11");
                }
            }
        }

        static void Decryption(RijndaelManaged algo)
        {
            ICryptoTransform transform = algo.CreateDecryptor();
            using (var fileStream = new FileStream("C:\\Encoder\\Cypher.txt", FileMode.Open, FileAccess.Read))
            {
                using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Read))
                {

                    using (var streamReader = new StreamReader(cryptoStream))
                    {
                        string decryptedData = streamReader.ReadToEnd();
                        Console.WriteLine("Decrypted data: \n{0}", decryptedData);

                    }
                }
            }
        }

        static void KeyContainer()
        {
            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "RSA_CONTAINER";
            RSACryptoServiceProvider rSAKeyGenerator = new RSACryptoServiceProvider(cspParams);
            Console.WriteLine("RSA key added to the container,\n\n{0}", rSAKeyGenerator.ExportParameters(true));

        }
    }
}
