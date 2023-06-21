
using DCONTEXCRS.DbContex;
using DCONTEXCRS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCONTEXCRS.Services
{
    public class SegUsuariosServices : ISegUsuariosDAL
    {
        private readonly CrsContext context;

        public SegUsuariosServices(CrsContext context)
        {
            this.context = context;
        }

        public async Task<bool> Sesion(string usuario, string contraseña)
        {
            bool login = false;

            try
            {
                var valida = context.SegUsuarios.Count(x => x.Ususario.Equals(usuario) && x.Contrasena.Equals(contraseña));

                login = !valida.Equals(0) ? true : false;

                return login;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
