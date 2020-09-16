using System.Security.Cryptography;
using System.Text;

namespace VRApp.Hash
{
    public class HashManager : IHashWritable
    {
        
        
        
        public string HashString(string defaultValue)
        {
            
            
            
            using (SHA256 sha256 = SHA256.Create())
            {
                
                SHA256Managed cryptoManager = new SHA256Managed();
                string hash = string.Empty;
                byte[] cryptoValue = cryptoManager.ComputeHash(Encoding.ASCII.GetBytes(defaultValue));
                foreach (byte theByte in cryptoValue)
                {
                    hash += theByte.ToString("x2");
                }
                return hash;
            }
            
           
        }

        
    }
}