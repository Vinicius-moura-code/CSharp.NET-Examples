// Write your JavaScript code.
function getIdColuna(elemento) {
    return $(elemento).parents(".lista-leitura").data("id");
}

function getColunasDestino(elemento) {
    //pegando a coluna do item sendo arrastado:
    var idColuna = getIdColuna(elemento);
    console.log("Id da coluna é: " + idColuna);
    //selecionando apenas as outras duas colunas para o destino do drop
    return $(".lista-leitura").not("#coluna-" + idColuna);
}

$(".livro").draggable({
    classes: {
        "ui-draggable-dragging": "draggable"
    },
    zIndex: 999,
    revert: 'invalid',
    revertDuration: 100,
    start: function (event, ui) {
        //adicionar o evento de droppable:
        var colunasDestino = getColunasDestino(this);
        colunasDestino.droppable({
            accept: '.livro',
            classes: {
                'ui-droppable-active': 'droppable'
            },
            deactivate: function (event, ui) {
                $(this).droppable('destroy');
            },
            drop: function (event, ui) {
                var idLivro = $(ui.draggable).data("id");
                console.log("Id do livro é : " + idLivro);

                var idColunaOrigem = getIdColuna(ui.draggable);
                console.log("Coluna de Origem: " + idColunaOrigem);

                var idColunaDestino = $(this).data("id");
                console.log("Coluna de Destino: " + idColunaDestino);

                var listItemGroup = $(ui.draggable.parent().parent());
                var listGroupDestino = $(".list-group", this);
                listItemGroup.prependTo(listGroupDestino);
                $(ui.draggable).attr("style", "position: relative");

                //chamar uma requisição PUT para mover o livro
                $.post({
                    url: "/api/movimentacao",
                    data: { LivroId: idLivro, Origem: idColunaOrigem, Destino: idColunaDestino },
                    success: function () {
                        console.log("A movimentação foi efetuada com sucesso!");
                    },
                    error: function () {
                        console.error("Algo de errado ocorreu.");
                        //voltar o draggable pra origem
                    }
                });
            }
        });
    }
});