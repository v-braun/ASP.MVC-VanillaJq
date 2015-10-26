
(function ($) {

    $.fn.animateHtml = function (html) {
        var $container = this;
        var $content = $(html);

        $content.hide();

        $container.children().fadeOut(1000, function () {
            $(this).remove();
            $container.append($content);
            $content.fadeIn(1000);
        });


        return this;
    };

}(jQuery));