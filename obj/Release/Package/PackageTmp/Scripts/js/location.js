




if (!('remove' in Element.prototype)) {
    Element.prototype.remove = function () {
        if (this.parentNode) {
            this.parentNode.removeChild(this);
        }
    };
}



mapboxgl.accessToken = 'pk.eyJ1IjoieWVoZW5nZGFnZSIsImEiOiJja2YzbWoxZXIwNG16MnJtY3p4Z29kbXhiIn0.derWjv7LMBcwyNx3ndbL3g';




var locations = [];
// The first step is obtain all the latitude and longitude from the HTML
// The below is a simple jQuery selector
$(".coordinates").each(function () {
    
    var location_info = $(".location", this).text().replace("(", "").replace(")", "").trim();
    var location_info1 = location_info.split(",");
    var longitude = location_info1[1];
    var latitude = location_info1[0];
    var phonenumber = $(".phone1", this).text().trim();
    var suburb = $(".suburb1", this).text().trim();
    var e_address = $(".eaddress1", this).text().trim();
    var address = $(".address1", this).text().trim();
    var name = $(".S_name", this).text().trim();



   
    // Create a point data structure to hold the values.
    var point = {

        "type": "Feature",
        "geometry": {
            "type": "Point",
            "coordinates": [
                longitude,
                latitude
            ]
        }, "properties": {
            "contact_number": phonenumber,
            "email": e_address,
            "suburb": suburb,
            "address": address,
            "name": name
        }
    
    };
    // Push them all into an array.
    locations.push(point);
});

var stores = {
    "type": "FeatureCollection",
    "features": locations
}



stores.features.forEach(function (store, i) {
    store.properties.id = i;
});


var map = new mapboxgl.Map({
    container: 'map',
    style: 'mapbox://styles/mapbox/light-v10',
    center: [(stores.features[0].geometry.coordinates[0]), (stores.features[0].geometry.coordinates[1])],
    zoom: 13
});


map.on('load', function (e) {
  
    map.addSource('places', {
        type: 'geojson',
        data: stores
    });
    addMarkers();
    buildLocationList(stores);




});

function buildLocationList(data) {
 
    data.features.forEach(function (store, i) {
        /**
         * Create a shortcut for `store.properties`,
         * which will be used several times below.
        **/
        var prop = store.properties;

        /* Add a new listing section to the sidebar. */

        var listings = document.getElementById('listings');
        var listing = listings.appendChild(document.createElement('div'));
        /* Assign a unique `id` to the listing. */

        listing.id = "listing-" + prop.id;
        /* Assign the `item` class to each listing for styling. */
        listing.className = 'item';

        /* Add the link to the individual listing created above. */
        link = listing.appendChild(document.createElement('a'));
        link.href = '#';
        link.className = 'title';
        link.id = "link-" + prop.id;
        link.innerHTML = prop.name;
        /* Add details to the individual listing. */
        var details = listing.appendChild(document.createElement('div'));
        details.innerHTML = prop.address;
        if (prop.contact_number) {
            details.innerHTML += ' <br\>tel: ' + prop.contact_number;
        }
        details.innerHTML +="<br\>"+prop.suburb;



        link.addEventListener('click', function (e) {
            var clickedListing = data.features[prop.id];
            flyToStore(clickedListing);
            createPopUp(clickedListing);

            var activeItem = document.getElementsByClassName('active');
            if (activeItem[0]) {
                activeItem[0].classList.remove('active');
            }
            this.parentNode.classList.add('active');
        });

    

    });

  

}

function flyToStore(currentFeature) {
    map.flyTo({
        center: currentFeature.geometry.coordinates,
        zoom: 13
    });
}

//need remove?
function createPopUp(currentFeature) {
  

    var popUps = document.getElementsByClassName('mapboxgl-popup');
    /** Check if there is already a popup on the map and if so, remove it */
    if (popUps[0]) popUps[0].remove();

    var popup = new mapboxgl.Popup({ closeOnClick: false })
        .setLngLat(currentFeature.geometry.coordinates)
        .setHTML('<h3>' + currentFeature.properties.name + '</h3>' +
            '<h4>' + currentFeature.properties.address + '</h4>')
        .addTo(map);
}







function addMarkers() {
    /* For each feature in the GeoJSON object above: */
    stores.features.forEach(function (marker) {
        /* Create a div element for the marker. */
        var el = document.createElement('div');
        /* Assign a unique `id` to the marker. */
        el.id = "marker-" + marker.properties.id;
        /* Assign the `marker` class to each marker for styling. */
        el.className = 'marker';

        /**
         * Create a marker using the div element
         * defined above and add it to the map.
        **/
        new mapboxgl.Marker(el, { offset: [0, -23] })
            .setLngLat(marker.geometry.coordinates)
            .addTo(map);


        el.addEventListener('click', function (e) {
            /* Fly to the point */
            flyToStore(marker);
            /* Close all other popups and display popup for clicked store */
            createPopUp(marker);
            /* Highlight listing in sidebar */
            var activeItem = document.getElementsByClassName('active');
            e.stopPropagation();
            if (activeItem[0]) {
                activeItem[0].classList.remove('active');
            }
            var listing = document.getElementById('listing-' + marker.properties.id);
            listing.classList.add('active');
        });
    });
}