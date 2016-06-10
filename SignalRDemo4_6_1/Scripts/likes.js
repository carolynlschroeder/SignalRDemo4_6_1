$(function () {

    $(".like")
        .each(function() {
            var hiddenlike = $(this).siblings("input.userLikes:hidden").val();
            if (hiddenlike == "False") {
                $(this).css("display","");
                $(this).siblings("span.liked").css("display", "none");
            } else {
                $(this).css("display", "none");
                $(this).siblings("span.liked").css("display", "");
            }
        });

    var demoHub = $.connection.signalRDemoHub;
    demoHub.client.addNewMessageToPage = function (userId, imageId) {
        var count = parseInt($("#tLikes_" + imageId).text());
        var txt = (count + 1) + " Likes";
        $("#tLikes_" + imageId).text(txt);
        if ($("#userId").val() == userId) {
            $("#a_" + imageId).css("display", "none");
            $("#sp_" + imageId).css("display", "");
        }
    }

    $.connection.hub.start()
       .done(function () {
           $('.like')
               .click(function () {
                   var userId = $("#userId").val();
                   var imageId = $(this).siblings("input.imageId:hidden").val();
                   demoHub.server.likeImage(userId, imageId);
               });
       });
});