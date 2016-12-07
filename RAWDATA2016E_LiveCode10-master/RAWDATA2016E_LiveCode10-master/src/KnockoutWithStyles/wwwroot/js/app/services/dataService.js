define([], function() {
 

    var getPersons = function(callback) {
        callback(persons);
    }

    return {
        getPersons
    };
});
