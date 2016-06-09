var app = angular.module("myApp", []);

app.controller('myController', function ($scope, $http) {
    $scope.ResultPI = "";
    $scope.ResultTime = "";
    $scope.ResultVolume = "";
    $scope.myClick = function () {
        $http({
            method: 'POST',
            url: "/Controller.asmx/Calculate",
            dataType: 'json',
            data: {},
            contentType: 'application/json; charset=utf-8'
        }).success(function (response) {
            var data = response.d;

            $scope.ResultPI      = "PI VALUE: " + data.PI 
            $scope.ResultTime    = "CALCULATION TIME: " + data.CalculationTime + "ms"
            $scope.ResultVolume  = "MOON VOLUME: " + data.MoonVolume

            $scope.$apply();
        }).error(function (data, status, headers, config) {
            $scope.ResultPI      = data;
            $scope.ResultTime    = status;
            $scope.ResultVolume  = header;          
        });
    } //BUTTON CLICK EVENT
}); //CONTROLLER