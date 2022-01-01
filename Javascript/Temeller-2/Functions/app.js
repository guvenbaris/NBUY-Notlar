//Fonksion Tanımlama 

// function merhaba(name="Bilgi yok",age="Bilgi yok"){ //default params
//     // if(typeof name === "undefined") name ="Bilgi Yok";
//     // if(typeof age === "undefined") age ="Bilgi Yok";

//     console.log(`İsim ${name} Yaş : ${age}`)
// }

// merhaba("Murat",25); // Function call


// function square(x) {
//     console.log(x*x);
//     return x*x;
// }

// function cube(x){
//     console.log(x*x*x);
//     return x*x*x;
// }

// let a = cube(square(12));

// console.log(a);


// function merhaba(){
//     return "Merhaba"
// }
// console.log(merhaba())

//Funciton Expression
// const merhaba = function(name){
//     console.log("Merhaba" + name);
// }
// merhaba();

//Immediately Invoked Function Expression (IIFE)
// tanımlandığı yerde çalışan function türüdür.
// Methodun alacağı değerleri en son da parantez içerisinde
//veriyoruz
// (function(name){
//     console.log("Merhaba : "+name);
// })("Murat");



//Objectlerimiz ile function kullanımı
const database = {
    host:"localhost",
    add:function(){
        console.log("Eklendi")
    },
    get:function(){
        console.log("Elde edildi")
    },
    update:function(id){
        console.log(`Id : ${id} Güncellendi`);
    },
    delete:function(id){
        console.log(`Id : ${id} Silindi`);
    },
}
console.log(database.host);
database.add();

database.delete(10);
