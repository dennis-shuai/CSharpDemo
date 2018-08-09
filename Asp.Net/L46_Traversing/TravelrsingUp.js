/*
    parent()
    parents()
    parentUntil()
 */
$(document).ready(
    function () {
      // $("a").parent() .css({border:"5px solid Yellow"});
       // $("a").parents() .css({border:"3px solid black"});
        $("a").parentsUntil("#div1") .css({border:"3px solid black"});

    }
);