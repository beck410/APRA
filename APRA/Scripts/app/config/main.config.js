; (function () {
    'use strict';
    angular.module('apra')
    .config(function ($routeProvider, $locationProvider) {

        $routeProvider
        .when('/dashboard', {
            templateUrl: 'app/views/dashboard',
            controller: 'app/dashboardController'
        })
        .when('/schedule', { 
            templateUrl: 'Scripts/app/views/schedule.html',
            controller: 'Scripts/scheduleController'
        })
        .otherwise({
                redirectTo: '/dashboard'
        })

        $locationProvider.html5Mode(true);
    })
})();