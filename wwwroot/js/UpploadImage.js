
class UpploadImage {
    Archivo(evt, id) {
        let files = evt.target.files; // Lista de archivos
        let f = files[0]; // Tomamos el primer archivo

        // Verificar si el archivo es una imagen
        if (f.type.match('image.*')) {
            let reader = new FileReader();

            // Una vez que se haya cargado la imagen, mostrarla en la página
            reader.onload = ((theFile) => {
                return (e) => {
                    document.getElementById(id).innerHTML =
                        '<img class="imageUser" src="' + e.target.result + '" title="' + escape(theFile.name) + '"/>';
                };
            })(f);

            reader.readAsDataURL(f); // Leer el archivo como una URL
        }
    }
}