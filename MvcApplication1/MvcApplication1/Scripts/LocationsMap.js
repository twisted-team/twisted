﻿google.load("maps", "2");

// make a json request to get the map data from the Map action
$(function() {
    if (google.maps.BrowserIsCompatible()) {
        //$.getJSON("http://" + window.location.host + "/Home/Map", initialise);
        $.getJSON("/Home/Map", initialise);
    }
});

function initialise(mapData) {
    $("#mapName").text(mapData.Name);

    var map = new google.maps.Map2($("#map")[0]);
    map.addControl(new google.maps.SmallMapControl());
    map.addControl(new google.maps.MapTypeControl());
    map.setMapType(G_SATELLITE_MAP);

    var latlng = new google.maps.LatLng(mapData.LatLng.Latitude, mapData.LatLng.Longitude);
    var zoom = mapData.Zoom;

    map.setCenter(latlng, zoom);

    $.each(mapData.Locations, function(i, location) {
        setupLocationMarker(map, location);
    });
}

function setupLocationMarker(map, location) {

    var latlng = new google.maps.LatLng(location.LatLng.Latitude, location.LatLng.Longitude);
    var marker = new google.maps.Marker(latlng);
    map.addOverlay(marker);

    google.maps.Event.addListener(marker, "click", function(latlng) {
        $("#info").text(location.Name);
        $("#image")[0].src = "../../Content/" + location.Image;
        map.openInfoWindow(latlng, $("<p></p>").text(location.Name)[0]);
    });    
    
}



