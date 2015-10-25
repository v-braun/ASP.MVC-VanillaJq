define(['view/customer/index_sandbox', 'core/mediator'], function ($, mediator) {

    function setCustomerNameLabels(customerKind, sandbox, config){
        if(customerKind == config.CustomerKindPrivate){
            sandbox.setCustomerName1Label(config.PrivateCustomerName1Lbl);
            sandbox.setCustomerName2Label(config.PrivateCustomerName2Lbl);
        }
        else {
            sandbox.setCustomerName1Label(config.BusinessCustomerName1Lbl);
            sandbox.setCustomerName2Label(config.BusinessCustomerName2Lbl);
        }
    }

    return {
        init: function (rootElement, conf) {
            var sandbox = $.create(rootElement);
            var kind = sandbox.getCustomerKind();

            setCustomerNameLabels(kind, sandbox, conf);

            sandbox.onCustomerKindChange(function (newKind) {
                setCustomerNameLabels(newKind, sandbox, conf);
            });

            sandbox.onCustomerNameChange(function (name1, name2) {
                mediator.trigger('customer:change', {name1: name1, name2: name2});
            });
        }
    }
});