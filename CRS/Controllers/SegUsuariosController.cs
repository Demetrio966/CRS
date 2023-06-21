using CRS.Interfaces;
using CRS.Models.Respuesta;
using CRS.Utilitarios;
//using DCONTEXCRS.DbContex;
using DCONTEXCRS.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace CRS.Controllers
{
    public class SegUsuariosController : Controller
    {
        private readonly IJwtClass _jwtClass;
        private readonly ISegUsuariosDAL _segUsuarios;

        public SegUsuariosController(IJwtClass jwtClass, ISegUsuariosDAL segUsuarios)
        {
            this._jwtClass = jwtClass;
            this._segUsuarios = segUsuarios;
        }

        Respuesta respuesta = new Respuesta();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("login")]
        public async Task<dynamic> login(string usuario, string contraseña, string role)
        {
            var token = string.Empty;
            bool login = false;
            try
            {
                login = await _segUsuarios.Sesion(usuario, contraseña);

                if (login)
                {
                    token = _jwtClass.GenerateToken(usuario, role);
                    respuesta.respuesta = "Correcto";
                }
                else
                {
                    token = "Usuario o clave incorrecta";
                    respuesta.respuesta = "Incorrecto";
                }

                respuesta.datos = token;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return respuesta;
        }

    }
}
