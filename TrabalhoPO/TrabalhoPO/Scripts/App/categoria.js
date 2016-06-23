$(document).ready(function () {
    var maxProdutos = Math.max.apply(Math, $(".produtos").map(function () {
        return toUsInt($(this).html());
    }).get());

    $("#FiltroProdutos").on("click", function () {
        var elem = "#" + this.id.replace("Filtro", "") + "SliderRow";
        $(".sliderRow").not(elem).hide();
        $(elem).toggle();
        if ($(elem).is(":hidden")) {
            $(this).blur();
        }
    });

    $("#ProdutosSlider").slider({
        range: true,
        min: 0,
        max: maxProdutos,
        values: [0, maxProdutos],
        slide: function (event, ui) {
            $("#FiltroProdutos").val(ui.values[0] + " - " + ui.values[1]).focus();
            $(".filtro").trigger("change");
        },
        stop: function (event, ui) {
            $(".filtro").trigger("change");
        }
    });

    $(".ui-slider-handle, .sliderRow td").on("focus click", function () {
        $("#Filtro" + $(this).closest("tr").prop("id").replace("SliderRow", "")).focus();
    });

    $(".container .row").click(function (event) {
        if (!$(event.target).is("#FiltroProdutos, .slider, .sliderRow td")) {
            $(".sliderRow").hide();
        }
    });

    $(".filtro").on("change keyup", function () {
        var id = $("#FiltroId").val();
        var descricao = $("#FiltroDescricao").val().toUpperCase();
        var produtosMin = $("#ProdutosSlider").slider("values", 0);
        var produtosMax = $("#ProdutosSlider").slider("values", 1);
        var alteracao = $("#FiltroAlteracao").val();
        $(".categoria").each(function (i, val) {
            var produtos = toUsFloat($(this).find(".produtos").html());
            if (($(this).find(".id").html().indexOf(id) >= 0) &&
                ($(this).find(".descricao").html().toUpperCase().indexOf(descricao) >= 0) &&
                (produtos >= produtosMin && produtos <= produtosMax) &&
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
        $("#ProdutosSlider").slider("values", 0, 0).slider("values", 1, maxProdutos);
        $("#FiltroAlteracao").val('');
        $("#FiltroProdutos").val($("#ProdutosSlider").slider("values", 0) + " - " + $("#ProdutosSlider").slider("values", 1));
        $(".filtro").trigger("change");
    }).click();
});