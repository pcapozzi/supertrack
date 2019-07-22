//==> thumbnail slider about supertrack
var slideIndex = 1;
showSlides(slideIndex);

// Next/previous controls
function plusSlides(n) {
    showSlides(slideIndex += n);
}

// Thumbnail image controls
function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("img-slide");
    var dots = document.getElementsByClassName("thumbnail-img");
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }

    if (typeof (slides[slideIndex - 1]) != 'undefined') {
        slides[slideIndex - 1].style.display = "block";
    }
    if (typeof (dots[slideIndex - 1]) != 'undefined') {
        dots[slideIndex - 1].className += " active";
    }
}

//==> read more / read less about supertrack

$('.read-more').click(function () {
    var collapse_content_selector = $(this).attr('href');
    var toggle_switch = $(this);
    $(collapse_content_selector).toggle(function () {
        if ($(this).css('display') == 'none') {
            toggle_switch.html('Read more');
        } else {
            toggle_switch.html('Read less');
        }
    });
});

//dropdown link expire on mobile screen
$(document).ready(function () {
    if ($(window).width() > 769) {
 //==> dropdown move one page to another 
        $('li.dropdown').on('click', function () {
            var $el = $(this);
            if ($el.hasClass('hide-dropdown')) {
                var $a = $el.children('a.dropdown-toggle');
                if ($a.length && $a.attr('href')) {
                    location.href = $a.attr('href');
                }
            }
        });
    }
    else {     
    }
});

