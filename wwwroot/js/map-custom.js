(function ($) {
    "use strict";

    $(document).ready(function () {
        // Dados extraídos do JSON fornecido
        var data = {
            lat: -22.4730787,
            lng: -48.5682614,
            formattedAddress: "Av. Dr. Dionísio Dutra e Silva, 376 - Nucleo Hab. Naza Arradi Nahas, Barra Bonita - SP, 17345-080, Brasil"
        };

        var mapZoom = 15; // Definimos um zoom mais próximo para visualização detalhada
        var imgPin = 'images/icons/location.png'; // Ícone do marcador

        // Inicializa o mapa
        var map = new google.maps.Map(document.getElementById('google_map'), {
            zoom: mapZoom,
            center: new google.maps.LatLng(data.lat, data.lng),
            mapTypeId: google.maps.MapTypeId.ROADMAP
        });

        // Adiciona marcador
        var marker = new google.maps.Marker({
            position: new google.maps.LatLng(data.lat, data.lng),
            map: map,
            icon: imgPin
        });

        // Adiciona janela de informações com o endereço formatado
        var infowindow = new google.maps.InfoWindow({
            content: `<div class="infobox"><strong>Endereço:</strong><br>${data.formattedAddress}</div>`
        });

        // Exibe a janela de informações ao clicar no marcador
        marker.addListener("click", function () {
            infowindow.open(map, marker);
        });

        // Evento para adicionar marcadores adicionais ao clicar no mapa
        map.addListener("click", function (e) {
            var clickedLat = e.latLng.lat();
            var clickedLng = e.latLng.lng();

            // Atualiza o marcador na nova posição clicada
            marker.setPosition(new google.maps.LatLng(clickedLat, clickedLng));

            // Atualiza a janela de informações com as novas coordenadas
            infowindow.setContent(
                `<div class="infobox"><strong>Nova Localização:</strong><br>Latitude: ${clickedLat.toFixed(6)}<br>Longitude: ${clickedLng.toFixed(6)}</div>`
            );
        });
    });
})(jQuery);
