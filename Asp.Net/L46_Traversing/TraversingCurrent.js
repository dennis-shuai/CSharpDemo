/*
    sibings()
    next()
    nextAll()
    nextUntil()
    prev()
    preAll()
    preUntil()
 */
$(document).ready(
    function () {
        //$("h4").siblings().css({border:"5px solid Red"});
        $("h2").nextUntil("h5").css({border:"5px solid Red"});
    }
);