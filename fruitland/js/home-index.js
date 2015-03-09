var module = angular.module("homeIndex", []);

module.config(function ($routeProvider) {
    $routeProvider.when("/", {
        controller: "fruitController",
        templateUrl:"/templates/fruitView.html"
    });
    $routeProvider.otherwise("/");
});

function fruitController($scope, $http) {
    $scope.dataCount = 0;
    $scope.data = [];

    var data = $http.get("/api/v1/fruit?includeReplies=true").then(function (result) {
        angular.copy(result.data, $scope.data);
    },
        function () { alert("fdasfas") });
}