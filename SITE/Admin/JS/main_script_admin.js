
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

$(document).ready(function(){ 
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

});
