
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

async function addSpecie() {

    let response = await fetch("observation", {
        method: "POST",
        body: JSON.stringify({
            date: byId("addFormDate").value, 
            specie: byId("addFormSpecie").value, 
            location: byId("addFormLocation").value, 
            notes: byId("addFormNotes").value, 
           
        }),
        headers: {
            "Content-Type": "application/json"
        }
    });
    showAllObservations();
    showAllSpecies();
}

function byId(id) {
    return document.getElementById(id);
}
showAllObservations();
showAllSpecies();
async function showAllObservations() {

    let response = await fetch("observation", { method: "GET" });
 
        let allObservations = await response.json();

    let html = `    
        <tr>
            <th>Date</th>
            <th>Specie</th>
            <th>Location</th>
            <th>Notes</th>
        </tr>`
        
        for (let observation of allObservations) {
            //html += observation.specie
            html += `
                    <tr>
                        <td>${observation.date}</td> 
                        <td>${observation.specie}</td>                
                        <td>${observation.location}</td>                
                        <td>${observation.notes}</td>                
                    </tr>
            `       
        }

        byId("showObservations").innerHTML = html;

}

async function showAllSpecies() {

    let response = await fetch("observation/species", { method: "GET" });

    let allObservations = await response.json();

    let html = "";

    for (let observation of allObservations) {
        html += `
                    <tr>
                        <td>${observation.specie}</td>                                                    
                    </tr>
            `
    }

    byId("AllSpecies").innerHTML = html;

    

}

