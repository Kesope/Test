define(['knockout', 'dataservice', 'postman', 'config'],
    function (ko, dataService, postman, config) {
        return function () {
            var pets = ko.observableArray([]);

            var goToPersons = function() {
                postman.publish(
                    config.events.changeMenu,
                    config.menuItems.persons);
            }

            dataService.getPets(function (data) {
                pets(data);
            });

            return {
                pets,
                goToPersons
            };
        };
    });