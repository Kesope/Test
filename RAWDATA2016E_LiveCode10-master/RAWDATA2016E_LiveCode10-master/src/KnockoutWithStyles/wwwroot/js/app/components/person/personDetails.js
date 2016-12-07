define(['knockout', 'app/services/postman'], function (ko, postman) {
    return function (params) {
        var person = ko.observable(params.person);

        postman.subscribe("select person", function(p) {
            person(p);
        });

        return {
            person
        }
    }
});