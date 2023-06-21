//using DCONTEXCRS.DbContex;

namespace CRS.Interfaces
{
    public interface IJwtClass
    {
        string GenerateToken(string usuario, string role);
    }
}
