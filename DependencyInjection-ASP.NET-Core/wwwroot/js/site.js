// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {

    $("#Calcular").on('click', CalcularResultado)
    $("#Ejemplo").on('click', GenerarEjemploSuma)
});


function CalcularResultado()
{

    var PrimerNumero = $("#PrimerNumero").val();
    var SegundoNumero = $("#SegundoNumero").val();
    var TipoOperacion = $("#TipoOperacion").val();
    $.ajax({
        url: '/home/calcular',
        type: 'POST',
        success: function (e) {
            $("#Resultado").val(e.result);
        },
        data: {PrimerNumero,SegundoNumero,TipoOperacion}
    });
  
}

function GenerarEjemploSuma()
{
    $("#PrimerNumero").val(34);
    $("#SegundoNumero").val(85);
}