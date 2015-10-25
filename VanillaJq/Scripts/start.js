'use strict';



define([], function () {

    function configureRequireJs(root) {
        requirejs.config({
            baseUrl: root,
            paths: {
                // the left side is the module ID,
                // the right side is the path to
                // the jQuery file, relative to baseUrl.
                // Also, the path should NOT include
                // the '.js' file extension. This example
                // is using jQuery 1.9.0 located at
                // js/lib/jquery-1.9.0.js, relative to
                // the HTML page.
                jquery: 'jquery-2.1.4',
                bootstrap: 'core/vendor/bootstrap.min',
                viewService: '../MetaData/View?noext'
            },
            shim: {
                'bootstrap': ['jquery']
            }
        });
    }
    
    function initModule($moduleRoot) {
        var moduleName = $moduleRoot.data('module');
        var config = {};
        try {
            var content = $moduleRoot.data('module-config');
            if (typeof content == "string") {
                content = content.trim();
                if (content !== '')
                    config = JSON.parse(content);
            }
            else if (typeof content == "object") {
                config = content;
            }            
        }
        catch (e) {
            console.error(e);
        }


        require([moduleName], function (module) {
            module.init($moduleRoot, config);
        });
    }


    var appTag = document.querySelector("script[data-main]");
    var path = appTag.getAttribute('data-base-path');
    configureRequireJs(path);

    require(["jquery", "bootstrap"], function ($, bootstrap) {
        $(document).ready(function () {

            $('*[data-module]').each(function () {
                var $module = $(this);
                initModule($module);
            });

            $(document).on('DOMNodeInserted', '*[data-module]', function (event) {
                if (event.target == event.currentTarget) {
                    var $module = $(event.target)
                    initModule($module);
                }
            });
        });
    });
});

