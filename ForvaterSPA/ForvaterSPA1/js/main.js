/*Script для header'а*/
$(document).ready(function () {
    $('.header').height($(window).height());
/*Скрип реализация Slick Carousel*/
	$('.carousel').slick({
		infinite: true,
		dots: true,
		slidesToShow: 3,
		slidesToScroll: 1,
		autoplay: true,
		autoplaySpeed: 2000,
		responsive: [
			{
				breakpoint: 768,
				settings: {
					slidesToShow: 2,
				}
			},
			{
				breakpoint: 480,
				settings: {
					slidesToShow: 1,
				}
			}
		]
	});
})
