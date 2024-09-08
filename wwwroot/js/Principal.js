class Principal {
    userLink(UrlActual) {
        let url = "";
        let cadena = UrlActual.split("/");

        for (var i = 0; i < cadena.length; i++) { // Corregido 'lenght' por 'length'
            if (cadena[i] !== "index") {
                url += cadena[i];
            }

            switch (url) {
                case "UsersRegister":
                    // Escuchar cambios en el input file
                    document.getElementById('files').addEventListener('change', imageUser, false);
                    break;
            }
        }
    }
}