
function confirmar(titulo, texto, icono) {

    return new Promise(resolve => {
        Swal.fire({
            title: titulo,
            text: texto,
            icon: icono,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Si, borralo'
        }).then((result) => {
            resolve(result.isConfirmed);
        })

    })



}