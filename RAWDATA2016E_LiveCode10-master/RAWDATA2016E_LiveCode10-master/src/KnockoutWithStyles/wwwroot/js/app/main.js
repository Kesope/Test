(function() {
    require.config({
        baseUrl: "js",
        paths: {
            "knockout": "lib/knockout/dist/knockout",
            "text": "lib/requirejs-text/text"
        }
    });

    require(['knockout'], function(ko) {
        ko.components.register("person-list",
        {
            viewModel: { require: "app/components/person/personlist" },
            template: { require: "text!app/components/person/personlistView.html" }
        });
        ko.components.register("person-details",
        {
            viewModel: { require: "app/components/person/personDetails" },
            template: { require: "text!app/components/person/personDetailsView.html" }
        });
    });

    require(['knockout'], function(ko) {
        ko.applyBindings();
    });

})();
