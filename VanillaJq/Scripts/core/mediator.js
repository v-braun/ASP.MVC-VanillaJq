define(["jquery"], function (jq) {
    return {

        on: function (message, cb) {
            jq(document).on(message, cb);
        },

        off: function (message) {
            jq(document).off(message);
        },

        trigger: function (message, data) {
            jq(document).trigger(message, [data]);
        }

    }
    
});