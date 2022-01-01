//While Döngüleri 

// let i = 0;

// while(i < 10){
//     console.log(i);
//     i++;
// }

// let i = 10;

// while(i > 0){
//     console.log(i);
//     i-=2;
// }

//Break ve Continue
// let i = 0;
// while(i < 10){
//     console.log(i);
//     if(i == 5){
//         break; // Döngüden çık
//     }
//     i++;
// }

// let i = 0;
// while(i < 10){
//     console.log(i);
//     if(i == 3 ||i == 5){
//         i++;
//         continue; 
//     }
//     i++;
// }

//Do While 

// let i = 0;
// //ik seferde do çalışır sonra şarta bakılır.

// do{
// console.log(i);
// i++;
// }while(i < 10);

const langs = ["Python","Javascript","Java"];
// let index = 0;

// while(index < langs.length){
//     console.log(langs[index]);
//     index++;
// }

// for (let i = 0; i < array.length; i++) {
//      console.log(langs[i]);
// }

// langs.forEach((element,index)=>console.log(element,index));

// langs.forEach(function(lang,index){
//     console.log(lang,index);
// })

//Map function

// const users = [
//     {name:"Mustafa",age:25},
//     {name:"Zeynep",age:40},
//     {name:"Ali",age:12},
// ];

// const names = users.map(function(user){
//     return user.name;
// });

// console.log(names);

// users.map(user=>console.log( user.name)); 

//For-In

// const user = {
//     name:"Mustafa",
//     age:25
// };

// for(let key in user){
//     console.log(user[key]);
// }