angular.module('appEntryPoint', ['eventModule', 'ngResource'])
.config([function ($httpProvider) {

    /* configure providers not instances! */
    console.log('Configuration hook');
}])
.run([function () {

    /* run this when the app kicks off */
    console.log('Run hook');
}])