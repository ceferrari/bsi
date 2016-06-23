$(document).ready(function () {
    var maxProdutos = Math.max.apply(Math, $(".produtos").map(function () {
        return toUsInt($(this).html());
    }).get());

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
        $("#ProdutosSlider").slider("option", { max: maxProdutos, values: [0, maxProdutos], step: 1 });
        $("#FiltroId").val('');
        $("#FiltroDescricao").val('');
        $("#FiltroProdutos").val($("#ProdutosSlider").slider("values", 0) + " - " + $("#ProdutosSlider").slider("values", 1));
        $("#FiltroAlteracao").val('');
        $(".filtro").trigger("change");
    }).click();
});