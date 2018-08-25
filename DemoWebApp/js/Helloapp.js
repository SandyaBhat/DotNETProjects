// JavaScript source code
var helloApp = angular.module('helloApp', []);
helloApp.controller('helloWorldController', ['$scope', '$http','API_URL', function ($scope, $http,API_URL) {

    $scope.GetName = function (userName) {
        var url;
        if ((userName != '') || (userName != null))
            url = API_URL.baseUrl + "/" + userName;
        else
            url = API_URL.baseUrl;
        $http.get(url).then(function (response) {
            $scope.message = response.data;
        });
        //$scope.message="Welcome " + $scope.user.firstname;
    };

}]);
