angular.module("cart")
.directive("cartSummary", function (cart) {
    return {
        restrict: "E",
        templateUrl: "Home/CartSummary",
        controller: function ($scope) {
            var cartData = cart.getCartData();

            $scope.total = function () {
                var total = 0;
                for (var i = 0; i < cartData.length; i++) {
                    total += (cartData[i].Price * cartData[i].Count);
                }
                return total;
            }
            $scope.itemCount = function () {
                var total = 0;
                for (var i = 0; i < cartData.length; i++) {
                    total += cartData[i].Count;
                }
                return total;
            };
        }
    };
});