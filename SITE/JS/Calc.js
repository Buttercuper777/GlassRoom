$(document).ready(function () {

    $('.__select__title').click(function () {
       $('.__select').attr('data-state', '');
        if ('active' == $(this).parent('.__select').attr('data-state')) {
            $(this).parent('.__select').attr('data-state', '');
        }
        else {
            $(this).parent('.__select').attr('data-state', 'active');
        }
    });

    $('.__select__label').click(function(e) {
        //alert($(this).parent('.__select__content').parent('.__select').children('.__select__title').text());
        //alert($(this).parent('.__select__content').parent('.__select').attr('data-state'));
        $(this).parent('.__select__content').parent('.__select').children('.__select__title').html($(this).text());
        $(this).parent('.__select__content').parent('.__select').attr('data-state', '');
    });

    $('.BtnCalc').click(function(){
        $('.BtnCalc').removeClass('active');
        $(this).addClass('active');
    });


    $('.onlyNums').val('0');
    $('.onlyNums').attr('readonly', true);
    $('.onlyNums').css('opacity', '0.5');

    $('.BtnCalc').click(function(e){
    if($('.BtnCalc.active').attr('value') == 'Душевая перегородка')
        {
            $('.onlyNums').val('0');
            $('.onlyNums').css('opacity', '0.5');
            $('.onlyNums').attr('readonly', true);
        }
    else{
            $('.onlyNums').val('');
            $('.onlyNums').attr('readonly', false);
            $('.onlyNums').css('opacity', '1');
        }
    });

    // // Toggle menu
    // selectSingle_title.addEventListener('click', () => {
    //   if ('active' === selectSingle.getAttribute('data-state')) {
    //     selectSingle.setAttribute('data-state', '');
    //   } else {
    //     selectSingle.setAttribute('data-state', 'active');
    //   }
    // });


    // // Close when click to option
    // for (let i = 0; i < selectSingle_labels.length; i++) {
    //   selectSingle_labels[i].addEventListener('click', (evt) => {
    //     selectSingle_title[i].textContent = evt.target.textContent;
    //     selectSingle.setAttribute('data-state', '');
    //   });
    // }

    // // Reset title
    // const reset = document.querySelector('.reset');
    // reset.addEventListener('click', () => {
    //   selectSingle_title.textContent = selectSingle_title.getAttribute('data-default');
    // });

});