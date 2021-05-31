
var shHeight;
var shWidth;
var shLength;
var typeIndex = 1;

var fitPrice = 0;
var GlPrice = 0;

function setGlPrice(price) {
    GlPrice = price;        //Set Glass price
    //alert(GlPrice);
}

function setFitPrice(price) {
    fitPrice = price;       //Set fit price
    //alert(fitPrice);
}

function mCalculate(w, h, l, index, fit, gl) {      // main calc function 
    var lrWalls = ((w * h) / 1000000) * index;
    var frontWall = ((l * h) / 1000000);
    var result = String((frontWall * gl) + (lrWalls * gl) + parseFloat(fit)).replace('.', ',');
    return result + ' \&#8381;';
}

function outCalc(gPr, fPr) {
    $('.CalcResVal').html(mCalculate(shWidth, shHeight, shLength, typeIndex, fPr, gPr));
}

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

    // $('#aspSendGlassType').attr('value');

    $('.BtnCalc').click(function(){
        $('.BtnCalc').removeClass('active');
        $(this).addClass('active');
    });


    $('.onlyNums').val('0');
    $('.onlyNums').attr('readonly', true);
    $('.onlyNums').css('opacity', '0.5');

    $('.BtnCalc').click(function (e) {
        if ($(this).attr('data-state') == 'lSh') {
            typeIndex = 1;
            $('#aspSendShType').attr('value', 'L');
        }
        if ($(this).attr('data-state') == 'uSh') {
            typeIndex = 2;
            $('#aspSendShType').attr('value', 'U');
        }
        if ($(this).attr('data-state') == 'wall') {
            typeIndex = 1;
            $('#aspSendShType').attr('value', 'wall');
        }


        if ($('.BtnCalc.active').attr('id') == 'LockedForChoose') {
            $('.onlyNums').val('0');
            $('.onlyNums').css('opacity', '0.5');
            $('.onlyNums').attr('readonly', true);
            shWidth = $('#widthInput').val();
        }
        else {
            $('.onlyNums').val(shWidth);
            $('.onlyNums').attr('readonly', false);
            $('.onlyNums').css('opacity', '1');
        }
        $('.CalcResVal').html(mCalculate(shWidth, shHeight, shLength, typeIndex, fitPrice, GlPrice));
    });

    $('.glSize input').keyup(function () {
        shWidth = $('#widthInput').val();
        shLength = $('#lengthInput').val();
        shHeight = $('#heightInput').val();
        
        //$('.CalcResVal').html($('.CalcResVal').html() + ' ' + (((shWidth * shLength) * typeIndex) + (shHeight * shLength)) * 1 );
        $('.CalcResVal').html(mCalculate(shWidth, shHeight, shLength, typeIndex, fitPrice, GlPrice));
        /*$('#aspSendShPrice').attr('value', $('.CalcResVal').html().slice(0, -2));*/

        //alert($('#aspSendShPrice').attr('value'));
        //alert($(this).val());
    });

    $('#SendUserOrder').click(function () {
        $('#aspSendShPrice').attr('value', $('.CalcResVal').html().slice(0, -2));
        $('#aspSendGlassType').attr('value', $('#1_select .__select__title').html());
        $('#aspSendGlassTh').attr('value', $('#2_select .__select__title').html());
    });



/*    $('#TypeGlSelector .__select__label').click(function () {
        $('.CalcResVal').html(mCalculate(shWidth, shHeight, shLength, typeIndex, fitPrice, GlPrice));
        //alert(GlPrice);
    });

    $('#GlThSelector .__select__label').click(function () {
        $('.CalcResVal').html(mCalculate(shWidth, shHeight, shLength, typeIndex, fitPrice, GlPrice)); 
        alert(GlPrice);
    });

    $('#FittingsSelector .__select__label').click(function () {
        $('.CalcResVal').html(mCalculate(shWidth, shHeight, shLength, typeIndex, fitPrice, GlPrice)); 
    });
 */

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