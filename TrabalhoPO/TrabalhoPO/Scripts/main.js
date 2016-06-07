$(document).ready(function () {
    $(".input-validation-error").parents(".form-group").addClass("has-error");

    $("#Preco").on("paste focusout", function () {
        var valor = parseFloat($(this).val().replace(/\./g, '').replace(',', '.')).toFixed(2);
        $(this).val((isNaN(valor) || valor < 0 ? 0 : (valor * 1)).toLocaleString([], { minimumFractionDigits: 2 }));
    });

    $("#EstoqueAtual, #EstoqueMinimo").on("paste focusout", function () {
        var valor = parseInt($(this).val().replace(/\./g, ''));
        $(this).val(isNaN(valor) || valor < 0 ? 0 : (valor * 1).toLocaleString());
    });
});

$(document).on("hidden.bs.modal", "#ExcluirModal", function () {
    $(this).remove();
    history.go(-1);
});

function excluirModal(Model, Id) {
    var url = "/" + Model + "/ExcluirModal";
    $.get(url, { id: Id }, function (data) {
        appendModal("ExcluirModal", data)
    });
}

function exclui(Model, Id) {
    var url = "/" + Model + "/Excluir";
    $.post(url, { id: Id }, function (resposta) {
        if ($("#" + Model + Id).length) {
            $("#" + Model + Id).remove();
        }
        else {
            window.location.href = "/" + Model + "/Index";
        }
    });
}

function modal(Model, Acao) {
    var url = "/Modal/" + (Acao || "Erro");
    $.get(url, { jsonModel: Model }, function (data) {
        appendModal(data.Id, data)
    });
}

function appendModal(id, data) {
    $("body").append("<div id='" + id + "' class='modal fade in' role='dialog'></div>");
    $("#" + id).html(data);
    $("#" + id).modal("show");
}

function altera(div, qtd) {
    var valor = parseInt($(div).val().replace(/\./g, ''));
    $(div).val(valor + qtd < 0 ? 0 : (valor + qtd).toLocaleString());
}

function insere(Id) {
    if (Id === 0 || Id === null) {
        altera("#EstoqueAtual", 1);
    } else {
        var url = "/Produto/Insere";
        $.post(url, { id: Id }, atualiza);
    }
}

function retira(Id) {
    if (Id === 0 || Id === null) {
        altera("#EstoqueAtual", -1);
    } else {
        var url = "/Produto/Retira";
        $.post(url, { id: Id }, atualiza);
    }
}

function aumentaMinimo(Id) {
    if (Id === 0 || Id === null) {
        altera("#EstoqueMinimo", 1);
    } else {
        var url = "/Produto/AumentaMinimo";
        $.post(url, { id: Id }, atualiza);
    }
}

function diminuiMinimo(Id) {
    if (Id === 0 || Id === null) {
        altera("#EstoqueMinimo", -1);
    } else {
        var url = "/Produto/DiminuiMinimo";
        $.post(url, { id: Id }, atualiza);
    }
}

function atualiza(resposta) {
    $("#EstoqueAtual" + resposta.Id).html(resposta.EstoqueAtual.toLocaleString());
    $("#EstoqueMinimo" + resposta.Id).html(resposta.EstoqueMinimo.toLocaleString());
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