$(document).ready(function () {
    $("#iButton").click( function () {
        //$("#aid").text("www.jikexueyuan.com");
        $("#aid").attr("href","www.jikexueyuan.com");
    });
    $("#delete").click(function () {
        //$("p").remove();
        $("p").empty();
    });

});
