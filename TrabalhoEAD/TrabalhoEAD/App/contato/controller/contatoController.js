contatoApp.controller('contatoController',
    ['$scope', 'contatoDataService', '$location',
    function categoryController($scope, contatoDataService) {
        $scope.contatos = [];
        
        loadContatoData();

        function loadContatoData() {
            contatoDataService.getContatos()
            .then(function () {
                $scope.contatos = contatoDataService.contatos;
            },
                function () {
                    //Erro
                })
                .then(function () {
                    $scope.isBusy = false;
                });
        };

    }]);

contatoApp.controller('contatoAddController',
    ['$scope', 'contatoDataService', '$window',
    function categoryController($scope, contatoDataService,$window) {
        $scope.contato = {};
        $scope.isEdit = false;

        $scope.cancel = function () {
            $window.location = "#/contatos";
        };

        $scope.saveContato = function () {
            if ($scope.contatoForm.$invalid) return;
            contatoDataService.addContato($scope.contato)
            .then(function () {
                $window.location = "#/contatos";
            },
            function () {
                
            })
        };
    }]);

contatoApp.controller('contatoEditController',
    ['$scope', 'contatoDataService', '$window','$routeParams','$modal',
    function categoryController($scope, contatoDataService, $window,$routeParams,$modal) {
        $scope.contato = {};
        $scope.isEdit = true;

        var lFirstChange = true;

        if ($routeParams.id) {
            $scope.contato = contatoDataService.findContatoById($routeParams.id);
            $scope.$watchCollection('contato', function () {
                if (!lFirstChange) {
                    $('#deleteButton').hide(400);
                }
                lFirstChange = false;
            });
        }

        $scope.cancel = function () {
            $window.location = "#/contatos";
        };

        $scope.modalDelete = function (size, contato) {
            var modalInstance = $modal.open({
                templateUrl: 'app/contato/html/deleteModal.html',
                controller: function ($scope, $modalInstance,contato) {
                    $scope.contato = contato;
                    $scope.cancel = function () {
                        $modalInstance.dismiss('cancel');
                    };

                    $scope.ok = function (contato) {
                        contatoDataService.deleteContato(contato.id)
                        .then(function () {
                            $window.location = "#/contatos";
                            $modalInstance.close(contato);
                        },
                        function () {
                            //Erro 
                        })
                    };
                },
                size: size,
                resolve: {
                    contato: function () {
                        return contato;
                    }
                }
            });
        };

        $scope.saveContato = function () {
            if ($scope.contatoForm.$invalid) return;
            contatoDataService.updateContato($scope.contato)
            .then(function () {
                $window.location = "#/contatos";
            },
            function () {
                //Erro
            })
        };
    }]);