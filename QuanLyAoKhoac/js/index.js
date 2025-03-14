var img = [
    "img/7.jpg",
    "img/3.png",
    "img/4.jpg",
];
var num = 0;

function next() {
    var slider = document.getElementById("slider")
    num++;
    if (num < img.length) {
        num = 0;
    }
    slider.src = img[num];
}
function prev() {
    var slider = document.getElementById("slider")
    num--;
    if (num < 0) {
        num = img.length - 1;
    }
    slider.src = img[num]
}
setInterval("prev()", 4000);
$(document).ready(function () {
    $(window).scroll(function () {
        if ($(this).scrollTop()) {
            $('header').addClass('sticky');
        } else {
            $('header').removeClass('sticky');
        }
    });
});
/*menu---------------------------------*/
const itemsliderbar = document.querySelectorAll(".cartegory-left-li")
itemsliderbar.forEach(function (menu, index) {
    menu.addEventListener("click", function () {
        menu.classList.toggle("block")
    })
})
/*product---------------------------------*/
const bigimg = document.querySelector(".product-content-left-big-img img")
const smallimg = document.querySelectorAll(".product-content-left-small-img img")
smallimg.forEach(function (imgitem, X) {
    imgitem.addEventListener("click", function () {
        bigimg.src = imgitem.src
    })
})




const uudai = document.querySelector(".uudai")
const chitiet = document.querySelector(".chitiet")
if (uudai) {
    uudai.addEventListener("click", function () {
        document.querySelector(".product-content-right-bottom-content-chitiet").style.display = "none"
        document.querySelector(".product-content-right-bottom-content-uudai").style.display = "block"
    })
}
if (chitiet) {
    chitiet.addEventListener("click", function () {
        document.querySelector(".product-content-right-bottom-content-chitiet").style.display = "block"
        document.querySelector(".product-content-right-bottom-content-uudai").style.display = "none"
    })
}
const button = document.querySelector(".product-content-right-bottom-top")
if (button) {
    button.addEventListener("click", function () {
        document.querySelector(".product-content-right-bottom-content-big").classList.toggle("activeB")
    })
}
