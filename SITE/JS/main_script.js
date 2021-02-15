jQuery(function($){
    $("input[type='phone']").mask("+7 (999) 999-99-99");
 });

  function myFunction(element) {
    var $temp = $("<input>");
    $("body").append($temp);
    $temp.val($(element).text()).select();
    document.execCommand("copy");
    $temp.remove();
  }


$(document).ready(function() {
   
    $('#border_svg, #Front, #Back, .cls-bordder-1, .cls-bordder-2, .cls-bordder-3, .cls-bordder-4, .cls-bordder-5, .cls-bordder-6, .cls-bordder-7, .cls-bordder-8, .cls-bordder-9, .cls-bordder-10, .cls-bordder-11, .cls-bordder-12, .cls-bordder-13, .cls-bordder-14').addClass('active');
    
    $("#CalcBtn, #headerNavLinkCalc").click(function (e) { 
        $('.headerNavigationBlock, #ChooseForm, .leftContent, .buttonBtm, #BackWall').addClass('active');
    });

    $("#BackWall, .close_svg").click(function (e) { 
        $('.headerNavigationBlock, #ChooseForm, .leftContent, .buttonBtm, #BackWall').removeClass('active')
        $('#BackWall, .popup, .PlacePop').removeClass('CallPop');
        $('.chooseBlock').removeClass('active');
        $('.aboutBlock').removeClass('active');      
    });

    $("#CallBtn, #call_svg").click(function (e) { 
        $('#BackWall, .popup').addClass('CallPop'); 
        $('.aboutBlock').removeClass('active');     
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

    
    $(".back_click").click(function (e) { 
        $('.aboutBlock').removeClass('active'); 
        $('.chooseBlock').addClass('active');
        $('.PlacePop').addClass('active'); 
    });

    $(".ico_img_about").mouseenter(function (e) {
        if(this.id == 'mail_svg')
            $('#about_choosed_type').text("Отправить email");
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

});