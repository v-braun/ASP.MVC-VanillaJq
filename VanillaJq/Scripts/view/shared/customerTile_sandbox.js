define([], function () {
    return {
        create: function ($) {
            return {
                setCustomerFullName: function (fullName) {
                    $.find('#customerFullNameLbl').text(fullName);
                },
               
            };
        }
    }
});