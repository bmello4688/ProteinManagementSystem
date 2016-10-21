

$(function () {
    var ajaxFormSubmit = function () {
        var $form = $(this);

        var option = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-protein-target"));
            $target.replaceWith(data);
        });

        return false;
    };

    $("form[data-protein-ajax='true']").submit(ajaxFormSubmit);
});