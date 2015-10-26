define(['jquery', 'smoothState'], function ($, ss) {
    return {
        init: function () {
            var content = $('#main').smoothState({
                prefetch: false,
                scroll: true,

            }).data('smoothState');
        }
    }
});