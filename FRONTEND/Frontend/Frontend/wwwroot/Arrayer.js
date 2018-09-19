let c = console.log

function arr1() {

    /*
        I---------I---------I---------I
        0         1         2         3
    
        Skapa en array "cities" med städerna Stockholm, Göteborg och New York
        Skriv ut det första, andra och tredje elementet i arrayen
        Vad händer om du försöker komma åt det fjärde elementet (som inte finns)?
    */
    let cities = ["Stockholm", "Göteborg", "New York"]
    console.log(cities)
    c(cities)
    c(cities[3])
}
arr1()

function arr2() {

    /*
        Skapa en array "cities" med städerna Stockholm, Göteborg och New York
	    Lägg till en till stad "Krakow" mha "push"
	    Skriv ut det fjärde elementet i "cities" ("Krakow")
    */
    let cities = ["Stockholm", "Göteborg", "New York"]
    cities.push("Krakow")
    c(cities)

}
arr2()

function arr3() {
    /*
	    Skapa en array "cities" med städerna Stockholm, Göteborg och New York
	    Lägg till en till stad "Krakow" mha "push"
	    Lägg till ytterligare en till stad "Berlin" mha "push" 
	    Skriv ut "Det finns XXX städer i arrayen"
	    Plocka ut den andra och fjärde staden i listan. Skriv ut "Mina favoritstäder är Göteborg och Krakow"
    */
    let cities = ["Stockholm", "Göteborg", "New York"]
    cities.push("Krakow")
    cities.push("Berlin")
    c(`Det finns ${cities.length} städer i arrayen`)
    c(" Mina favoritstäder är " + cities[1] + "  " + cities[3])

}
arr3()

function arr4() {

    /*
	    Skapa en array "cities" med städerna Stockholm, Göteborg och New York
	    Använd "pop" för att plocka ut den sista staden och placera i en variabel "poppedCity"
	    Skriv ut längen av listan (2)
	    Skriv ut den poppade staden (New York)
	    Använd cities.length för att plocka ut det sista elementet i listan (Göteborg)
    */
    let cities = ["Stockholm", "Göteborg", "New York"]
    let poppedCity = cities.pop()
    c(cities.length)
    c(poppedCity)
    c(cities.length)
    c(cities[cities.length-1])
}
arr4()

function arr5() {

    /*
	    Skapa en array "numbers" med talen 5,66,777,12
	    Skriv ut antalet nummer i listan (4)
	    Skriv ut det tredje numret i listan (777)
    */
    let numbers = [5,66,777,12]
    c(numbers.length)
    c(numbers[2])
}
arr5()
arr6()

function arr6() {

    /*
	    Skapa en array "numbers" med talen 5,66,777,12
        Sortera talen genom att skriva: numbers.sort();
	    Sortera talen genom att skriva: numbers.sort( (a,b) => a-b );
	    Skriv ut värdet av "numbers"
        Jämför de två resultaten
    */
    let numbers = [5,66,777,12]
     c(numbers)

    let sortedArray = numbers.sort()

    c(sortedArray)
    c(numbers.sort( (a,b) => a-b))

}

arr7()
function arr7() {

    /*
        Sortera listan baklänges
    */
    let numbers = [5, 66, 777, 12];
    numbers.sort((a, b) => b - a);
    console.log(numbers);
}

function arr8() {

    /*
	    Skapa en array "numbers" med talen 5,66,777,12
	    Vänd på ordningen mha "reverse"
	    Skriv ut arrayen ([ 12, 777, 66, 5 ])
    */
    let numbers = [5, 66, 777, 12];
    //let re = numbers
    c(numbers.reverse())

}
arr8()