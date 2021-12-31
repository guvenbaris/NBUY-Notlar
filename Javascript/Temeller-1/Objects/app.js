// Object Literal
// let value;
// const programmer = {
//     name : "Mustafa Murat Coşkun",
//     age : 25,
//     email : "gvnbrs54@gmail.com",
//     langs : ["Python","Java","Javascript"],
//     address:{
//         city:"Ankara",
//         street:"Bahçelievler"
//     },
//     work : function(){
//         console.log("Programcı çalışıyor...")
//     }
// }

// value = programmer;

// value = programmer.email;
// value = programmer.langs;
// // value = programmer.address.city;

// // programmer.work();

// const programmers =  [
//     {name:"Mustafa Murat",age:25},
//     {name:"Güven Barış",age:28},
// ]

// value = programmers[1];

// console.log(value);

// Date Object
let value;

const now = new Date(); // Şu an ki zamanı almamızı sağlıyor

const date1 = new Date("5-24-1993 07:15:01");
const date2 = new Date("May 24 1993");
const date3 = new Date("5/24/1993");

value = date1;
value = date1.getMonth();
value = date1.getDate();
value = date1.getDay();


value = date1.getHours();
value = date1.getMinutes();
value = date1.getSeconds();

value = date1.getMilliseconds();

date1.setMonth(7);
date1.setDate(15);
date1.setFullYear(1994);

value =date1;

console.log(value);


