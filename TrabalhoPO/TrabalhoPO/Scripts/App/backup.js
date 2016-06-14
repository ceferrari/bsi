function getTarget(e) {
    e = e || window.event;
    return (e.target || e.srcElement);
};

function getPost(Controller, Action, Id) {
    $.getJSON("/" + Controller + "/Get", { id: Id }, function (data) {
        Model = AddAntiForgeryToken(data);
        $.post("/" + Controller + "/" + Action, Model).done(sucesso).fail(erro);
    });
}

function postId(Controller, Action, Id) {
    Model = AddAntiForgeryToken({ id: Id });
    $.post("/" + Controller + "/" + Action, Model).done(sucesso).fail(erro);
}