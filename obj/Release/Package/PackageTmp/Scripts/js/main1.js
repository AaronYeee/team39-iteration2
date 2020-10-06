

// Single Img slder
$('.services-active').slick({
    dots: false,
    infinite: true,
    autoplay: true,
    speed: 400,
    arrows: true,
    prevArrow: '<button type="button" class="slick-prev" ><span class="icon-caret-left"></span></button>',
    nextArrow: '<button type="button" class="slick-next" ><span class="icon-caret-right"></span></i></button>',
    slidesToShow: 3,
    slidesToScroll: 1,
    responsive: [
        {
            breakpoint: 1024,
            settings: {
                slidesToShow: 3,
                slidesToScroll: 1,
                infinite: true,
                dots: false,
            }
        },
        {
            breakpoint: 992,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 1,
                infinite: true,
                dots: false,
            }
        },
        {
            breakpoint: 768,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 1,
                arrows: true
            }
        },
        {
            breakpoint: 480,
            settings: {
                slidesToShow: 1,
                slidesToScroll: 1,
                arrows: false
            }
        },
    ]
});

