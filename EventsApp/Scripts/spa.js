﻿$.getJSON("@Url.Action("GetAllEvents", "Event")", function (data) {
    -        console.log(data);
    -        let eventCard = $("<div class=\"eventCard\"></div>");
    -        let eventTimer = $("<div class=\"countDown\"></div>");
    -
        -        $.each(data, function (key, value) {
            -            console.log(value);
            -            console.log(value.EventName);
            -            let eventName = $("<div class=\"eventName\">" + value.EventName + "</div>");
            -            $("#eventsCardsHolder").prepend(eventName);
            -        });
});