define([], function () {
    return {
        create: function ($) {
            return {
                setCustomerContent: function (html) {
                    $.find('#custTileContainer').html(html);
                },
                setVehicleContent: function (html) {
                    $.find('#vehicleTileContainer').html(html);
                },
                setFinanceContent: function (html) {
                    $.find('#financeTileContainer').html(html);
                }
            };
        }
    }
});