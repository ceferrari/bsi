$(document).ready(function () {
    $("#Preco").on("paste focusout", function () {
        var valor = parseFloat($(this).val().replace(/\./g, '').replace(',', '.')).toFixed(2);
        $(this).val(isNaN(valor) ? 0.0 : (valor * 1).toLocaleString());
    });

    $("#EstoqueAtual, #EstoqueMinimo").on("paste focusout", function () {
        var valor = parseInt($(this).val().replace(/\./g, ''));
        $(this).val(isNaN(valor) ? 0 : (valor * 1).toLocaleString());
    });
});

function altera(div, qtd) {
    var valor = parseInt($(div).val().replace(/\./g, ''));
    $(div).val((valor + qtd).toLocaleString());
}

function insere(Id) {
    if (Id === null) {
        altera("#EstoqueAtual", 1);
    } else {
        var url = "/Produtos/Insere";
        $.post(url, { id: Id }, atualiza);
    }
}

function retira(Id) {
    if (Id === null) {
        altera("#EstoqueAtual", -1);
    } else {
        var url = "/Produtos/Retira";
        $.post(url, { id: Id }, atualiza);
    }
}

function aumentaMinimo(Id) {
    if (Id === null) {
        altera("#EstoqueMinimo", 1);
    } else {
        var url = "/Produtos/AumentaMinimo";
        $.post(url, { id: Id }, atualiza);
    }
}

function diminuiMinimo(Id) {
    if (Id === null) {
        altera("#EstoqueMinimo", -1);
    } else {
        var url = "/Produtos/DiminuiMinimo";
        $.post(url, { id: Id }, atualiza);
    }
}

function atualiza(resposta) {
    $("#EstoqueAtual" + resposta.Id).html(resposta.EstoqueAtual);
    $("#EstoqueMinimo" + resposta.Id).html(resposta.EstoqueMinimo);
    $("#PrecisaReposicao" + resposta.Id).html(resposta.PrecisaReposicao === true ? "Sim" : "Não");
    var dataAlteracao = new Date(parseInt(resposta.DataAlteracao.substr(6)));
    var day = (dataAlteracao.getDate() < 10 ? '0' : '') + dataAlteracao.getDate();
    var month = (dataAlteracao.getMonth() < 9 ? '0' : '') + (dataAlteracao.getMonth() + 1);
    var year = (dataAlteracao.getFullYear() < 10 ? '0' : '') + dataAlteracao.getFullYear();
    var hour = (dataAlteracao.getHours() < 10 ? '0' : '') + dataAlteracao.getHours();
    var min = (dataAlteracao.getMinutes() < 10 ? '0' : '') + dataAlteracao.getMinutes();
    var sec = (dataAlteracao.getSeconds() < 10 ? '0' : '') + dataAlteracao.getSeconds();
    $("#DataAlteracao" + resposta.Id).html(day + "/" + month + "/" + year + " @ " + hour + ":" + min + ":" + sec);
}

function excluirModal(Id) {
    var url = "/Produtos/ExcluirModal";
    $.get(url, { id: Id }, function (data) {
        $('#Excluir').html(data);
        $('#ExcluirModal').modal('show');
    });
}

function exclui(Id) {
    var url = "/Produtos/Excluir";
    $.post(url, { id: Id }, function (resposta) {
        if ($("#Produto" + resposta.Id).length) {
            $("#Produto" + resposta.Id).remove();
        }
        else {
            window.location.href = "/Produtos/Index";
        }
    });
}