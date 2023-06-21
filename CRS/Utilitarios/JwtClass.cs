using CRS.Interfaces;
//using DCONTEXCRS.DbContex;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace CRS.Utilitarios
{
    public class JwtClass : IJwtClass
    {
        private readonly IConfiguration _configuration;
        public JwtClass(IConfiguration _configuration)
        {
            this._configuration = _configuration;
        }

        public string GenerateToken(string usuario, string role)
        {
            string secretKey = _configuration.GetSection("Jwy:secretKey").Value!;

            var claims = new[]
            {
            new Claim("username", usuario),
            new Claim("role", role)
            };
            
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(30), // Fecha de expiración del token
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                    SecurityAlgorithms.HmacSha256Signature)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool ValidaToken(string token)
        {
            bool valida = false;

            string secretKey = _configuration.GetSection("Jwy:secretKey").Value!;

            try
            {
                var tokenValidationParameters = new TokenValidationParameters
                {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ValidateIssuer = false, // Opcional: Validar el emisor (issuer) del token
                ValidateAudience = false, // Opcional: Validar la audiencia (audience) del token
                ClockSkew = TimeSpan.Zero // Opcional: Configurar la tolerancia de tiempo
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                ClaimsPrincipal claimsPrincipal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken validatedToken);
                
                var claims = claimsPrincipal.Claims;

                valida = !claims.Equals(null)?false:true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); 
            }
            return valida;
        }
    }
}
