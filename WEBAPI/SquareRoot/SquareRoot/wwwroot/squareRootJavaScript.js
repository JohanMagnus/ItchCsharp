

let errorMessage = "";
let result = "";

function render() {
    document.getElementById("result").innerText = result;
    document.getElementById("error").innerText = errorMessage;

}

async function squareRoot() {
    
    let number = document.getElementById("number").value;
    let decimals = document.getElementById("decimals").value;
      //                       "api/squareroot?number=666&decimal=2"
    //                         "api/squareroot?number=&decimals=6662"
    let response = await fetch("api/squareroot?number=" + number + "&decimals=" +  decimals);


    if (response.status === 200) {
        result = await response.json();
        errorMessage = "";
    }
    else if (response.status === 400) {
        errorMessage = await response.text();
    }
    else {
        errorMessage = "Något gick galet";
    }

    render();
}