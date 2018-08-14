$(document).ready(function () {
/*    $("#iDiv").css("width","100px");
    $("#iDiv").css("height","100px");
    $("#iDiv").css("background","Red");*/
/*    $("#iDiv").css({width:"100px",height:"100px",backgroundColor:"Red"});*/
    $("#iDiv").addClass("style1");
    $("#iDiv").click(function () {
        $(this).toggleClass("style2");
    });
});