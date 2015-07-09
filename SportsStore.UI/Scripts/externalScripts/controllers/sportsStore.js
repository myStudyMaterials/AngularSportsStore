angular.module("sportsStore")
.controller("sportsStoreController", function ($scope, $http) {



    $scope.data = {};
    $scope.loaderValue = true;
    getProducts();


    function getProducts() {
        $http.post("Home/GetProducts")
        .success(function (data) {
            $scope.data.products = data;
            $scope.loaderValue = false;
        })
         .error(function (error) {
             $scope.data.error = error;
             $scope.loaderValue = false;
         });
    };

});