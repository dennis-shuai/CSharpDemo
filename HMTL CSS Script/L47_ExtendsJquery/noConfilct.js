var myJquery = $.noConflict();
myJquery(document).ready(
    function () {
        myJquery("#iBtn").on("click",function () {
            myJquery("div").text("new Hello");
        });
    }
);