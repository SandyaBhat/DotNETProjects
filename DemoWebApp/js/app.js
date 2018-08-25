var formApp = angular.module('formApp', []);

formApp.controller('ValidationController', ['$scope','$http', function ($scope, $http) {

    $scope.Validate = function () {
        var url = "http://myappservice.eastus.cloudapp.azure.com/WebAPI/api/welcome/" + $scope.user.lastname;
        $http.get(url).then(function (response) {
            $scope.message = response.data;
        });
		//$scope.message="Welcome " + $scope.user.firstname;
	};

	$scope.Getname = function (name) {
	    $scope.messag = "LoginUser";
	};
}]);