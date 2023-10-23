document.addEventListener('DOMContentLoaded', function () {
    const infoForm = document.getElementById('infoForm');
    const tableBody = document.getElementById('tableBody');

    infoForm.addEventListener('submit', function (event) {
        event.preventDefault();
        const email = document.getElementById('emailInput').value;
        const phone = document.getElementById('phoneInput').value;
        const address = document.getElementById('addressInput').value;
        const city = document.getElementById('cityInput').value;
        const state = document.getElementById('stateInput').value;
        const license = document.getElementById('licenseInput').value;
        const vehicle = document.getElementById('vehicleInput').value;

        // Validate the city name, state name, and license number
        if (city.length > 15) {
            alert("City name should not be longer than 15 characters");
            return;
        }
        if (state.length > 20) {
            alert("State name should not be longer than 20 characters");
            return;
        }

        // Create table row
        const newRow = tableBody.insertRow(-1);
        const cell1 = newRow.insertCell(0);
        const cell2 = newRow.insertCell(1);
        const cell3 = newRow.insertCell(2);
        const cell4 = newRow.insertCell(3);
        const cell5 = newRow.insertCell(4);
        const cell6 = newRow.insertCell(5);
        const cell7 = newRow.insertCell(6);

        cell1.innerHTML = email;
        cell2.innerHTML = phone;
        cell3.innerHTML = address;
        cell4.innerHTML = city;
        cell5.innerHTML = state;
        cell6.innerHTML = license;
        cell7.innerHTML = vehicle;

        // Store data in session storage
        let storedData = JSON.parse(sessionStorage.getItem('storedData')) || [];
        storedData.push({ email, phone, address, city, state, license, vehicle });
        sessionStorage.setItem('storedData', JSON.stringify(storedData));

        // Reset the form
        infoForm.reset();
    });

    // Load data from session storage on page load
    const storedData = JSON.parse(sessionStorage.getItem('storedData')) || [];
    for (let data of storedData) {
        const newRow = tableBody.insertRow(-1);
        const cell1 = newRow.insertCell(0);
        const cell2 = newRow.insertCell(1);
        const cell3 = newRow.insertCell(2);
        const cell4 = newRow.insertCell(3);
        const cell5 = newRow.insertCell(4);
        const cell6 = newRow.insertCell(5);
        const cell7 = newRow.insertCell(6);

        cell1.innerHTML = data.email;
        cell2.innerHTML = data.phone;
        cell3.innerHTML = data.address;
        cell4.innerHTML = data.city;
        cell5.innerHTML = data.state;
        cell6.innerHTML = data.license;
        cell7.innerHTML = data.vehicle;
    }
});
