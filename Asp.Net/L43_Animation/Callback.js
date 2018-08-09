$(document).ready(function () {
    $("#btnHide").click(function () {
       /* $("p").hide(1000,function () {
            alert("Amimation is completed");
        });*/
       $("p").css("color","Red").slideUp(1000).slideDown(1000);
    });
});