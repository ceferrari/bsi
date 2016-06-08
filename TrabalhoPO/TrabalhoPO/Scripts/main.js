$(document).ready(function () {
    $(".input-validation-error").parents(".form-group").addClass("has-error");
});

$(document).on("hidden.bs.modal", ".modal", function () {
    $(this).remove();
    //history.go(-1);
});

function isJson(str) {
    try {
        JSON.parse(str);
    } catch (e) {
        return false;
    }
    return true;
}

function appendModal(id, data) {
    $("body").append("<div id='" + id + "' class='modal fade in' role='dialog'></div>");
    $("#" + id).html(data);
    $("#" + id).modal("show");
}

function modal(Params, Acao) {
    var url = "/Modal/" + (Acao || "Erro");
    if (!isJson(Params)) {
        Params = "{ 'Mensagem':'" + Params + "'}";
    }
    $.get(url, { json: Params }, function (data) {
        appendModal(data.Id, data)
    });
}

function excluiModal(Model, Id) {
    var url = "/" + Model + "/Excluir";
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