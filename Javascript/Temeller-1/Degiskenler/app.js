// var a = 20;
// var b = 10;
// var c = 40;    
// console.log(a,b,c); 

//Primitive 

// var a = 10; 
// var b = 3.14;
// console.log(a);
// console.log(typeof a);

// var name = "Mustafa";
// console.log(name);

// var a = true;

// var a = null;
// console.log(a);
// console.log(typeof a);

// var a;
// console.log(a); // undefined
 
//Reference Veri Tipleri

//object olan bütün herşey reference tiptir.
// var numbers = [1,2,3,4,5];
// console.log(numbers);
// console.log(typeof numbers);

// var person = {
//     name:"Mustafa Murat",
//     age : 25
// }
// console.log(person);
// console.log(typeof person);

// var date = new Date();
// console.log(date);
// console.log(typeof date);

// var merhaba = function(){
//     console.log("Merhaba")
// }
// console.log(merhaba);
// console.log(typeof merhaba);

// var a = 10;

// var b = a;

// console.log(a,b);

// a= 20;

// console.log(a,b);

// Reference bellekte bir değeri gösteren veridir. Başlangıç noktası
var a = [1,2,3];

var b = a;

a.push(4);

console.log(b);