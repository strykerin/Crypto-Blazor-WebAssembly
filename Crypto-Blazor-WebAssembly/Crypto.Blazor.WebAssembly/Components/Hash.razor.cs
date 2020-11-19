using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace Crypto.Blazor.WebAssembly.Components
{
    public class HashBase : ComponentBase
    {
        public string _input = string.Empty;

        public string SHA256HashFunction (string plainText)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute Hash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(_input));

                // Convert byte array to string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
