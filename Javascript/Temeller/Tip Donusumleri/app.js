let value;

// veri tiplerini string'e çevirme

value = String(123);
value = String(3.14);
value = String(true);
value = String(false);
value = String(function () {
  console.log();
});
value = String([1, 2, 3, 4]);

value = (10).toString();

// Veritiplerini sayılara çevirme
value = Number("123");
value = Number(null);
value = Number(undefined);
value = Number("Hello");
value = Number(function () {
  console.log();
});

value = parseFloat("3.14");
value = parseInt("3");

const a = "Hello" + 34;


console.log(a);
console.log(typeof a);

console.log(value);
console.log(typeof value);
