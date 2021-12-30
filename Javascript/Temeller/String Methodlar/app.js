let value;

const firstName = "Louis";
const lastName ="Armstrong";

const langs = "Java,Python,C++";

value = firstName + lastName;


value = firstName+" " + lastName;

value = "Musta Murat";
value += "Coşkun";

value = firstName.length;
value = firstName.concat(" ",lastName," ","Caz");
value = firstName.toLowerCase();
value = firstName.toUpperCase();

value = firstName[0];
value = firstName[2];

value = firstName[firstName.length-1];

value = firstName.indexOf("L"); // index döner
value = firstName.indexOf("o"); 
value = firstName.indexOf("l"); // yoksa -1

value = firstName.charAt(0);
value = firstName.charAt(firstName.length- 1);


value = langs.split(",");

value = langs.replace("Python","Css");

value = langs.includes("Java"); // içeriyorsa true


console.log(value);