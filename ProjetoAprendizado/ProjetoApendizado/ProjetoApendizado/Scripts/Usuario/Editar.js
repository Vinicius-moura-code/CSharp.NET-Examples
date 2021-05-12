console.log('JavaScript carregado');

$(document).ready(function () {
    btnSalvar();
})

function btnSalvar() {
    $("#btnSalvar").on('click', function () {

        if (ValidacaoForm()) {
            console.log("Validação Ok");
            IncluirUsuario();
        }
    })
}
//Validar formulario
function ValidacaoForm() {
    var validar = true;

    //let toName = true;
    //let toIdade = true;
    //let toCpf = true;
    //let toSexo = true;

    ZerarValidacao();

    if ($('#txtNome').val().trim() == "" || $('#txtNome').val() == null) {
        $('#errorNome').text("Preencha o nome do user");
        validar = false;

    }

    if ($('#txtIdade').val() == "") {
        $('#errorIdade').text("Selecione uma idade")
        validar = false;
    }

    if ($('#txtCpf').val() == "") {
        $("#errorCpf").text("Preencha o Cpf");
    } else if (!validaCPF($('#txtCpf').val())) {
        $("#errorCpf").text("CPF Invalido!");
        validar = false;
    }

    if ($('#ddlSexo').val() == "") {
        $("#errorSexo").text("Selecione uma opção");
        validar = false;

    }

    if ($('#txtDatadeNascimeto').val() == "") {
        $("#errorData").text("Selecione uma opção");
        validar = false;
    } else if (!validaData($("#txtDatadeNascimeto").val())) {
        $("#errorData").text("Data invalida!");
        validar = false;
    }

    //if (toName == true && toIdade == true && toCpf == true && toSexo == true) {
    //    validar = true;
    //}
    return validar;
}

function ZerarValidacao() {
    $('#errorNome').text("");
    $('#errorIdade').text("");
    $('#errorCpf').text("");
    $('#errorSexo').text("");
    $('#errorData').text("");
    $('#divErro').html("");
}

function validaCPF(cpf) {

    if (cpf.length != 11) {
        return false;
    } else {
        var numeros = cpf.substring(0, 9);
        var digitos = cpf.substring(9);
        var soma = 0;

        // validacao do Primeiro Digito
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
        /*validar o Segundo Digito8*/

        if (resultado != digitos.charAt(1)) {
            return false;
        }
        return true;

    }
}

function validaData(data) {
    ////data - 2021-09-12
    //var ano = data.substring(0, 4);
    //var mes = data.substring(5, 7);
    //var dia = data.substring(8, 10);

    //var str = dia + "/" + mes + "/" + ano;
    //str - 12/09/2021

    //new Date('yyyy-MM-dd')
    var isDate = new Date(data).getTime();

    if (isNaN(isDate)) {
        return false;
    }

    return true;
}

//VERIFICAR JQUERY-VALIDATOR


function IncluirUsuario() {

    var objeto = MontarRequestIncluir();

    $.ajax({
        type: "POST",
        url: "/Usuario/Incluir",
        data: objeto,
        dataType: 'json',
        success: function (res) {
            if (res.status == 200) {
                $('#exampleModal').modal('show');
            } else if (res.status == 500) {
                alert(res.mensagem);
            } else {
                var listaErro = "";
                //LIST - STRING  [{"Preencha campo Nome"}, {"Preencha campo Cpf"}]
                $("#divErro").html("");

                var divErro = $("#divErro")

                divErro.append('<ul class= "list-group" >');
                for (var i = 0; i < res.erros.length; i++) {
                    divErro.append('<li class="list-group-item list-group-item-danger"">' + res.erros[i] + "</li>");
                }

                divErro.append("</ul>")
                console.log(listaErro);
            }
        },


    });

    //$.post('/Usuario/Incluir', objeto).done(function (res) { //res - Response

    //    //200  - Ok, 500 - ErroInterno, 404 - ErroValidacao
    //    if (res.status == 200) {
    //        alert(res.mensagem);
    //    } else if (res.status == 500) {
    //        alert(res.mensagem);
    //    }
    //    else {
    //        //Validação de tela;
    //        var listaErro = "";
    //        //LIST - STRING  [{"Preencha campo Nome"}, {"Preencha campo Cpf"}]
    //        for (var i = 0; i < res.erros.length; i++) {
    //            listaErro += res.erros[i] + "\n\n";
    //        }
    //        alert(listaErro);
    //    }
    //});

}

function MontarRequestIncluir() {
    return {
        Nome: $("#txtNome").val(),
        Idade: $("#txtIdade").val(),
        Cpf: $("#txtCpf").val(),
        DatadeNascimeto: $("#txtDatadeNascimeto").val(),
        IdSexo: $('#ddlSexo').val()
    };
}

//Estrutura OBJ -> { NOME_CAMPO: "VALOR_CAMPO_STRING" , NOME_CAMPO: VALOR_CAMPO_INTEIRO }

//Dois Insert manual Sexo1