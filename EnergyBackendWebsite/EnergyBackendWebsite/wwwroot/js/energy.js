document.addEventListener('DOMContentLoaded', function () {
    // Simulating data fetching from a backend API
    const energyData = [
        { date: '2023-01-01', consumption: 30 },
        { date: '2023-01-02', consumption: 25 },
        { date: '2023-01-03', consumption: 40 },
        // Add more data as needed
    ];

    displayEnergyData(energyData);
});

function displayEnergyData(data) {
    const energyDataContainer = document.getElementById('energyData');

    if (data.length === 0) {
        energyDataContainer.innerHTML = '<p>No energy consumption data available.</p>';
        return;
    }

    const table = document.createElement('table');
    const headerRow = table.insertRow(0);
    const dateHeader = headerRow.insertCell(0);
    const consumptionHeader = headerRow.insertCell(1);

    dateHeader.innerHTML = 'Date';
    consumptionHeader.innerHTML = 'Consumption (kWh)';

    data.forEach(entry => {
        const row = table.insertRow(-1);
        const dateCell = row.insertCell(0);
        const consumptionCell = row.insertCell(1);

        dateCell.innerHTML = entry.date;
        consumptionCell.innerHTML = entry.consumption;
    });

    energyDataContainer.innerHTML = '';
    energyDataContainer.appendChild(table);
}
