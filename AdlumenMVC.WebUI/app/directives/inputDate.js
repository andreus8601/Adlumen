﻿adlumenApp.directive('inputDate', function() {
    return {
        restrict: 'A',
        scope: {
            ngModel: '='
        },
        link: function(scope) {
            if (scope.ngModel) scope.ngModel = new Date(scope.ngModel);
        }
    }
});

