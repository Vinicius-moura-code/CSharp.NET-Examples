using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Alura.ListaLeitura.Seguranca
{
    public class SigningConfigurations
    {
        private readonly string secret = "mysupersecret_secretkey!123";
        public SecurityKey Key { get; }
        public SigningCredentials SigningCredentials { get; }

        public SigningConfigurations()
        {
            var keyByteArray = Encoding.ASCII.GetBytes(secret);
            Key = new SymmetricSecurityKey(keyByteArray);
            SigningCredentials = new SigningCredentials(
                Key,
                SecurityAlgorithms.HmacSha256
            );
        }
    }
}
