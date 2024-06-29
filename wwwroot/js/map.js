
var map = L.map("map").setView([19.077941409940202, -70.43386853309957], 7);

export function createMap() {
    
    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 18
    }).addTo(map);
}

export function addMarker(lat, lng, nombre, apellido, nacionalidad) {
    L.marker([lat, lng]).addTo(map)
        .bindPopup(`<b>${nombre} ${apellido}</b><br />${nacionalidad}`).openPopup();
}