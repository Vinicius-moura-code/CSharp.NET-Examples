console.log('JavaScript carregado');

$(document).ready(function () {
    btnBuscar();
})

function btnBuscar() {
    $("#btnBuscar").on('click', function () {
        $(".loader-wrapper").fadeIn(10);

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
                    $("#tableUsuario").append('<th scope="col">Nome:</th>');
                    $("#tableUsuario").append('<th scope="col">Cpf:</th>');
                    $("#tableUsuario").append('<th scope="col">Idade:</th>');
                    $("#tableUsuario").append('<th scope="col">Alterar</th>');
                    $("#tableUsuario").append('<th scope="col">Deletar</th>');
                    $("#tableUsuario").append("</tr>");
                    $("#tableUsuario").append("</thead>");


                    for (var i = 0; i < res.objeto.length; i++) {
                        $("#tableUsuario").append('<tbody>');
                        $("#tableUsuario").append('<tr>');

                        $("#tableUsuario").append("<td>" + res.objeto[i].Nome + "</td>");
                        $("#tableUsuario").append("<td>" + res.objeto[i].Cpf + "</td>");
                        $("#tableUsuario").append("<td>" + res.objeto[i].Idade + "</td>");
                        $("#tableUsuario").append("<td class='editar' id='" + res.objeto[i].Id + "'dir='" + res.objeto[i].Nome + "' >" +
                            '<ul class="nav nav-pills">' +
                            '<li class="nav-item">' +
                            '<a class="nav-link btn btn-success" href="#">Alterar <span class="badge badge-light"><img src="../../Content/Usuario/alterar.png"/></span ></a >' +
                            '</li>' + '</ul>' + "</td>");
                        $("#tableUsuario").append("<td class='deletar' id='" + res.objeto[i].Id + "'dir='" + res.objeto[i].Nome + "' >" +

                            '<ul class="nav nav-pills">' +

                            '<li class="nav-item">' +

                            '<a class="nav-link btn btn-danger" href="#">Deletar <span class="badge badge-light"><img src="../../Content/Usuario/bin.png"/></span ></a >' +

                            '</li>' + '</ul>' + "</td>");


                        $("#tableUsuario").append("</tr>");
                        $("#tableUsuario").append('</tbody>');


                    }
                    Editar();
                    DeletarUsuario();
                } else {
                    $("#tableUsuario").append("<tr><td>Nenhum Usuário encontrado!</td></tr>");
                }

                $(".loader-wrapper").fadeOut(3000);


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

function DeletarUsuario() {
    $(".deletar").on('click', function () {
        var id = $(this).attr("id");
        var nome = $(this).attr("dir");

        if (confirm("Deseja realmente cancelar o usuario " + nome)) {
            $.ajax({
                type: "POST",
                url: "/Usuario/Deletar",
                data: { Id: id },
                dataType: 'json',
                success: function (res) {
                    if (res.status == 200 || res.status == 500) {
                        alert("Usuario " + nome + " inativado")

                    }
                }

            });
        }
    });
}


function Editar() {
    $(".editar").on('click', function () {
        var id = $(this).attr("id");


        window.location.href = "/Usuario/Editar?Id=" + id;

    });
}