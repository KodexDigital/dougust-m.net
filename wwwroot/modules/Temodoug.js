$('.popup-with-zoom-anim').magnificPopup({
	type: 'inline',
	fixedContentPos: false,
	fixedBgPos: true,
	overflowY: 'auto',
	closeBtnInside: true,
	preloader: false,
	midClick: true,
	removalDelay: 300,
	mainClass: 'my-mfp-zoom-in'
});

$('#slideshow-banner').slide({
	cdTime: 5000,
	controllerLeftButton: "images/left.png",
	controllerRightButton: "images/right.png"
});

// Display the progress bar calling progressbar.js
$('.progressbarPhp').progressBar({
	shadow: true,
	percentage: false,
	animation: true,
	animateTarget: true,
	barColor: "rgb(86, 79, 77)",
});
//Menu
$(".spinDown").click(function () {
	var target = $(this).data("target");
	var scrollFix = -80;
	target = "#" + target;
	$("html,body").animate({
		scrollTop: $(target).offset().top + scrollFix
	}, 1000);
	return false;
});