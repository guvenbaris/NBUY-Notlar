// Element Id'e göre seçme

let element ;

element = document.getElementById("todo-form");

element = document.getElementById("tasks-title");

// Element Class'a göre seçme
element = document.getElementsByClassName("list-group-item")[0]

element = document.getElementsByClassName("card-header")

//Element Tag'e göre saçma

element = document.getElementsByName("div");


//Query Selector - Css Selector - Tek Bir Element

element = document.querySelector("#todo-form");
element = document.querySelector("#tasks-title");

element = document.querySelector(".list-group-item");

element = document.querySelector("li");
element = document.querySelector("div");


//Query SelectorAll -- Tüm Elementleri Seç

element = document.querySelectorAll(".list-group-item");

element.forEach(function(el){
    console.log(el);
})


console.log(element);