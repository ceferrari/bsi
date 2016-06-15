$(document).ready(function () {
    $("#Preco").on("paste focusout", function () {
        var valor = parseFloat($(this).val().replace(/\./g, '').replace(',', '.')).toFixed(2);
        $(this).val((isNaN(valor) || valor < 0 ? 0 : (valor * 1)).toLocaleString([], { minimumFractionDigits: 2 }));
    });

    $("#EstoqueAtual, #EstoqueMinimo").on("paste focusout", function () {
        var valor = parseInt($(this).val().replace(/\./g, ''));
        $(this).val(isNaN(valor) || valor < 0 ? 0 : (valor * 1).toLocaleString());
    });
});

var timeout = null;
var interval = null;

function hold(Funcao, Acao_Div, Id_Qtd) {
    Funcao(Acao_Div, Id_Qtd);
    timeout = setTimeout(function () {
        interval = setInterval(function () {
            Funcao(Acao_Div, Id_Qtd);
        }, 100);
    }, 500);
}

function release() {
    clearTimeout(timeout);
    clearInterval(interval);
}

function postProduto(Acao, Id) {
    Id = AddAntiForgeryToken({ id: Id });
    $.post("/Produto/" + Acao, Id).done(sucesso).fail(erro);
}

function altera(div, qtd) {
    var valor = parseInt($(div).val().replace(/\./g, ''));
    $(div).val(valor + qtd < 0 ? 0 : (valor + qtd).toLocaleString());
}

function aumentaAtual(Id) {
    if (Id) {
        hold(postProduto, "AumentaAtual", Id);
    } else {
        hold(altera, "#EstoqueAtual", 1);
    }
}

function diminuiAtual(Id) {
    if (Id) {
        hold(postProduto, "DiminuiAtual", Id);
    } else {
        hold(altera, "#EstoqueAtual", -1);
    }
}

function aumentaMinimo(Id) {
    if (Id) {
        hold(postProduto, "AumentaMinimo", Id);
    } else {
        hold(altera, "#EstoqueMinimo", 1);
    }
}

function diminuiMinimo(Id) {
    if (Id) {
        hold(postProduto, "DiminuiMinimo", Id);
    } else {
        hold(altera, "#EstoqueMinimo", -1);
    }
}

function sucesso(result) {
    $("#EstoqueAtual" + result.Id).html(result.EstoqueAtual.toLocaleString());
    $("#EstoqueMinimo" + result.Id).html(result.EstoqueMinimo.toLocaleString());
    $("#PrecisaReposicao" + result.Id).html(result.PrecisaReposicao === true ? "Sim" : "Não");
    var dataAlteracao = new Date(parseInt(result.DataAlteracao.substr(6)));
    var day = (dataAlteracao.getDate() < 10 ? '0' : '') + dataAlteracao.getDate();
    var month = (dataAlteracao.getMonth() < 9 ? '0' : '') + (dataAlteracao.getMonth() + 1);
    var year = (dataAlteracao.getFullYear() < 10 ? '0' : '') + dataAlteracao.getFullYear();
    var hour = (dataAlteracao.getHours() < 10 ? '0' : '') + dataAlteracao.getHours();
    var min = (dataAlteracao.getMinutes() < 10 ? '0' : '') + dataAlteracao.getMinutes();
    var sec = (dataAlteracao.getSeconds() < 10 ? '0' : '') + dataAlteracao.getSeconds();
    $("#DataAlteracao" + result.Id).html(day + "/" + month + "/" + year + " @ " + hour + ":" + min + ":" + sec);
}

function erro(result) {
    modal(result.statusText, "Erro");
}