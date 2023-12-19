$(document).on("click", ".delete-contact", function (e) {
    e.preventDefault();
    let Id = $(this).parent().parent().attr("data-id");
    let deletedElem = $(this).parent().parent();
    let data = { id: Id };

    $.ajax({
        url: "contact/Delete",
        type: "post",
        data: data,
        success: function (res) {

            $(deletedElem).remove();
            $(".tooltip-inner").remove();
            $(".arrow").remove();
            if ($(tbody).length == 1) {
                $(".table").remove();
            }
        }
    })
})

$(document).on("click", ".delete-subscribe", function (e) {
    e.preventDefault();
    let Id = $(this).parent().parent().attr("data-id");
    let deletedElem = $(this).parent().parent();
    let data = { id: Id };

    $.ajax({
        url: "subscribe/Delete",
        type: "post",
        data: data,
        success: function (res) {

            $(deletedElem).remove();
            $(".tooltip-inner").remove();
            $(".arrow").remove();
            if ($(tbody).length == 1) {
                $(".table").remove();
            }
        }
    })
})
