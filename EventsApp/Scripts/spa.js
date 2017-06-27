$.getJSON("@Url.Action("GetAllEvents", "Event")", function (data) {
    console.log(data);
});

$('a').on('click', function (e) {
    e.preventDefault();
    let pageRef = $(this).attr('href');

    callPage(pageRef);
});

function callPage(pageRefInput) {
    $.ajax({
        url: pageRefInput,
        type: "get",
        dataType: text,
        success: function (response) {
            console.log('the page was loaded', response);
            $('#eventsSection').html(response);
        },
        error: function (response) {
            console.log("The page was not loaded correctly!", error);
        }
    })
}

function renderEventsList(url, data) {
    //do stuff
}

function renderEventDetails(data) {

}

function renderEditPage(data) {

}