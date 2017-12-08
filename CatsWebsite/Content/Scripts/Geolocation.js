var x = document.getElementById("errors");

function getLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition, showError);
    } else {
        x.innerHTML = "Geolocation is not supported by this browser.";
    }
}

function showPosition(position) {
    document.getElementById("mapholder").innerHTML = "<img src='https://maps.googleapis.com/maps/api/staticmap?center="
        + position.coords.latitude + "," + position.coords.longitude
        + "&zoom=14&size=400x300&markers=color:red%7C"
        + position.coords.latitude + "," + position.coords.longitude
        + "&key=AIzaSyD-yPGNLZ6gvTaB0x6wHRvoqn_5j8QYgUs'>";
}

function showError(error) {
    switch (error.code) {
        case error.PERMISSION_DENIED:
            x.innerHTML = "Geolocation request denied."
            break;
        case error.POSITION_UNAVAILABLE:
            x.innerHTML = "Location info is unavailable."
            break;
        case error.TIMEOUT:
            x.innerHTML = "Geolocation request timed out."
            break;
        case error.UNKNOWN_ERROR:
            x.innerHTML = "An unknown error occurred."
            break;
    }
}