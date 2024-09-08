// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var principal = new Principal();

// Código Usuario

var user = new Users();

// Corregido: se pasa el id correcto 'imageUser' al método Archivo
var imageUser = (evt) => {
    user.Archivo(evt, 'imageUser');
}

// Evento que se ejecuta al cargar la página
$().ready(() => {
    let URLactual = window.location.pathname;
    principal.userLink(URLactual);
});