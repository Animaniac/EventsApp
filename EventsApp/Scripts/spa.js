/*$.getJSON("@Url.Action("GetAllEvents", "Event")", function (data) {
    console.log(data);
}));*/
$(function (){
    $("a").on('click', function (e) {
        e.preventDefault();
        let pageRef = $(this).attr('href');       
        callPage(pageRef);
    });
});


function callPage(pageRefInput) {
    //if the pagerefinput == "/" check the db for a change, if there is none dont reload
    if (pageRefInput !="/") {
        $.ajax({
            url: pageRefInput,
            type: "get",
            dataType: "text",
            success: function (response) {
                console.log('the page was loaded', response);
                $('.singlePage').html(response);
            },
            error: function (response) {
                console.log("The page was not loaded correctly!", error);
            }
    })
    }
    else {
        alert("alert")
    }
    
}

function renderEventsList(url, data) {
    //do stuff
}

function renderEventDetails(data) {

}

function renderEditPage(data) {

}