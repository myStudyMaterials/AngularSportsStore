angular.module("sportsStore")
    .constant("productListActiveClass", "btn-primary")
    .constant("productListPageCount", 3)
.controller("productListControllers", function ($scope, $filter, productListActiveClass, productListPageCount, cart) {
    var selectedCategory = null;

    $scope.selectedPage = 1;
    $scope.pageSize = productListPageCount;
    $scope.selectCategory = function (newCategory) {
        selectedCategory = newCategory;
        $scope.category = 1;
    };

    $scope.categoryFilterFunction = function (product) {
        return selectedCategory == null || product.CategoryName == selectedCategory;
    };

    $scope.getCategoryClass = function (category) {
        return selectedCategory == category ? productListActiveClass : "";
    };

    $scope.selectPage = function (newPage) {
        $scope.selectedPage = newPage;
    };
    $scope.getPageClass = function (page) {
        return $scope.selectedPage == page ? productListActiveClass : "";
    };

    $scope.addProduct = function (product) {
        cart.addProduct(product);
    };

});