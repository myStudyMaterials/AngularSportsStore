angular.module("sportsStore")
.controller("sportsStoreController", function ($scope, productServices) {


    $http.post("Home/GetProducts")
            .success(function (data) {
                $scope.data.products = data;
            })
             .error(function (error) {
                 return null;
             });
});