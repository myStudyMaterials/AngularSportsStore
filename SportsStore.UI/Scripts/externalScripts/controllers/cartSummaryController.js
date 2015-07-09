angular.module("sportsStore")
.controller("cartSummaryController", function ($scope, cart) {
    $scope.cart = cart.getProducts();
    $scope.total = function () {
        var total = 0;
        for (var i = 0; i < $scope.cart.length; i++) {
            total += $scope.cart[i].Price;
        }
        return total;
    };
    $scope.removeProduct = function (id) {
        cart.removeProduct(id);
    };
});