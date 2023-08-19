$(".product-open-modal").each(function () {
    $(this).click(function () {
        var id = +$(this).attr("data-module-id");
        var module = products[0].modules[id - 1];
        $(".modal-title").html(module.title);
        $(".modal-body").html(module.contentHtml);
        $("#modalModule").modal("show")
    })
});

// открытие модалки
$(".custom-open-modal").each(function () {
    $(this).click(function () {
        $("#modalNews").modal("show")
    })
});