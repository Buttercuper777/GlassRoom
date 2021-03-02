$(document).ready(function(){ 
    var mob_line_op_val = $('.line').css("opacity");

    $('.home_button_anchor').css("opacity", 0)
    $(window).scroll(function(){ 
        $('.ContentSpace').css("opacity", 1- $(window).scrollTop() / 550) 
        $('.home_button_anchor').css("opacity", 0 + $(window).scrollTop() / 550) 
    }) 

    $('body').scroll(function(){
        $('.line').css("opacity", mob_line_op_val - $('body').scrollTop() / 550) 
    })

const anchors = document.querySelectorAll('a[href^="#"]')

// Цикл по всем ссылкам
for(let anchor of anchors) {
  anchor.addEventListener("click", function(e) {
    e.preventDefault() // Предотвратить стандартное поведение ссылок
    // Атрибут href у ссылки, если его нет то перейти к body (наверх не плавно)
    const goto = anchor.hasAttribute('href') ? anchor.getAttribute('href') : 'body'
    // Плавная прокрутка до элемента с id = href у ссылки
    document.querySelector(goto).scrollIntoView({
      behavior: "smooth",
      block: "start"
    })
  })
}
})
