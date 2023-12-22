$(document).ready(function () {
    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('#altIcerik').addClass('gorunur');
        } else {
            $('#altIcerik').removeClass('gorunur');
        }
    });
});