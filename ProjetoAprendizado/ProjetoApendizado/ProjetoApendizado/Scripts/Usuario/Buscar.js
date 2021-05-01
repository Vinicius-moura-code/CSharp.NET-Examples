console.log('JavaScript carregado');

$(document).ready(function () {
    btnBuscar();
})

function btnBuscar() {
    $("#btnBuscar").on('click', function () {

        BuscarUsuario();
    })
}

function BuscarUsuario() {
    var objeto = MontarRequestBuscarUsuario();

    $.ajax({
        type: "POST",
        url: "/Usuario/Buscar",
        data: objeto,
        dataType: 'json',
        success: function (res) {
            if (res.status == 200) {



                $("#tableUsuario").html("");



                if (res.objeto.length != 0) {

                    $("#tableUsuario").append("<thead>");
                    $("#tableUsuario").append("<tr>");
                    $("#tableUsuario").append('<th scope="col">#</th>');
                    $("#tableUsuario").append('<th scope="col">Nome:</th>');
                    $("#tableUsuario").append('<th scope="col">Cpf:</th>');
                    $("#tableUsuario").append('<th scope="col">Idade:</th>');
                    $("#tableUsuario").append('<th scope="col">Alterar</th>');
                    $("#tableUsuario").append('<th scope="col">Deletar</th>');
                    $("#tableUsuario").append("</tr>");
                    $("#tableUsuario").append("</thead>");


                    for (var i = 0; i < res.objeto.length; i++) {
                        $("#tableUsuario").append('<tbody>');
                        $("#tableUsuario").append("<tr>");

                        $("#tableUsuario").append('<th scope="row">' + i + "</th>");
                        $("#tableUsuario").append("<td>" + res.objeto[i].Nome + "</td>");
                        $("#tableUsuario").append("<td>" + res.objeto[i].Cpf + "</td>");
                        $("#tableUsuario").append("<td>" + res.objeto[i].Idade + "</td>");
                        $("#tableUsuario").append("<td>" +
                            '<ul class="nav nav-pills">' +
                            '<li class="nav-item">' +
                            '<a class="nav-link btn btn-success" href="#">Alterar <span class="badge badge-light"><img src="../../Content/Usuario/alterar.png"/></span ></a >' +
                            '</li>' + '</ul>' + "</td>");
                        $("#tableUsuario").append("<td>" +
                            '<ul class="nav nav-pills">' +
                            '<li class="nav-item">' +
                            '<a class="nav-link btn btn-danger" href="#">Deletar <span class="badge badge-light"><img src="../../Content/Usuario/bin.png"/></span ></a >' +
                            '</li>' + '</ul>' + "</td>");


                        $("#tableUsuario").append("</tr>");
                        $("#tableUsuario").append('</tbody>');


                    }
                } else {
                    $("#tableUsuario").append("<tr><td>Nenhum Usuário encontrado!</td></tr>");
                }



            } else if (res.status == 500) {
                alert(res.mensagem);
            }
        }
    });
};



function MontarRequestBuscarUsuario() {
    return {
        NomeUsuario: $('#txtNomeUsuario').val()
    }
}


//Estilizar e criar uma coluna vazia & adicionar um Botão para remover