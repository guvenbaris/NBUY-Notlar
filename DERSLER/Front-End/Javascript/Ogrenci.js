class Ogrenci {
    constructor(name)
    {
        this.name = name;
    }

    sayHi(){
        console.log(this.name)
    }
}

let ogr = new Ogrenci("Kamil");
ogr.sayHi();

let header = document.getElementById("Header");
header.innerHTML = "Hayat sana güzel javascript"


