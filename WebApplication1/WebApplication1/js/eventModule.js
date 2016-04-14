/* Declare angular module */
angular.module('eventModule', [])

/* Declare angular factory */
.factory('emFactory', [function () {

}])

 /* Config - runs as soon as the app gets kicked off */
.config([function () {

    console.log('Event Module : config');
}])

/* If our module is up and running then execute the code inside the anonymous function */
.run([function () {

    console.log('Event Module : running')
}])

/* Controllers */

.controller('ServiceController', ['$scope', '$resource', '$filter', function ($scope, $resource, $filter) {

    var service = $resource("http://localhost:62100/api/values");
    var fields = [];
    var objects = [];
    var objField = { fieldName: "txtFirstName" };
    var dt = new Date("2011-09-07 14:43:22.520");

    $scope.callPost = function () {

        var data = {
            id: "7",
            changes: objects
        };

        service.save({}, data).$promise.then(
            function (response) {
                alert('Success');
                console.log(response.name);
            },
            function () { alert('Error'); }
        );
    }

}])