
function loop1() {

    /*
        Använd en for-loop för att skriva ut alla siffror mellan 5 och 18
    */

    for (let i = 5; i < 18; i++) {
       
        console.log(i);

    }
}

//loop1();

function loop2() {

    /*
        Använd en for-loop för att skriva ut alla siffror mellan 0 och 9
    */
    for (var i = 0; i <5; i++) {
        console.log(i)
    }
}
//loop2()

function loop3() {

    /*
        Använd en forloop för att skriva ut:
            "Siffran 4 är tjusig". 
            "Siffran 5 är tjusig"
            "Siffran 6 är tjusig"
            "Siffran 7 är tjusig"
            "Siffran 8 är tjusig"
    */
    for (var i = 4; i <= 8; i++) {

        console.log("Siffran " + i + " är fin!")
    }
}
loop4();

function loop4() {

    /*
        Lös föregående uppgift men använd en while-loop
    */
    i = 3
    while (i < 8) {


        i++
        console.log("Siffran " + i + " är fin!")
    }

}

function loop5() {

    /*
	    Skapa en array "importantYears" med årtalen 1492, 1789, 1859, 1929
        Använd "for of" för att skriva ut alla årtal
    */
    let importantYears = [1492, 1789, 1859, 1929]
    for (var x of importantYears) {
        console.log(x);
    }
}
loop5()


function loop6() {

    /*
	    Skapa en array "importantYears" med årtalen 1492, 1789, 1859, 1929
	    Använd "for of" för att skriva ut alla årtal med en siffra till vänster:
	    1) 1492
	    2) 1789
	    3) 1859
	    4) 1929
    */
    let importantYears = [1492, 1789, 1859, 1929]
    i = 0
    for (var x of importantYears) {
        
        i++
        console.log(i + ")" + x)
            
    }
}
loop6();

function loop7() {

    /*
	    Samma som sist men avbryt loopen om årtalet är högre än 1800. Ska alltså ge:
	    1) 1492
	    2) 1789
    */
    let importantYears = [1492, 1789, 1859, 1929]
    i = 0
    for (var x of importantYears) {
        if (x > 1800)
            break;
        i++
        console.log(i + ")" + x)

    }
}
loop7()