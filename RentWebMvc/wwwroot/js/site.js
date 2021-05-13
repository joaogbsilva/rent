/* Onclick do input .viacep - Consulta API ViaCEP */
$(".viacep").click(function () {
    
    const cep = document.querySelector("#cep");
    
    const showData = (result) => {
        for (const campo in result) {
            // Verificando os IDs dos campos que serão utilizados
            if (document.querySelector("#" + campo)) {
                document.querySelector("#" + campo).value = result[campo]
            }
        }
    }

    // No blur do input cep
    cep.addEventListener("blur", (e) => {
        // Retirando o '-' do cep, caso exista
        let search = cep.value.replace("-", "")
        const options = {
            method: 'GET',
            mode: 'cors',
            cache: 'default'
        }

        fetch(`https://viacep.com.br/ws/${search}/json/`, options)
            // Retorno com sucesso
            .then(response => {
                response.json()
                    .then(data => showData(data))
            })
            // Retorno com erro
            .catch(e => console.log('Deu erro: ' + e))

    });
});