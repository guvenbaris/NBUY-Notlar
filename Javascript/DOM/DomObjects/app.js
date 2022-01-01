//window Object
let value ;

value = document;

value = document.body;

//Scriptler 
value = document.scripts;

//Linkler 
value = document.links;
value = document.links[0];
value = document.links[document.links.length-1];
value = document.links[document.links.length-1].getAttribute("class");
value = document.links[document.links.length-1].getAttribute("href");
value = document.links[document.links.length-1].className;
value = document.links[document.links.length-1].classList;

//Formlar 

value = document.forms;
value = document.forms.length;
value = document.forms[0];
value =  document.forms[0].id;
value = document.forms[0].getAttribute("name");



console.log(value);