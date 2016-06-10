contatoApp.factory('contatoDataService', ['$http', '$q',
function ($http, $q) {
    var _contatos = [];
    
    var _getContatos = function () {
        var deferred = $q.defer();
        var controllerQuery = "contato/GetContatos";

        $http.get(controllerQuery)
          .then(function (result) {
              angular.copy(result.data, _contatos);
              deferred.resolve();
          },
          function (error) {
              deferred.reject();
          });
        return deferred.promise;
    }

    var _addContato = function (_contato) {
        var deferred = $q.defer();
        var controllerQuery = "contato/AddContato";

        $http.post(controllerQuery, _contato)
          .then(function (result) {
              alert(1);
              deferred.resolve();
          },
          function (error) {
              alert(JSON.stringify(error));
              deferred.reject();
          });
        return deferred.promise;
    };

    var _updateContato = function (_contato) {
        var deferred = $q.defer();
        var controllerQuery = "contato/UpdateContato";

        $http.post(controllerQuery, _contato)
          .then(function (result) {
              deferred.resolve();
          },
          function (error) {
              deferred.reject();
          });
        return deferred.promise;
    };

    var _deleteContato = function (id) {
        var deferred = $q.defer();
        var controllerQuery = "contato/DeleteContato/"+ id;

        $http.post(controllerQuery)
          .then(function (result) {
              deferred.resolve();
          },
          function (error) {
              deferred.reject();
          });
        return deferred.promise;
    };

    function _findContatoById(id) {
        var found = null;
        $.each(_contatos, function (i, contato) {
            if (contato.id == id) {
                found = contato;
                return false;
            }
        });
        return found;
    };

    return {
        contatos: _contatos,
        getContatos: _getContatos,
        addContato: _addContato,
        updateContato: _updateContato,
        deleteContato : _deleteContato,
        findContatoById: _findContatoById
    }

}]);