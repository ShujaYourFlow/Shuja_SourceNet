// =======================================================================
    // menu js start
// =======================================================================
$('.burger, .overlay').click(function(){
    $('.burger').toggleClass('clicked');
    $('.overlay').toggleClass('show');
    $('nav').toggleClass('show');
    $('body').toggleClass('overflow');
  });
  // ////
   var _gaq = _gaq || [];
    _gaq.push(['_setAccount', 'UA-36251023-1']);
    _gaq.push(['_setDomainName', 'jqueryscript.net']);
    _gaq.push(['_trackPageview']);
  
    (function() {
      var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
      ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
      var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
    })();
  
  // =======================================================================
      // home slider js start
  // =======================================================================
  // HERO SLIDER
      var menu = [];
      jQuery('.swiper-slide').each( function(index){
          menu.push( jQuery(this).find('.slide-inner').attr("data-text") );
      });
      var interleaveOffset = 0.5;
      var swiperOptions = {
          loop: true,
          speed: 1000,
          parallax: true,
          autoplay: {
              delay: 6500,
              disableOnInteraction: false,
          },
          watchSlidesProgress: true,
          pagination: {
              el: '.swiper-pagination',
              clickable: true,
          },
  
          navigation: {
              nextEl: '.swiper-button-next',
              prevEl: '.swiper-button-prev',
          },
  
          on: {
              progress: function() {
                  var swiper = this;
                  for (var i = 0; i < swiper.slides.length; i++) {
                      var slideProgress = swiper.slides[i].progress;
                      var innerOffset = swiper.width * interleaveOffset;
                      var innerTranslate = slideProgress * innerOffset;
                      swiper.slides[i].querySelector(".slide-inner").style.transform =
                      "translate3d(" + innerTranslate + "px, 0, 0)";
                  }      
              },
  
              touchStart: function() {
                var swiper = this;
                for (var i = 0; i < swiper.slides.length; i++) {
                  swiper.slides[i].style.transition = "";
                }
              },
  
              setTransition: function(speed) {
                  var swiper = this;
                  for (var i = 0; i < swiper.slides.length; i++) {
                      swiper.slides[i].style.transition = speed + "ms";
                      swiper.slides[i].querySelector(".slide-inner").style.transition =
                      speed + "ms";
                  }
              }
          }
      };
  
      var swiper = new Swiper(".swiper-container", swiperOptions);
  
      // DATA BACKGROUND IMAGE
      var sliderBgSetting = $(".slide-bg-image");
      sliderBgSetting.each(function(indx){
          if ($(this).attr("data-background")){
              $(this).css("background-image", "url(" + $(this).data("background") + ")");
          }
      });
  
  
  // =======================================================================
      // card slider js start
  // =======================================================================
  jQuery("#carousel").owlCarousel({
    autoplay: true,
    lazyLoad: true,
    loop: true,
    margin: 0,
     /*
    animateOut: 'fadeOut',
    animateIn: 'fadeIn',
    */
    responsiveClass: true,
    autoHeight: true,
    autoplayTimeout: 7000,
    smartSpeed: 800,
    nav: true,
    responsive: {
      0: {
        items: 1
      },
  
      600: {
        items: 3
      },
  
      1024: {
        items: 4
      },
  
      1366: {
        items: 4
      }
    }
  });
  
  // =======================================================================
      // testimonials js start
  // =======================================================================
  $(document).ready(function(){
    $(".owl-carousel").owlCarousel({
        items:2,
  //      autoplay:false,
        margin:30,
        loop:true,
        dots:true,
        nav:true,
        navText:["<i class='fas fa-long-arrow-alt-left'></i>","<i class='fas fa-long-arrow-alt-right'></i>" ],
        responsive: {
                        0: {
                          items: 1
                        },
                        768: {
                          items: 1
                        },
                        1170: {
                          items: 2
                        }
                      }
    });
  });
  
  // =======================================================================
      // banner scroll js start
  // =======================================================================
  $(function() {
      $('a[href*=#]:not([href=#])').click(function() {
          var target = $(this.hash);
          target = target.length ? target : $('[name=' + this.hash.substr(1) +']');
          if (target.length) {
              $('html,body').animate({
                scrollTop: target.offset().top
              }, 1000);
              return false;
          }
      });
    });
  
  // =======================================================================
      // thumb gallery slider js start
  // =======================================================================
  
  $(".mini img").click(function() {
          $(".maxi").attr("src", $(this).attr("src").replace("100x100", "400x400"));
      });
  
  // =======================================================================
      // number spinner js start
  // =======================================================================
  
  $(document).ready(function() {
          $('.num-in span').click(function() {
              var $input = $(this).parents('.num-block').find('input.in-num');
              if($(this).hasClass('minus')) {
                  var count = parseFloat($input.val()) - 1;
                  count = count < 1 ? 1 : count;
                  if(count < 2) {
                      $(this).addClass('dis');
                  } else {
                      $(this).removeClass('dis');
                  }
                  $input.val(count);
              } else {
                  var count = parseFloat($input.val()) + 1
                  $input.val(count);
                  if(count > 1) {
                      $(this).parents('.num-block').find(('.minus')).removeClass('dis');
                  }
              }
              $input.change();
              return false;
          });
      });
  
  // =======================================================================
      // shop details tab js start
  // =======================================================================
  $(function() {
    $('.tabs-nav a').click(function() {
  
      // Check for active
      $('.tabs-nav li').removeClass('active');
      $(this).parent().addClass('active');
  
      // Display active tab
      let currentTab = $(this).attr('href');
      $('.tabs-content div').hide();
      $(currentTab).show();
  
      return false;
    });
  });
  // =======================================================================
      // light js start
  // =======================================================================
  
  $(document).ready(function() {
              var $gallery = $('#gallery');
              var $boxes = $('.revGallery-anchor');
              $boxes.hide(); 
  
              $gallery.imagesLoaded( {background: true}, function() {
              $boxes.fadeIn();
  
                  $gallery.isotope({
                      // options
                      sortBy : 'original-order',
                      layoutMode: 'fitRows',
                      itemSelector: '.revGallery-anchor',
                      stagger: 30,
                  });
              }); 
  
              $('button').on( 'click', function() {
                  var filterValue = $(this).attr('data-filter');
                  $('#gallery').isotope({ filter: filterValue });
                  $gallery.data('lightGallery').destroy(true);
                  $gallery.lightGallery({
                      selector: filterValue.replace('*','')
                  });
              });
  });
  
  $(document).ready(function() {
              $("#gallery").lightGallery({
              
  }); 
          });
  
  //button active mode
  $('.button').click(function(){
      $('.button').removeClass('is-checked');
      $(this).addClass('is-checked');
  });
  
  
  //CSS Gram Filters on Mouse enter
  $("#gallery a .nak-gallery-poster").addClass("inkwell");
  
  $("#gallery a").on({
    mouseenter : function() {
        $(this).find(".nak-gallery-poster").removeClass("inkwell").addClass("walden");
    },
    mouseleave : function() {
        $(this).find(".nak-gallery-poster").removeClass("walden").addClass("inkwell");
    }
  }); 
  // =======================================================================
      // details like js
  // =======================================================================
  
  $('.btn-counter').on('click', function(event, count) {
    event.preventDefault();
    
    var $this = $(this),
        count = $this.attr('data-count'),
        active = $this.hasClass('active'),
        multiple = $this.hasClass('multiple-count');
  
    $.fn.noop = $.noop;
    $this.attr('data-count', ! active || multiple ? ++count : --count  )[multiple ? 'noop' : 'toggleClass']('active');
    
  });
  
  // =======================================================================
      // details like js
  // =======================================================================
  var selector = '.nav li';
  
  $(selector).on('click', function(){
      $(selector).removeClass('active');
      $(this).addClass('active');
  });
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  