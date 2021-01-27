// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
window.onload = fadeIn;

function fadeIn() {
    var fade = document.getElementById("animate");
    var opacity = 0;
    var intervalID = setInterval(function () {

        if (opacity < 1) {
            opacity = opacity + 0.05
            fade.style.opacity = opacity;
        } else {
            clearInterval(intervalID);
        }
    }, 100);
}
