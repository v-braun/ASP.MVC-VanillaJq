define([], function () {
    return {
        create: function ($) {
            return {
                setCustomerContent: function (html) {
                    $.find('#custTileContainer').animateHtml(html);
                },
                setVehicleContent: function (html) {
                    $.find('#vehicleTileContainer').animateHtml(html);
                },
                setFinanceContent: function (html) {
                    $.find('#financeTileContainer').animateHtml(html);
                }
            };
        }
    }
});