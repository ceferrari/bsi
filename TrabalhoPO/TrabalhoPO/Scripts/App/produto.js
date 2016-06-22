$(document).ready(function () {
    $(".holdable").on("mouseup mouseout", release);

    $("#Preco").on("paste focusout", function () {
        var valor = toUsFloat($(this).val());
        $(this).val(isNaN(valor) || valor < 0 ? toBrFloat(0) : toBrFloat(valor));
    });

    $("#EstoqueAtual, #EstoqueMinimo").on("paste focusout", function () {
        var valor = toUsInt($(this).val());
        $(this).val(isNaN(valor) || valor < 0 ? 0 : toBrInt(valor));
    });

    $("#FiltroPreco, #FiltroAtual, #FiltroMinimo").on("click", function () {
        var elem = "#" + this.id.replace("Filtro", "") + "SliderRow";
        $(".sliderRow").not(elem).hide();
        $(elem).toggle();
        if ($(elem).is(":hidden")) {
            $(this).blur();
        }
    });

    $("#PrecoSlider").slider({
        range: true,
        min: 0,
        max: 150,
        values: [0, 150],
        slide: function (event, ui) {
            $("#FiltroPreco").val("$" + ui.values[0] + " - $" + ui.values[1]).focus();
            $(".filtro").trigger("change");
        },
        stop: function (event, ui) {
            $(".filtro").trigger("change");
        }
    });

    $("#AtualSlider").slider({
        range: true,
        min: 0,
        max: 5000,
        values: [0, 5000],
        step: 10,
        slide: function (event, ui) {
            $("#FiltroAtual").val(ui.values[0] + " - " + ui.values[1]).focus();
            $(".filtro").trigger("change");
        },
        stop: function (event, ui) {
            $(".filtro").trigger("change");
        }
    });

    $("#MinimoSlider").slider({
        range: true,
        min: 0,
        max: 5000,
        values: [0, 5000],
        step: 10,
        slide: function (event, ui) {
            $("#FiltroMinimo").val(ui.values[0] + " - " + ui.values[1]).focus();
            $(".filtro").trigger("change");
        },
        stop: function (event, ui) {
            $(".filtro").trigger("change");
        }
    });

    $(".ui-slider-handle").on("focus", function () {
        $("#Filtro" + $(this).parent().prop("id").replace("Slider", "")).focus();
    });

    $(".container .row").click(function (event) {
        if (!$(event.target).is("#FiltroPreco, #FiltroAtual, #FiltroMinimo")) {
            $(".sliderRow").hide();
        }
    });

    $(".filtro").on("change keyup", function () {
        var id = $("#FiltroId").val();
        var descricao = $("#FiltroDescricao").val().toUpperCase();
        var precoMin = $("#PrecoSlider").slider("values", 0);
        var precoMax = $("#PrecoSlider").slider("values", 1);
        var atualMin = $("#AtualSlider").slider("values", 0);
        var atualMax = $("#AtualSlider").slider("values", 1);
        var minimoMin = $("#MinimoSlider").slider("values", 0);
        var minimoMax = $("#MinimoSlider").slider("values", 1);
        var reposicao = $("#FiltroReposicao option:selected").text();
        var categoria = $("#FiltroCatgoria option:selected").text();
        var alteracao = $("#FiltroAlteracao").val();
        $(".produto").each(function (i, val) {
            var preco = toUsFloat($(this).find(".preco .pull-right").html());
            var atual = toUsInt($(this).find(".atual .pull-right").html());
            var minimo = toUsInt($(this).find(".minimo .pull-right").html());
            if (($(this).find(".id").html().indexOf(id) >= 0) &&
                ($(this).find(".descricao").html().toUpperCase().indexOf(descricao) >= 0) &&
                (preco >= precoMin && preco <= precoMax) &&
                (atual >= atualMin && atual <= atualMax) &&
                (minimo >= minimoMin && minimo <= minimoMax) &&
                ($(this).find(".reposicao").html().indexOf(reposicao) >= 0 || reposicao === "Tudo") &&
                ($(this).find(".categoria").html().indexOf(categoria) >= 0 || categoria === "Tudo") &&
                ($(this).find(".alteracao").html().indexOf(alteracao) >= 0)) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });
    });

    $("#LimparFiltros").on("click", function () {
        $("#FiltroId").val('');
        $("#FiltroDescricao").val('');
        $("#PrecoSlider").slider("values", 0, 0).slider("values", 1, 150);
        $("#AtualSlider").slider("values", 0, 0).slider("values", 1, 5000);
        $("#MinimoSlider").slider("values", 0, 0).slider("values", 1, 5000);
        $("#FiltroReposicao option:first").prop("selected", "selected");
        $("#FiltroCatgoria option:first").prop("selected", "selected");
        $("#FiltroAlteracao").val('');
        $("#FiltroPreco").val("$" + $("#PrecoSlider").slider("values", 0) + " - $" + $("#PrecoSlider").slider("values", 1));
        $("#FiltroAtual").val($("#AtualSlider").slider("values", 0) + " - " + $("#AtualSlider").slider("values", 1));
        $("#FiltroMinimo").val($("#MinimoSlider").slider("values", 0) + " - " + $("#MinimoSlider").slider("values", 1));
        $(".filtro").trigger("change");
    }).click();
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
    $(this).blur();
}

function postProduto(Acao, Id) {
    Id = AddAntiForgeryToken({ id: Id });
    $.post("/Produto/" + Acao + "Async", Id).done(sucesso).fail(erro);
}

function altera(div, qtd) {
    var valor = toUsInt($(div).val());
    $(div).val(valor + qtd < 0 ? 0 : toBrInt(valor + qtd));
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
    if (result.PrecisaReposicao) {
        $("#Produto" + result.Id).addClass("text-danger");
        $("#PrecisaReposicao" + result.Id).html("Sim");
    } else {
        $("#Produto" + result.Id).removeClass("text-danger");
        $("#PrecisaReposicao" + result.Id).html("Não");
    }
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
    modal(result.statusText, "Alerta");
}