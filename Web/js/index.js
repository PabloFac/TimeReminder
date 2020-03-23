$(function (){
    $(window).scroll(function(){
       if ($(this).scrollTop() > 100) {
        $('#navbarContainer').addClass("bg-1 shadow-sm");
       } else {
        $("#navbarContainer").removeClass("bg-1 shadow-sm");
       }
    });
});