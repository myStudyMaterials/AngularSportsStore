angular.module("cart")
.factory("cart", function () {
    var cartData = [];
    return {
        addProduct: function (product) {
            var addedToExistingItem = false;
            for (var i = 0; i < cartData.length; i++) {
                if (product.ProductId == cartData[i].ProductId) {
                    cartData[i].Count++;
                    addedToExistingItem = true;
                    break;
                }
            }
            if (!addedToExistingItem) {
                var cartObject = product;
                cartObject.Count = 1;
                cartData.push(cartObject);
            }
        },
        removeProduct: function (id) {
            for (var i = 0; i < data.length; i++) {
                if (cartData[i].ProductId == id) {
                    cartData.splice(i, 1);
                    break;
                }
            }
        },
        getCartData: function () {
            return cartData;
        }
    }
});