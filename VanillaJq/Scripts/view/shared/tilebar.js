

define(['view/shared/tilebar_sandbox', 'viewService'], function ($, viewService) {
    return {
        init: function (rootElement, conf) {


            var sandbox = $.create(rootElement);
            
            viewService.Customer.CustomerTilePartial()
                .then(function (html) {
                    sandbox.setCustomerContent(html);
            });            

            viewService.Vehicle.VehicleTilePartial()
                .then(function (html) {
                    sandbox.setVehicleContent(html);
                });


            viewService.Finance.FinanceTilePartial()
                .then(function (html) {
                    sandbox.setFinanceContent(html);
                });
            
        }
    }
});