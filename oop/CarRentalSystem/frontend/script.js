let rentals = [];

let rentForm = document.getElementById("rentForm");
let returnForm = document.getElementById("returnForm");
let statusDiv = document.getElementById("rentalStatus");

rentForm.addEventListener("submit", function(e){

    e.preventDefault();

    let customerName = document.getElementById("customerName").value;
    let carModel = document.getElementById("carModel").value;
    let rentalDays = document.getElementById("rentalDays").value;

    let rentalId = Math.floor(Math.random()*10000);

    let rental = {
        id: rentalId,
        name: customerName,
        car: carModel,
        days: rentalDays
    };

    rentals.push(rental);

    updateStatus();

    rentForm.reset();

});

returnForm.addEventListener("submit", function(e){

    e.preventDefault();

    let rentalId = document.getElementById("rentalId").value;

    rentals = rentals.filter(r => r.id != rentalId);

    updateStatus();

    returnForm.reset();

});

function updateStatus(){

    statusDiv.innerHTML = "";

    if(rentals.length === 0){
        statusDiv.innerHTML = "No active rentals.";
        return;
    }

    rentals.forEach(r => {

        let div = document.createElement("div");

        div.innerHTML = `
        <b>ID:</b> ${r.id} |
        <b>Customer:</b> ${r.name} |
        <b>Car:</b> ${r.car} |
        <b>Days:</b> ${r.days}
        `;

        statusDiv.appendChild(div);

    });

}