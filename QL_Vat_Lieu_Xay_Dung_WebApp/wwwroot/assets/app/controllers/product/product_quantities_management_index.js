var QuantitiesManagementAjax = function () {
    var cachedObj = {
        sizes: []
    }

    this.initialize = function () {
        loadSizes();
        registerEvents();
    }

    function registerEvents() {
        $("body").on("click", ".btn-quantities", function (e) {
            e.preventDefault();
            var that = $(this).data("id");
            $("#hidId").val(that);
            loadQuantities();
            $("#modal-quantity-management").modal("show");
        });
        $("body").on("click", ".btn-delete-quantity", function (e) {
            e.preventDefault();
            $(this).closest("tr").remove();
        });

        $("#btn-add-quantity").on("click", function () {
            var template = $("#template-table-quantity").html();
            var render = Mustache.render(template, {
                Id: 0,
                Sizes: getSizeOptions(null),
                Quantity: 0
            });
            $("#table-quantity-content").append(render);
        });
        $("#btnSaveQuantity").on("click", function () {
            var quantityList = [];
            $.each($("#table-quantity-content").find("tr"), function (i, item) {
                quantityList.push({
                    Id: $(item).data("id"),
                    ProductId: $("#hidId").val(),
                    Quantity: $(item).find("input.txtQuantity").first().val(),
                    SizeId: $(item).find("select.ddlSizeId").first().val()
                });
            });
            $.ajax({
                url: "/admin/Product/SaveQuantities",
                data: {
                    productId: $("#hidId").val(),
                    quantities: quantityList
                },
                type: "post",
                dataType: "json",
                success: function () {
                    $("#modal-quantity-management").modal("hide");
                    $("#table-quantity-content").html("");
                    app.notify("Cập nhật sản phẩm thành công", "success");
                },
                error: function () {
                    app.notify("Có lỗi trong quá trình cập nhật hàng tồn", "error");
                }
            });
        });
    }
    function loadQuantities() {
        $.ajax({
            url: "/admin/Product/GetQuantities",
            data: {
                productId: $("#hidId").val()
            },
            type: "get",
            dataType: "json",
            success: function (response) {
                var render = "";
                var template = $("#template-table-quantity").html();
                $.each(response, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Sizes: getSizeOptions(item.SizeId),
                        Quantity: item.Quantity
                    });
                });
                $("#table-quantity-content").html(render);
            }
        });
    }

    function loadSizes() {
        return $.ajax({
            type: "GET",
            url: "/Admin/Bill/GetSizes",
            dataType: "json",
            success: function (response) {
                cachedObj.sizes = response;
            },
            error: function () {
                app.notify("Có lỗi xảy ra", "error");
            }
        });
    }

    function getSizeOptions(selectedId) {
        var sizes = "<select class='form-control ddlSizeId'>";
        $.each(cachedObj.sizes, function (i, size) {
            if (selectedId === size.Id)
                sizes += '<option value="' + size.Id + '" selected="select">' + size.Name + "</option>";
            else
                sizes += '<option value="' + size.Id + '">' + size.Name + "</option>";
        });
        sizes += "</select>";
        return sizes;
    }
}