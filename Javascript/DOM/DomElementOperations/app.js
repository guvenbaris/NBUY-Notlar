
// Yeni Element oluşturma 
// <a id = "clear-todos" class="btn btn-dark" href="#">Tüm Taskları Temizleyin</a>         


//////////////////////////////////////////
////Text-Content ve Text-Node Farkı /////
////////////////////////////////////////

// Text Content
// Eklendiğinde diğer bütün içerikler silinir sadece eklediğin
//text content yazar. Dikkatli kullan

//Text Node
// Text'i istediğimiz her yere ekleyebiliriz.

// const text = document.createTextNode("Naber");
// cardbody.appendChild(text);

// const newLink = document.createElement("a");

// const cardbody = document.getElementsByClassName("card-body")[1];
// newLink.id="clear-todos";
// newLink.className ="btn btn-danger";
// newLink.href = "https://www.google.com";
// newLink.target="_blank";

// newLink.appendChild(document.createTextNode("Farklı Sayfaya Git"));
// cardbody.appendChild(newLink);

// console.log(newLink);



//////////////////////////////
////Dinamik ELement Silme////
////////////////////////////
// const todoList = document.querySelector("ul.list-group");
// const todos  = document.querySelectorAll("li.list-group-item");


// Remove Metodu
// todos[0].remove();

// Remove Child
// todoList.removeChild(todoList.lastElementChild);
// todoList.removeChild(todos[3]);



// console.log(todoList)
// console.log(todos)

///////////////////////////////////////
////Dinamik ELementleri Değiştirme////
/////////////////////////////////////

// const cardbody = document.querySelectorAll(".card-body")[1];

// const newElement = document.createElement("h3");
// newElement.className = "card-title";
// newElement.id="tasks-title";
// newElement.textContent="Yeni Todolar";

// const oldElement = document.querySelector("#tasks-title")

// cardbody.replaceChild(newElement,oldElement);

// console.log(newElement);


////////////////////////////////////
////Dinamik Attribute Değiştirme///
//////////////////////////////////

const todoInput = document.getElementById("todo");

let element ;


element = todoInput;

element = todoInput.classList;

// todoInput.className = "form-control newClass";
// todoInput.classList.add("newClass");
// todoInput.classList.add("newClass2");
// todoInput.classList.remove("newClass2");

element = todoInput.ariaPlaceholder;



console.log(element);
