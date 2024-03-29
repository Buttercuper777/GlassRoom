function validatePhone(phone) {
    let regex = /^(\+7|7|8)?[\s\-]?\(?[489][0-9]{2}\)?[\s\-]?[0-9]{3}[\s\-]?[0-9]{2}[\s\-]?[0-9]{2}$/;
    return regex.test(phone);
}

function HeaderNavFunc() {

    var urlStr = window.location.href;

    if (urlStr.indexOf('Services') != -1) {
        $("#main_link").removeAttr("id");
        $(".headerNav a:contains('Каталог')").attr("id", "main_link");
        $(".fs_block").css('display', 'none');
    }

    else {
        $("#main_link").removeAttr("id");
        $(".headerNav a:contains('Главная')").attr("id", "main_link");
    }
}

function myFunction(element) { //copy 
    var $temp = $("<input>");
    $("body").append($temp);
    $temp.val($(element).text()).select();
    document.execCommand("copy");
    $temp.remove();
}

var validPhone = 0;
var validName = 0;

var validPhoneOrd = 0;
var validNameOrd = 0;

function CheckInput(button) {
    if ((validName && validPhone == 1) || (validNameOrd && validPhoneOrd == 1)) {
        $(button).removeAttr("disabled");
        $(button).attr('value', 'Отправить')

    }
    else {
        $(button).prop('disabled', true);
        $(button).attr('value', 'Проверьте данные');
    }
}


$(document).ready(function () {

    //----------------------------------------------------------------------------------------
    //-------------------------------------Call Orders----------------------------------------//
    $('#InputNameVal').on('keyup', function () {
        var $this = $(this),
            val = $this.val();
        if (val.length >= 1) {
            validName = 1;
            CheckInput("#SendUserButton");
        } else {
            validName = 0;
            CheckInput("#SendUserButton");
        }
    });

    $('#InputPhoneNumberVal').on('keyup', function () {
        let phone = document.getElementById("InputPhoneNumberVal").value;
        if (!validatePhone(phone)) {
            validPhone = 0;
            CheckInput("#SendUserButton");
        } else {
            validPhone = 1;
            CheckInput("#SendUserButton");
        }
    });

    //---------------------------------------------------------------------------------------------
    //-------------------------------------Product orders----------------------------------------//

    $('.InputNameCheck').on('keyup', function(){
        var $this1 = $(this),
            val = $this1.val();
            
        if(val.length >= 1){
            validNameOrd = 1;
            CheckInput("#SendUserOrder");
        }else {
            validNameOrd = 0;
            CheckInput("#SendUserOrder");
        }
    });
    
    $('.InputMobileCheck').on('keyup',function(){
        var $this = $(this);
        let phone = $this.val();
    
        if (!validatePhone(phone)){
            validPhoneOrd = 0;
            CheckInput("#SendUserOrder");
            }else{
            validPhoneOrd = 1;
            CheckInput("#SendUserOrder");
            }
    });



    //---------------------------------------------------------------------------------------------

    $('.input h1').css("display", "none");

    $('#SendUserButton').click(function (e) {
        $('.pop_input').css("display", "none");
        $('.input h1').css("display", "block");
        $('.popup a').text = "Спасибо!";
    });

    $('#border_svg, #Front, #Back, .cls-bordder-1, .cls-bordder-2, .cls-bordder-3, .cls-bordder-4, .cls-bordder-5, .cls-bordder-6, .cls-bordder-7, .cls-bordder-8, .cls-bordder-9, .cls-bordder-10, .cls-bordder-11, .cls-bordder-12, .cls-bordder-13, .cls-bordder-14').addClass('active');
    //$('#forCalcShow').hide(100);
    $('#forCalcShow, #ChooseForm h3, #ChooseForm p').fadeToggle();

    $("#CalcBtn, #headerNavLinkCalc").click(function (e) { 
        $('.headerNavigationBlock, #ChooseForm, .leftContent, .buttonBtm, #BackWall').addClass('active');
        $('body').css("overflow-y", "hidden");

        //$("#shower_button").click(function (e) {    //activate shower
            $('#_escal').removeClass('active');
            $('.cls-1, .cls-2, .cls-3, .cls-4, .cls-5, .cls-6, .cls-7, .cls-8, .cls-9, .cls-10, .cls-11, .cls-12, .cls-13').removeClass('active');

            $('#bath, .bath_svg, .cls-mask, .border_bath_bottom, .front_wall, .right_wall, .bath_top, .line_bottom, .line_right').addClass('activate');

            $('#border_svg, #Front, #Back, .cls-bordder-1, .cls-bordder-2, .cls-bordder-3, .cls-bordder-4, .cls-bordder-5, .cls-bordder-6, .cls-bordder-7, .cls-bordder-8, .cls-bordder-9, .cls-bordder-10, .cls-bordder-11, .cls-bordder-12, .cls-bordder-13, .cls-bordder-14').removeClass('active');
        //});

        $('#forCalcShow, #ChooseForm h3, #ChooseForm p').delay(400).fadeTo(1000, 1);
    });

    /*$("#CalcBtn, #headerNavLinkCalc").click(function (e) {
        alert('Функция пока недоступна');
    });*/


    $("#BackWall, .close_svg, #calcCloseBtn").click(function (e) { 
        $('#forCalcShow, #ChooseForm h3, #ChooseForm p').fadeTo(100, 0);
        $('.headerNavigationBlock, #ChooseForm, .leftContent, .buttonBtm, #BackWall').removeClass('active')
        $('#BackWall, .popup, .PlacePop').removeClass('CallPop');
        $('#ChooseForm h2').css('display', 'none');
        $('.chooseBlock').removeClass('active');
        $('.aboutBlock').removeClass('active');     
        $('body').css("overflow-y", "auto");

        //$("#border_button").click(function (e) {    //activate border
            $('#border_svg, #Front, #Back, .cls-bordder-1, .cls-bordder-2, .cls-bordder-3, .cls-bordder-4, .cls-bordder-5, .cls-bordder-6, .cls-bordder-7, .cls-bordder-8, .cls-bordder-9, .cls-bordder-10, .cls-bordder-11, .cls-bordder-12, .cls-bordder-13, .cls-bordder-14').addClass('active');

            $('#_escal').removeClass('active');
            $('.cls-1, .cls-2, .cls-3, .cls-4, .cls-5, .cls-6, .cls-7, .cls-8, .cls-9, .cls-10, .cls-11, .cls-12, .cls-13').removeClass('active');

            $('#bath, .bath_svg, .cls-mask, .border_bath_bottom, .front_wall, .right_wall, .bath_top, .line_bottom, .line_right').removeClass('activate');
        //});
    });

    $("#SendUserOrder").click(function () {
        $('#forCalcShow').fadeTo(50, 0);
        $('#forCalcShow').css('display', 'none');
        $('#ChooseForm h2').css('display', 'block');
    });

    $("#CallBtn, #call_svg").click(function (e) { 
        $('#BackWall, .popup').addClass('CallPop'); 
        $('.aboutBlock').removeClass('active');     
        $('.popup_bg').css("height", '100vh');
    });

    $(".headerPlaceBtn").click(function (e) { 
        $('#BackWall, .PlacePop').addClass('CallPop'); 
        $('.chooseBlock').addClass('active');
        $('.PlacePop').addClass('active');       
    });

    $(".aboutPlace").click(function (e) { 
        $('.chooseBlock').addClass('active');
        $('.chooseBlock').removeClass('active');
        $('.PlacePop').removeClass('active'); 
        $('.aboutBlock').addClass('active');   
    });

    $("#contacts_menu_click, #ProdOpenContacts").click(function (e) { 
        $('.chooseBlock').addClass('active');
        $('#BackWall, .PlacePop').addClass('CallPop'); 
        $('.chooseBlock').addClass('active');
        $('.PlacePop').addClass('active');    
        $('.chooseBlock').removeClass('active');
        $('.PlacePop').removeClass('active'); 
        $('.aboutBlock').addClass('active'); 
        $('.popup_bg').css("height", '100vh');
    });
    
    
    $(".back_click").click(function (e) { 
        $('.aboutBlock').removeClass('active'); 
        $('.chooseBlock').addClass('active');
        $('.PlacePop').addClass('active'); 
        $('.popup_bg').css('display', 'none');
        $('.popup_bg').css("height", '0vh');
    });

    $(".ico_img_about").mouseenter(function (e) {
        if(this.id == 'mail_svg')
            $('#about_choosed_type').text("Отправить E-Mail");
        if(this.id == 'call_svg')
            $('#about_choosed_type').text("Заказать звонок");
        if(this.id == 'phone_svg')
            $('#about_choosed_type').text("Позвонить нам");
    });

    $("#phone_svg").click(function (e) { 
        alert("+7 (918) 982-91-53");
    });

    $("#mail_svg").click(function (e) { 
        alert("steklopro23@mail.ru \nАдрес скопирован в буфер обмена");
    });

    $("#border_button").click(function (e) {    //activate border
        $('#border_svg, #Front, #Back, .cls-bordder-1, .cls-bordder-2, .cls-bordder-3, .cls-bordder-4, .cls-bordder-5, .cls-bordder-6, .cls-bordder-7, .cls-bordder-8, .cls-bordder-9, .cls-bordder-10, .cls-bordder-11, .cls-bordder-12, .cls-bordder-13, .cls-bordder-14').addClass('active');
    
        $('#_escal').removeClass('active');
        $('.cls-1, .cls-2, .cls-3, .cls-4, .cls-5, .cls-6, .cls-7, .cls-8, .cls-9, .cls-10, .cls-11, .cls-12, .cls-13').removeClass('active');
    
        $('#bath, .bath_svg, .cls-mask, .border_bath_bottom, .front_wall, .right_wall, .bath_top, .line_bottom, .line_right').removeClass('activate');
    });

    $("#shower_button").click(function (e) {    //activate shower
        $('#_escal').removeClass('active');
        $('.cls-1, .cls-2, .cls-3, .cls-4, .cls-5, .cls-6, .cls-7, .cls-8, .cls-9, .cls-10, .cls-11, .cls-12, .cls-13').removeClass('active');
    
        $('#bath, .bath_svg, .cls-mask, .border_bath_bottom, .front_wall, .right_wall, .bath_top, .line_bottom, .line_right').addClass('activate');
    
        $('#border_svg, #Front, #Back, .cls-bordder-1, .cls-bordder-2, .cls-bordder-3, .cls-bordder-4, .cls-bordder-5, .cls-bordder-6, .cls-bordder-7, .cls-bordder-8, .cls-bordder-9, .cls-bordder-10, .cls-bordder-11, .cls-bordder-12, .cls-bordder-13, .cls-bordder-14').removeClass('active');
    });

    $("#more_button").click(function (e) {    //activate escal
        $('#_escal').addClass('active');
        $('.cls-1, .cls-2, .cls-3, .cls-4, .cls-5, .cls-6, .cls-7, .cls-8, .cls-9, .cls-10, .cls-11, .cls-12, .cls-13').addClass('active');
        
        $('#bath, .bath_svg, .cls-mask, .border_bath_bottom, .front_wall, .right_wall, .bath_top, .line_bottom, .line_right').removeClass('activate');
    
        $('#border_svg, #Front, #Back, .cls-bordder-1, .cls-bordder-2, .cls-bordder-3, .cls-bordder-4, .cls-bordder-5, .cls-bordder-6, .cls-bordder-7, .cls-bordder-8, .cls-bordder-9, .cls-bordder-10, .cls-bordder-11, .cls-bordder-12, .cls-bordder-13, .cls-bordder-14').removeClass('active');
    });




    $(function(){                               // Load big img. Upload from gallery
        var wrapper = $('.list_img');
        wrapper = wrapper.find('li:first-child img').attr('src');

        if (window.innerHeight > window.innerWidth){
            $('.list_img').find('li:first-child').css("border", "solid 0.7vw #fff");
            $('.img_product img').attr('src', wrapper);
        }
        else{
            $('.list_img').find('li:first-child').css("border", "solid 3px #fff");
            $('.img_product img').attr('src', wrapper);     
        }

    });

    //--------------------------------------------------------------------------------

    $('.list_img img').click(function(e){   // gallery product place 

        if (window.innerHeight > window.innerWidth){
            $('.list_img').find('li').css("border", "solid 0.3vw #fff");
            $(this).parent().css("border", "solid 0.7vw #fff");
        }
        else{
            $('.list_img').find('li').css("border", "solid 1px #fff");
            $(this).parent().css("border", "solid 3px #fff");    
        }

        if ($('.img_product img').attr('src') != $(this).attr('src')){
            
           $('.img_product img').attr('src', $(this).attr('src'));
        }
    });


    HeaderNavFunc();

});