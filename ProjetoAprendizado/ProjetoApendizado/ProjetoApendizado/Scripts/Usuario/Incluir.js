$(document).ready(function () {
    btnSlvar();
})

function btnSlvar() {
    $("#btnSalvar").on('click', function () {
        var retorno = ValidacaoForm();
        if (retorno == true) {
            validaCPF();
            //alert("Salvo com sucesso")
        }
    })
}

//Validar formulario
function ValidacaoForm() {

    ZerarValidacao();
    if ($('#txtNome').val().trim == "") {
        $("#vdlNome").text("Preencha o nome do user")
        return false;
    }
    

    return true;
}


function ZerarValidacao() {
    $('#vdlNome').text("");
    $('#vdlIdade').text("");
    $('#vdlCpf').text("");
}

console.log('JavaScript carregado');
function validaCPF(cpf) {
    let cpf = $('#txtcpf').val();

    if (cpf.length != 11) {
        return false;
    } else {
        var numeros = cpf.substring(0, 9);
        var digitos = cpf.substring(9);
        var soma = 0;

        // validacaoPrimeiroDigito
        for (var i = 10; i > 1; i--) {
            soma += numeros.charAt(10 - i) * i;
        }
        var resultado = soma % 11 < 2 ? 0 : 11 - (soma % 11);

        if (resultado != digitos.charAt(0)) {
            return false;
        }
        soma = 0;
        numeros = cpf.substring(0, 10);

        for (k = 11; k > 1; k--) {
            soma += numeros.charAt(11 - k) * k;
        }
        resultado = soma % 11 < 2 ? 0 : 11 - (soma % 11);
        /*validSegundoDigito8*/

        if (resultado != digitos.charAt(1)) {
            return false;
        }
        return true;

    }
}

