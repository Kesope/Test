﻿
(function (undefined) {

    require.config({
        baseUrl: "js",
        paths: {
            "jquery": "lib/jquery/dist/jquery.min",
            "knockout": "lib/knockout/dist/knockout",
            "text": "lib/requirejs-text/text",
            "bootstrap": "lib/bootstrap/dist/js/bootstrap.min",
            "toastr": "lib/toastr/toastr.min",

            "dataservice": "app/services/dataService",
            "postman": "app/services/postman",
            "config": "app/config"
        },
        shim: {
            "bootstrap": { "deps": ['jquery'] }
        }
    });

    require(['knockout'], function (ko) {
        ko.components.register("my-app", {
            viewModel: { require: 'app/components/app/app' },
            template: { require: 'text!app/components/app/appView.html' }
        });

        ko.components.register("person-list", {
            viewModel: { require: 'app/components/person/personlist' },
            template: { require: 'text!app/components/person/personListView.html' }
        });

        ko.components.register("person-details", {
            viewModel: { require: 'app/components/person/personDetails' },
            template: { require: 'text!app/components/person/personDetailsView.html' }
        });

        ko.components.register("pet-list", {
            viewModel: { require: 'app/components/pet/petlist' },
            template: { require: 'text!app/components/pet/petListView.html' }
        });
    });

    require(['knockout'], function (ko) {
        ko.applyBindings();
    });

})();