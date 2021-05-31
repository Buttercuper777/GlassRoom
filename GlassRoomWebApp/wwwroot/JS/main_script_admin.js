
function HeaderDate(){
    let days = ['Вс', 'Пн', 'Вт', 'Ср', 'Чт', 'Пт', 'Сб'];

    var time = new Date();
    var y = time.getUTCFullYear().toString();
    var mth = (time.getUTCMonth() + 1).toString();
    var d = time.getDay();
    var dateVal = time.getDate();

    if(d.length < 2) {
        d = '0' + d;
    }

    if(mth.length < 2) {
        mth = '0' + mth;
    }
    return DateString = days[d] + ', ' + dateVal.toString() + '.' + mth + ' ' + y;
}

function HeaderClock(){

    var time = new Date();

    var h = (time.getHours()).toString();
    var m = time.getMinutes().toString();
    var s = time.getSeconds().toString();

    if(h.length < 2) {
        h = '0' + h;
    }

    if(m.length < 2) {
        m = '0' + m;
    }

    if(s.length < 2) {
        s = '0' + s;
    }

     return ClockString = h + ':' + m + ':' + s;
}

function ready()
{
    var inputs = document.querySelectorAll('.inputFile');
    Array.prototype.forEach.call(inputs, function(input)
    {
        var label = input.nextElementSibling;
        labelVal = label.innerHTML;

        input.addEventListener('change', function(e)
        {
            console.log(this.files);
            var FileName = '';
            if(this.files && this.files.length > 1)
            {
                FileName = this.files.length.toString() + ' Файлов выбрано';
            }
            else
            {
                FileName = this.files[0].name;
            }

            if(FileName)
                label.querySelector( 'span' ).innerHTML = FileName;
            else
                label.innerHTML = labelVal;
        });
    });
}

function delay(callback, ms) {
    var timer = 0;
    return function () {
        var context = this, args = arguments;
        clearTimeout(timer);
        timer = setTimeout(function () {
            callback.apply(context, args);
        }, ms || 0);
    };
}

var urlSend = window.location + '/' + 'SendNote';
var urlGet = window.location + '/' + 'GetNote';

$(document).ready(function () { 
    $(function() {
        ChangeClockVal();
        ready();
    
        function ChangeClockVal() {
           setTimeout(ChangeClockVal,1000);
           $('#ClockHeader').text(HeaderClock());
        }
    });

    $('#DateHeader').text(HeaderDate());

    $('.not_available').on('click', function(){
        $('#HelloAndError').text("⛔️ - Данная функция пока недоступна для использования!");
    });

    $('#selectAll').on('click', function(){
        if($("input[type=checkbox]").prop('checked') == true){
            $(this).prop('value', 'Выделить все');
            $("input[type=checkbox]").prop('checked', false);
        }
        else{
            $(this).prop('value', 'Снять выделение');
            $("input[type=checkbox]").prop('checked', true);  
        }
    });

    $('#UsPhoneCopy').on('click', function() {
        alert('sdcsdcds');
        this.css('background', '#0ca926');
    });

    var sliderChecker = 0;
    var senderChecker = 0;


    $('.OrderDataSlider').slideUp(0);
    $('.MainContentAdmin ul li').click(function () {
        if (sliderChecker == 0) {
            $(this).children('.OrderDataSlider').slideDown(400);
            var idGet = $($(this).children('.OrderDataSlider')).attr('name');
            var taObj = $($(this).children('.OrderDataSlider').children('.areaInput'));

            $.ajax({        // Get Order Note
                type: "POST",
                url: urlGet,
                data: { id: idGet },
                dataType: "text",
                success: function (result) {

                    taObj.val(result);
                    console.log("ID: " + idSend + " Note received!");
                },
                error: function (e) {
                    console.log("Error: Get note)");
                }
            });
        }
        sliderChecker = 0;
    });

    $('.SliderCloser').click(function () {
        $(this).parent('.OrderDataSlider').slideUp();
        sliderChecker = 1;
    });

    $('.OrderDataSlider textarea').keyup(function () {
        $(this).removeClass('active');
    });

    $('.OrderDataSlider textarea').keyup(delay(function (e) {
        //alert(this.value);
        $(this).addClass('active');
        var idSend = $($(this).parent('.OrderDataSlider')).attr('name');
        //alert(idSend);

        $.ajax({    // Send Order Note
            type: "POST",
            url: urlSend,
            data: { id: idSend, Data: (this.value) },
            dataType: "text",
            success: function (result) {
                //alert('1'); 
                console.log("ID: " + idSend + " Updated!");
            },
            error: function (e) {
                console.log("Error: Send note)");
            }
        });

    }, 1500));

});
