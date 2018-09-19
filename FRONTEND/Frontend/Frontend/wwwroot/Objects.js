

function obj1() {

    /*
        Skapa ett objekt "person" med uppgifter om Johan Rheborg: förnamn, efternamn, födelseår
        Skriv ut förnamnet
        Skriv ut hans fullständiga namn
    */
    let person = {
        FirstName: "Johan",
        LastName: "Rheborg",
        Birthdate: 1963
    }
    console.log(person.FirstName);
    console.log(person.Birthdate);
}
//obj1()
//obj2()
function obj2() {

    /*
       Fortsätt bygg vidare på "person"
       Lägg till ett par rollkaraktärer (Percy Nilegård, Farbror Barbro...)
       Lägg till adressuppgifter (street, city, country)
       Skriv ut info om Johan utifrån objektet "person":
            Johan är född år 1963
            Johan bor på gatan Kammakargatan 38 lgh 1401
            Johan har spelat 3 roller, bland annat Percy Nilegård
    */
    let person = {
        FirstName: "Johan",
        LastName: "Rheborg",
        Birthdate: 1963,
        Characters: ["Percy Nilegård", "Farbror Barbro"],
        Adress: {
            Street: "Kammakargatan 38",
            City: "Stockholm",
            Country: "Sweden"
        }
    }
    console.log("Johan är född år " + person.Birthdate);
    console.log("Johan bor på " + person.Adress.Street);
    console.log("Han har spelat " + person.Characters.length + " bland annat " + person.Characters[0]);
}


function obj3() {

    /*
       Skapa en array "paintings" med tre målningar (tre element)
       För varje målning finns info: namn, konstnär och året den blev målad
       Skriv ut antalet målningar: "Det finns XXXst målningar"
       Skriv ut den tredje målningen t.ex: "Pablo Picasso målade Guernica år 1937"
       Loopa igenom alla målningar med "for of" och skriv ut all info i tabellform
       Tips: använd "padEnd" för att skriva ut tabellen snyggt
    */
    let paintings = [{
        name: "Mona Lisa",
        artist: "Pablo Picasso",
        yearPainted: 1623
    }, {
        name: "Nattvarden", 
            artist: "Leo Da Vinci",
            yearPainted: 1723
        }
        , {
            name: "Vitruvianske Mannen",
            artist: "Johan",
            yearPainted: 1993
        }]

    console.log("Det finns " + paintings.length + " mälningar!");
    console.log(paintings[2].artist + "målade " + paintings[2].name + "år" + paintings[2].yearPainted);

    for (let x of paintings) {
        console.log(x.name + x.artist + x.yearPainted.padEnd());
    }

}
obj3()

function obj4() {

    /*
       Skapa ett objekt "skriet" (av Edvard Munch 1893). Lägg till den i paintingsarrayen mha "push".
       Skriv ut dess år mha variablen "paintings" 
       Använd "pop" för att plocka bort de tre sista målningarna
       Skriv ut antalet målningar i arrayen 
    */

}

// -------- EXTRA UPPGIFTER -----------------------------------------

function objExtra1() {

    /*
       Fortsätt bygg vidare på "person"
       Lägg till en metod "fullName" till person
       Lägg till en metod "numberOfRoles" till person
       Används sedan dessa för att skriva ut:
            Johan Rheborg
            Johan Rheborg har spelat i 3 roller
    */
}