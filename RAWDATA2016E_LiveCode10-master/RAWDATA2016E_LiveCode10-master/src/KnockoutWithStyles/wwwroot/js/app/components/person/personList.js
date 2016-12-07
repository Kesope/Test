define(['knockout', 'app/services/dataService', 'app/services/postman'],
    function (ko, dataService, postman) {
    return function(params) {
        var persons = ko.observableArray([]);
        var selectedPerson = ko.observable();
        var selectPerson = function(person) {
            selectedPerson(person);
            postman.publish("select person", person);
        };
        var isSelected = function(person) {
            return person === selectedPerson();
        }

        dataService.getPersons(function(data) {
            persons(data);
        });



        return {
            persons,
            selectPerson,
            isSelected
        }
    }
});