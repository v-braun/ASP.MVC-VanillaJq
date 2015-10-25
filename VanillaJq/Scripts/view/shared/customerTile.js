

define(['view/shared/customerTile_sandbox', 'core/mediator'], function ($, mediator) {
    return {
        init: function (rootElement, conf) {


            var sandbox = $.create(rootElement);

            mediator.off('customer:')

            mediator.on('customer:change', function (event, data) {
                var fullName = data.name1 + ' ' + data.name2;
                sandbox.setCustomerFullName(fullName);
            });


        }
    }
});