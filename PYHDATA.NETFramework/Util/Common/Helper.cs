using System.Linq;
using System.Text;

namespace PYHDATA.NETFramework.Util.Common
{
    public class Helper
    {
        public static string SHA128(string value)
        {
            using (var sha = new System.Security.Cryptography.SHA1Managed())
            {
                var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(value));
                return string.Join("", hash.Select(b => b.ToString("x2")));
            }
        }
    }
}
