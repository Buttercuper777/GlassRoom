$(document).ready(function() {
    $("#CalcBtn").click(function (e) { 
        $('#CalcBtn, #ChooseForm').toggleClass('active');
        $('.headerNavigationBlock').css('transition', '0.5s ease');
        $('.headerNavigationBlock').css('opacity', '0.3');

        $('.leftContent').css('transition', '0.5s ease');
        $('.leftContent').css('opacity', '0.3');

        $('.buttonBtm').css('transition', '0.5s ease');
        $('.buttonBtm').css('opacity', '0.3');

        $('#BackWall').css('transform', 'scale(1)');

        $('.ImageCont').css('opacity', '1');
    });

    $("#BackWall").click(function (e) { 
        $('#CalcBtn, #ChooseForm').toggleClass('active');

        $('.headerNavigationBlock').css('opacity', '1');
        $('.headerNavigationBlock').css('transition', '0');

        $('.leftContent').css('opacity', '1');
        $('.leftContent').css('transition', '0');

        $('.buttonBtm').css('opacity', '1');
        $('.buttonBtm').css('transition', '0');

        $('#BackWall').css('transform', 'scale(0)');

        $('.ImageCont').css('opacity', '1');
    });
});