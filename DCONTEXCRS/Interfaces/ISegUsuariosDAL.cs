
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCONTEXCRS.Interfaces
{
    public interface ISegUsuariosDAL
    {
        Task<bool> Sesion(string usuario, string contraseña);
    }
}
