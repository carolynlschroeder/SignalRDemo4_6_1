$(function () {

    var demoHub = $.connection.signalRDemoHub;
    demoHub.client.addNewMessageToPage = function (userId, imageId) {
        var count = parseInt($("#tLikes_" + imageId).text());
        var txt = (count + 1) + " Likes";
        $("#tLikes_" + imageId).text(txt);
        if ($("#userId").val() == userId) {
            $("#a_" + imageId).removeClass("visible");
            $("#a_" + imageId).addClass("notvisible");
            $("#sp_" + imageId).removeClass("notvisible");
            $("#sp_" + imageId).addClass("visible");
        }
    }

    $.connection.hub.start()
       .done(function () {
           $('.like')
               .click(function (e) {
                   e.preventDefault();
                   var userId = $("#userId").val();
                   var imageId = $(this).siblings("input.imageId:hidden").val();
                   demoHub.server.likeImage(userId, imageId);
               });
       });
});