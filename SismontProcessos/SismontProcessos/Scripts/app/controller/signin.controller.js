var app = angular.module("loginApp",[]);

var url = 'http://localhost:7213/';
app.controller('loginController', function ($scope,userService) {
    $scope.fail = false;
    $scope.erro = '';
    $scope.signin = function () {
        $scope.fail = !userService.signin($scope.user);
        $scope.erro = 'Unidade não foi encontrada. Tente novamente ou entre em contato com o administrador.';
    };

    $scope.abandon = function () {
        $http.post(url + 'api/login/abandosession')
    };
});


app.controller('userController', function ($scope, userService) {

    $scope.updateSenha = function (callback) {
        userService.updatePassword($scope.senha, callback);
    };

    //$scope.abandon = function () {
    //    $http.post(url + 'api/login/abandosession')
    //};
    $scope.user = null;
    userService.getUser(function (data) {
        $scope.user = data;
    });
});

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('AuthInterceptor');
});