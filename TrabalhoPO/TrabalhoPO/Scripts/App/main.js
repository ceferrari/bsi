﻿$(document).ready(function () {
    $(".input-validation-error").parents(".form-group").addClass("has-error");
});

$(document).on("hidden.bs.modal", ".modal", function () {
    var url = location.href;
    if (/Criar/i.test(url)) {
        location.href = url.replace(/Criar.*/i, "Index");
    } 
    if (/Editar/i.test(url)) {
        $.get(location.href, function (data) {
            replaceHtml(data);
        });
    }
    $(this).remove();
});

function isJson(str) {
    try {
        JSON.parse(str);
    } catch (e) {
        return false;
    }
    return true;
}

function isHtml(str) {
    return /<[a-z\][\s\S]*>/i.test(str);
}

function replaceHtml(str) {
    document.open();
    document.write(str);
    document.close();
}

function htmlOrModal(str, modalType) {
    if (isHtml(str)) {
        replaceHtml(str);
    } else {
        modal(str, modalType);
    }
}

function showModal(data) {
    $("body").append(data);
    $(".modal").modal("show");
}

$("a[data-toggle=modal]").on("click", function () {
    $.get(this.href, function (data) {
        showModal(data);
    });
});

function modal(Modal, Tipo) {
    var url = "/Home/Modal";
    if (!isJson(Modal)) {
        Modal = "{ 'Mensagem':'" + Modal + "'}";
    }
    $.get(url, { jsonModal: Modal, tipo: Tipo }, function (data) {
        showModal(data)
    });
}

function AddAntiForgeryToken(data) {
    data.__RequestVerificationToken = $("input[name=__RequestVerificationToken]").val();
    return data;
};

function exclui(Model, Id) {
    $.ajax({
        url: "/" + Model + "/ExcluirAsync",
        type: "POST",
        data: AddAntiForgeryToken({ id: Id }),
        success: function (result) {
            if ($("#" + Model + Id).length) {
                $("#" + Model + Id).remove();
            }
            else {
                location.href = "/" + Model + "/Index";
            }
        },
        error: function (result) {
            setTimeout(function () {
                modal(result.statusText, "Erro");
            }, 500);
        }
    });
    return false;
}

$(".form-crud").submit(function () {
    $.ajax({
        url: this.action,
        type: this.method,
        data: AddAntiForgeryToken($(this).serialize()),
        success: function (result) {
            htmlOrModal(result, "Sucesso");
        },
        error: function (result) {
            htmlOrModal(result, "Erro");
        }
    });
    return false;
});