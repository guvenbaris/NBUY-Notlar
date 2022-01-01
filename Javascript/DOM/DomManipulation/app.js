
let value;


const todoList = document.querySelector(".list-group");
const todo = document.querySelector(".list-group-item:nth-child(2)");
const cardRow = document.querySelector(".card-row");

value = todoList;
value = todo;
value = cardRow;

//Child Nodes // satır atlamalarını sayıyor.
value = todoList.childNodes;
value = todoList.childNodes[0];

//Children - Element Sadece element olanları alacak 
value = todoList.children;
value = todoList.children[0];

value = todoList.children[2].textContent = "Değişti";

value = cardRow;

value = cardRow.children[2].children[1].textContent = "Burası da değişti...";

value = todoList;

value = todoList.children[0];
value = todoList.firstElementChild; // ilk çocuğu al
value = todoList.lastElementChild; // son çocuğu al
value = todoList.children.length;
value = todoList.childElementCount;

value = cardRow;

value = cardRow.parentElement;
value = cardRow.parentElement.parentElement;


//Element kardeşleri
value = todo;
value = todo.previousElementSibling; // Bir önceki kardeş
value = todo.nextElementSibling; // Bir sonraki kardeş

value = tood.nextElementSibling.nextElementSibling;

value = todo.previousElementSibling.previousElementSibling; // null başka önce ki kardeş yok 



console.log(value);
