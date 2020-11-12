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


});