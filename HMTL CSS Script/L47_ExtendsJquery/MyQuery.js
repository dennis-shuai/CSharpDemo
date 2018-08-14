$.myFun = function () {
    alert("Hello myjQuery");
};

$.fn.myFun =function () {
    $(this).text("Hello");
};