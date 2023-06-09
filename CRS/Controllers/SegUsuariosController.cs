using CRS.Models.Respuesta;
using Microsoft.AspNetCore.Mvc;


namespace CRS.Controllers
{
    public class SegUsuariosController : Controller
    {
        Respuesta respuesta = new Respuesta();
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //[Route("api/login/Sesion")]
        //public async Task<JsonResult> Sesion(string usuario, string contraseña)
        //{
            
        //    //try
        //    //{
                

        //    //    aperturaCaja.Id_empresa = idEmpresa;
        //    //    aperturaCaja.Ususario_nombre = usuarioNombre;
        //    //    aperturaCaja.Ususario_cedula = usuario;
        //    //    aperturaCaja.Id_emision = 20;///adminitracion
        //    //    respuesta = await _aperturaCaja.GrabarAperturaCaja(aperturaCaja);

        //    //    if (_resultado != null)
        //    //    {
        //    //        return Json(new
        //    //        {
        //    //            mensaje_control = respuesta.mensaje_control,
        //    //            error = respuesta.error,
        //    //            respuesta_1 = respuesta.respuesta_1

        //    //        });
        //    //    }
        //    //    else
        //    //    {
        //    //        return Json(new
        //    //        {
        //    //            mensaje_control = "Erro al Grabar Apertura Caja",
        //    //            error = TipoError.Error,
        //    //        });
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
                

        //    //    return Json(new
        //    //    {
        //    //        mensaje_control = ex.Message,
        //    //        error = TipoError.Error,
        //    //    });
        //    //}
        //}

    }
}
