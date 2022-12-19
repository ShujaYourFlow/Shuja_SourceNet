
$('#menu-btn').click(function () {
    $('#respMenu').slideToggle();
});

$('#respMenu .mobile-li a').click(function () {
    $(this).parent().toggleClass("menu-active");
    $(this).parent().find(".sub-menu").slideToggle();
    $(this).parent().find(".sub-menu").toggleClass("slide");
});

$('.arrow-mega-menu').on("click", function () {
    $(this).prev().toggleClass("mega-title-active");
});

$(function () {
    $('.nav li a').each(function () {
        if ($(this).prop('href') == window.location.href) {
            $(this).addClass('current-page-link');
        }
    });
});


$('#new-mega-menu-id').on("click", function () {
    $(".new-mega-menu-use-cases").toggleClass("mega-menu-ul-active");
});

$("#new-mega-menu-id").mouseover(function () {
    $(".new-mega-menu-use-cases").addClass("mega-menu-ul-active");
    $(".product-line-dropdown").removeClass("product-line-dropdown-menu-active");
});

$(".new-mega-menu-category-name").hover(function () {
    $(this).addClass("is-active");
}, function () {
    $(this).removeClass("is-active");
});

$(document).mouseup(function (e) {
    var megamenu = $("#new-mega-menu-dropdown");
    if (!megamenu.is(e.target) && megamenu.has(e.target).length === 0) {
        $(".new-mega-menu-use-cases").removeClass("mega-menu-ul-active");
    }
});

$('#health-multi-drop').on("click", function () {
    $("#coronavirus-id-m").toggleClass("coronavirus-show-m");
});

$('.new-mega-menu-close').on("click", function () {
    $(".new-mega-menu-use-cases").removeClass("mega-menu-ul-active");
});

$(".product-line-dropdown").mouseover(function () {
    $(".new-mega-menu-use-cases").removeClass("mega-menu-ul-active");
    $(".product-line-dropdown").addClass("product-line-dropdown-menu-active");
});

$('.product-line-menu-close').on("click", function () {
    $(".new-mega-menu-use-cases").removeClass("mega-menu-ul-active");
    $(".product-line-dropdown").removeClass("product-line-dropdown-menu-active");
});

$('#product-line-id-a').on("click", function () {
    $('.product-line-dropdown').toggleClass("product-line-dropdown-menu-active");
});

$(document).mouseup(function (e) {
    var megamenu = $("#product-line-dropdown");
    if (!megamenu.is(e.target) && megamenu.has(e.target).length === 0) {
        $(".product-line-dropdown").removeClass("product-line-dropdown-menu-active");
    }
});

$(window).scroll(function () {
    if ($(this).scrollTop() > 50) {
        $('#back-to-top').fadeIn();
    }
    else {
        $('#back-to-top').fadeOut();
    }
});
// scroll body to 0px on click
$('#back-to-top').click(function () {
    $('body,html').animate({
        scrollTop: 0
    }, 400);
    return false;
});

$('.header-search-wrapper .search-main').click(function () {
    $('.search-form-main').toggleClass('active-search');
    $('.search-form-main .search-field').focus();
});


$(document).ready(function(){
    $(".service-content").slice(0, 4).show();
    $("#loadMore").on("click", function(e){
      e.preventDefault();
      $(".service-content:hidden").slice(0, 4).slideDown();
      if($(".service-content:hidden").length == 0) {
        $("#loadMore").text("No Content").addClass("noContent");
      }
    });
  })


$(".social-share").floatingSocialShare({
    buttons: [
        "facebook",
        "linkedin",
        "pinterest",
        "reddit",
        "telegram",
        "tumblr",
        "twitter",
        "viber",
        "vk",
        "whatsapp",
    ],
    counter: false,
    text: "share with: ",
    url: "https://github.com/ozdemirburak/jquery-floating-social-share",
});

function opensignup() {
    window.location.href = window.location.protocol + "//" + window.location.host + "/SignUp.html";
}

