define([], function () {
    return {
        create: function ($) {
            return {
                setCustomerName1Label: function (text) {
                    $.find('label[for="FirstName"]').text(text);
                },
                setCustomerName2Label: function (text) {
                    $.find('label[for="LastName"]').text(text);
                },
                getCustomerKind: function () {
                    return $.find('#CustomerKind').val();
                },
                onCustomerKindChange: function (cb) {
                    $.find('#CustomerKind').change(function () {
                        cb($.find('#CustomerKind').val())
                    });
                },

                onCustomerNameChange: function (cb) {
                    $.find('#FirstName, #LastName').change(function () {
                        cb($.find('#FirstName').val(), $.find('#LastName').val())
                    });
                }
            };
        }
    }
});