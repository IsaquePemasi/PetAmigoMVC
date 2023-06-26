//ScrollReveal
window.sr = ScrollReveal({ reset: true });

sr.reveal('.scrollReveal', {
    rotate: { x: 100, y: 100, z: 0 },
    duration: 1000
});
/*script modal */
    $('#meuModal').on('shown.bs.modal', function () {
        $('#meuInput').trigger('focus')
    })
