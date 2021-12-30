let value;

const numbers = [43, 56, 24, 15];

// const numbers2 = new Array(1,2,3,4,5,6);

const langs = ["Python", "Java", "C++", "Javascript"];

const a = ["Merhaba", 22, null, undefined, 3.14];

value = numbers.length;
value = numbers[0];
value = numbers[1];

value = numbers[numbers.length - 1];

numbers[2] =1000;

value = numbers ;

//Index Of 
value = numbers.indexOf(1000);

numbers.push(2000); // Arrayin sonuna ekleme yapar
value = numbers;

numbers.unshift(3000); // Arayin başına değer ekleme

numbers.pop(); //En sondaki eleamnı atar
value = numbers;

numbers.shift(); //Başındaki eleamnı atar
value = numbers;

// numbers.splice(0,3) // Belirli index aralığın ıatma
value = numbers;

numbers.reverse(); // Tersini alma
value.numbers;

value = numbers.sort();

value = numbers.sort(function(x,y){ // küçükten büyüğe sıralama
    return x - y;
})

value = numbers.sort(function(x,y){ // büyükten küçüğe sıralama
    return y - x;
})
console.log(value);
