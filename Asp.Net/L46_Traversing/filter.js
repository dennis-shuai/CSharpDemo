/*
    first()
    last()
    eq()
    filter()
    not()
 */
$(document).ready(
    function () {
      //$("div p").first().css({background:"Red"});
      //  $("div p").eq(2).css({background:"Red"});
      //  $("div p").filter("p").css({background:"Red"});
        $("div p").not(".pclass").css({background:"Red"});
    }
);