$(document).ready(function () {
    $(".slider").slider({
        range: true,
        min: 0,
        slide: function (event, ui) {
            var sign = (this.id === "PrecoSlider" ? '$' : '');
            var range = sign + ui.values[0] + " - " + sign + ui.values[1];
            $("#Filtro" + this.id.replace("Slider", '')).val(range).focus();
            $(".filtro").trigger("change");
        },
        stop: function (event, ui) {
            $(".filtro").trigger("change");
        }
    });

    $(".filtro-slider").on("click", function () {
        var elem = "#" + this.id.replace("Filtro", '') + "SliderRow";
        $(".sliderRow").not(elem).hide();
        $(elem).toggle();
        if ($(elem).is(":hidden")) {
            $(this).blur();
        }
    });

    $(".container .row").on("click", function (event) {
        if (!$(event.target).is(".filtro-slider, .sliderRow td, .slider")) {
            $(".sliderRow").hide();
        }
    });

    $(".sliderRow").find("*").on("click focus", function () {
        $("#Filtro" + $(this).closest("tr").prop("id").replace("SliderRow", '')).focus();
    });
});