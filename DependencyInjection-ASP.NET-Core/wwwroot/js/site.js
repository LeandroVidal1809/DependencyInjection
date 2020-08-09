
$(document).ready(function () {

    $("#Calcular").on('click', CalcularResultado);
    $("#Ejemplo").on('click', GenerarEjemploSuma);
    $("#CalcularEdad").on('click', CalcularEdad);
    $("#EjemploEdad").on('click', GenerarEjemploEdad);
    $("#DatosPersona").on('click', TraerPersona);
    $("#EjemploPersona").on('click', GenerarEjemploPersona);
    $("#FechaNacimiento").mask('99/99/9999');
});
function CalcularResultado()
{

    var PrimerNumero = $("#PrimerNumero").val();
    var SegundoNumero = $("#SegundoNumero").val();
    var TipoOperacion = $("#TipoOperacion").val();
    $.ajax({
        url: '/calcular/calcularOperacion',
        type: 'POST',
        success: function (e) {
            $("#Resultado").val(e.result);
        },
        data: {PrimerNumero,SegundoNumero,TipoOperacion}
    });
  
}

function CalcularEdad() {

    var FechaNacimiento = $("#FechaNacimiento").val();
    $.ajax({
        url: '/calcular/calcularEdad',
        type: 'POST',
        success: function (e) {
            $("#Edad").val(e.result);
        },
        data: { FechaNacimiento}
    });

}

function TraerPersona() {

    var Documento = $("#Documento").val();
    $.ajax({
        url: '/Personas/TraerDatosPersona',
        type: 'POST',
        success: function (e) {
            $("#Nombre").val(e.result.nombre);
            $("#FecNacimiento").val(e.result.fecNacimiento);
            $("#Edad").val(e.result.edad);
            $("#Sexo").val(e.result.sexo);
        },
        data: { Documento }
    });

}
function GenerarEjemploPersona() {
    $("#Documento").val("37120122");
}

function GenerarEjemploSuma()
{
    $("#PrimerNumero").val(34);
    $("#SegundoNumero").val(85);
}

function GenerarEjemploEdad()
{
    $("#FechaNacimiento").val("18/09/1992");
}