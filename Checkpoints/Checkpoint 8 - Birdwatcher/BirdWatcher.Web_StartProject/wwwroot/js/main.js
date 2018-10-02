
async function recreateDatabase() {
    document.getElementById("recreateButton").style.display = "none";
    document.body.style.backgroundColor = "blue";

    let response = await fetch("/observation/recreate", {
        method: "POST"
    });

    if (response.status === 200) {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "green";

    } else {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "red";

    }

}

async function addObservation() {

    let response = await fetch("/observation/addObservation", {
        method: "POST",
        body: JSON.stringify({
            Specie: document.getElementById("addSpecie").value,
            Time: document.getElementById("addTime").value,
            Location: document.getElementById("addLocation").value,
            Note: document.getElementById("addNote").value

        }),
        headers: {
            "Content-Type": "application/json"
        }
    });

    if (response.status === 200) {
        let serverAnswer = await response.text();
        alert(serverAnswer)
    } else {
        alert("nåt fel");
    }

}

async function showAllObservations() {

    let response = await fetch("/observation/show", { method: "GET" });

    let allObservations = await response.json();

    for (let observation of allObservations) {
        console.log(observation.specie);
    }

        //public int Id { get; set; }
        //public string  Specie { get; set; }
        //public DateTime Time { get; set; }
        //public string Location { get; set; }
        //public string Note { get; set; }

    let html = `<tr>
                <th>Id</th>
                <th>Specie</th>
                <th>Time</th>
                <th>Location</th>
                <th>Note</th>
                </tr>`

    for (let observation of allObservations) {
        html += `<tr>
                   <td>${observation.id}</td> 
                   <td>${observation.specie}</td> 
                   <td>${observation.time}</td>
                   <td>${observation.location}</td>
                   <td>${observation.note}</td>
                   </tr>
            `
    }

    document.getElementById("showObservations").innerHTML = html;

}

async function showAllSpecies() {

    let response = await fetch("/observation/showSpecies", { method: "GET" });
    let allSpecies = await response.json();

    for (let observation of allSpecies) {
        console.log(observation.specie);
    }

    let html = `<tr>     
                <th>Specie</th>
                </tr>`

    for (let observation of allSpecies) {

       
        html += `<tr>
                   <td>${observation}</td> 
                   </tr>
            `
    }
    document.getElementById("showSpecies").innerHTML = html;

}