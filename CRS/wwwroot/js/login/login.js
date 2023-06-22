var boton = document.getElementById("idsesion");

var UrlLogin = document.baseURI + "SegUsuarios/login";


boton.addEventListener("click", function () {
    var usuario = $("#usuario").val();
    var contraseña = $("#contrasena").val();
    var role = "admin"
    Logeo(usuario, contraseña, role);


});

function Logeo(usuario, contraseña, role) {
    $.ajax({
        method: 'GET',
        url: UrlLogin,
        data: { usuario, contraseña, role },
        success: function (respuesta) {
            debugger
            console.log(respuesta.datos)
        },
        error: function (respuesta) {
            debugger
            console.log(respuesta.respuesta)
        }
    });
}



