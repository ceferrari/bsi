contatoApp.config(['$routeProvider', function ($routeProvider) {
    
    $routeProvider.when('/', {
        redirectTo: "/contatos"
    }),

    $routeProvider.when('/contatos', {
        templateUrl: "app/contato/html/contatosList.html",
        controller: "contatoController"
    }),

    $routeProvider.when('/contatos/novo', {
        templateUrl: "app/contato/html/contatoForm.html",
        controller: "contatoAddController"
    }),
    
    $routeProvider.when('/contatos/:id', {
        templateUrl: "app/contato/html/contatoForm.html",
        controller: "contatoEditController"
    }),

    $routeProvider.otherwise({
        redirectTo: '/contatos'
    });

}]);