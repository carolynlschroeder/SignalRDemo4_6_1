$(function () {

    var demoHub = $.connection.signalRDemoHub;
    demoHub.client.addNewMessageToPage = function (retString) {
        alert(retString);
        $("#result").html(retString);
    }

    $.connection.hub.start()
        .done(function () {
            $('.like')
                .click(function () {
                    alert("like has been clicked");
                    demoHub.server.likeImage("Image has been liked");
                });
        });
});