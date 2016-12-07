define(['jquery'], function ($) {
    

    var getPersons = function (callback) {
        var url = "api/persons";
        $.getJSON(url, function (data) {
            callback(data);
        });
    }

    var getPets = function (callback) {
        var url = "api/pets";
        $.getJSON(url, function (data) {
            callback(data);
        });
    }

    return {
        getPersons,
        getPets
    };
});




        