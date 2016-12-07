var dataservice = {
    search: function (searchString, callback) {
        $.getJSON("https://api.github.com/search/users?q=" + searchString, callback);
    }
}

$("#btn").on('click', function () {
    dataservice.search($("#input").val(), function (data) {
        $("#output").text(JSON.stringify(
                data.items.map(function (e) {
                    return {
                        login: e.login,
                        id: e.id
                    }
                })
                ));
    });
});