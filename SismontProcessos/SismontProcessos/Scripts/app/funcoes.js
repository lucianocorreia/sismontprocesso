jQuery(function () {
    $('#buscar-cep').click(function () {
        $('#CEP').cep({
            success: loadEndereco
        });
    });

    $('#cep').focusout(function () {
        $('#cep').cep({
            success: loadEndereco
        });
    });

    $('#uf').focusout(function () {
        setMask();
    });

    function loadEndereco(data) {
        $('#endereco').val(data.tipoLogradouro + ' ' + data.logradouro);
        $('#bairro').val(data.bairro);
        $('#uf').val(data.estado);
        $('#municipio').val(data.cidade);
    }

    function setMask() {
        var mask = "(99) 9999-9999";
        var uf = $('#UF').val();
        if (uf.toUpperCase() == "SP" || uf.toUpperCase() == "RJ" || uf.toUpperCase() == "ES") {
            mask = "(99) 99999-9999";
        }
        $("#Celular").mask(mask);
        $("#Telefone").mask(mask);
    }
});