// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.sr = ScrollReveal({ reset: true });

sr.reveal('.scrollReveal', {
    rotate: { x: 100, y: 100, z: 0 },
    duration: 1000
});