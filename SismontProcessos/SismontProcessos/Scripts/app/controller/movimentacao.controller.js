var appModule = angular.module('app', ['ngResource']);

appModule.controller("movimentacaoController", function ($scope, movimentacaoFactory) {

    $scope.getRequisicao = function (id, callback) {
        requisicaoFactory.query({ id: id }, function (data) {
            $scope.requisicao = data;
        });
    };

    $scope.update = function () {
        requisicaoFactory.update({ id: $scope.requisicao.requisicao_id }, $scope.requisicao);
    };
});